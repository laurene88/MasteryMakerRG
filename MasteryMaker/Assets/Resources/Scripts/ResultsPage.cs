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
    [SerializeField] private GameObject resultspanel;
    [SerializeField] private RectTransform resultsbox1;
    [SerializeField] private RectTransform resultsbox2;
    [SerializeField] private GameObject basebox;
    private Sprite[] results;
    private bool isCriteria;


    public void Start()
    {
        //Find results holder and its script, which shares generated result to show.
        resultsHolder = GameObject.Find("ResultsHolder");
        if (resultsHolder == null){
        Debug.Log("no results holder found");
        } else{
            resultHolderScript = resultsHolder.GetComponent<ResultHolder>();  
        }
       
        //get result sprites from result holder 
        if (resultHolderScript != null)
        {
            results = resultHolderScript.getResults();
            isCriteria = resultHolderScript.getIsCriteria();

            if (isCriteria)
            {
                criteriaResult();
            } else {
                baseResult();
            }
        }
    }
    

    // These are treated as two different functions due to the different shape of the
    // base image and the criterion images.
    // Each therefore has its own 'image' in the scene, and will delete the one not needed.
    // For criteria where there may be two, this image is in a panel with a layout group.
    public void baseResult()
    {
        basebox.GetComponent<Image>().sprite = results[0];
        resultspanel.SetActive(false);
    }

    public void criteriaResult()
    {
        basebox.SetActive(false);
            if (results[1] != null) 
        {
            resultsbox2 = Instantiate(resultsbox1, resultspanel.GetComponent<RectTransform>());
            resultsbox2.GetComponent<Image>().sprite = results[1]; 
        } else {
            resultsbox1.GetComponent<Image>().sprite = results[0];
        }        
    }

    public void PressReturnButton()
    {
        // Destroy results holder so doesnt duplicate on scene changing back to the main menu.
        Destroy(resultsHolder);
        //loads in single mode automatically, meaning a second results box (if created)
        // will be automatically deleted at the scene change back to main menu.
        SceneManager.LoadScene(0);
    }
}


