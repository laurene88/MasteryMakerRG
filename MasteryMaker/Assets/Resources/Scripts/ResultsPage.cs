using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultsPage : MonoBehaviour
{
    [SerializeField]
    public GameObject resultsHolder;
    private ResultHolder resultHolderScript;
    [SerializeField] private RectTransform resultspanel;
    [SerializeField] private RectTransform resultsbox1;
    [SerializeField] private RectTransform resultsbox2;
    private Sprite c1;
    private Sprite c2;

    public void Start()
    {
        //Find results holder
        resultsHolder = GameObject.Find("ResultsHolder");
        if (resultsHolder == null){
        Debug.Log("no results holder found");
        }   
        Debug.Log(resultsHolder.name);

        //Access results holder script
        resultHolderScript = resultsHolder.GetComponent<ResultHolder>();
       
        //get result sprites from result holder 
        //CURRENT ISSUE RESIZING of CRITERIA v BASE sprites.
        //THIS MAY NEED A SECOND PANEL?
        if (resultHolderScript != null)
        {
        Sprite[] results = resultHolderScript.getResults();

        //set result sprites, if there are 2, create a new result box & set also.
        resultsbox1.GetComponent<Image>().sprite = results[0];
        if (results[1] != null)
        {
            resultsbox2 = Instantiate(resultsbox1, resultspanel);
            resultsbox2.GetComponent<Image>().sprite = results[1];
        }
        }
    }
    

    public void PressReturnButton()
    {
        // Destroy results holder so doesnt duplicate on scene changing
        Destroy(resultsHolder);
        //destroy 2nd image in results panel if there is one?
        //loads in single mode automatically
        SceneManager.LoadScene(0);
    }
}


