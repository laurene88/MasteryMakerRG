using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultsPage : MonoBehaviour
{
    [SerializeField]
    public GameObject resultsHolder;
    public RectTransform resultspanel;
    public RectTransform resultsbox1;
    public RectTransform resultsbox2;
    public Sprite c1;
    public Sprite c2;

    public void Start()
    {
        resultsHolder = GameObject.Find("ResultsHolder");
        if (resultsHolder == null){
        Debug.Log("no results holder found");
        }   
        Debug.Log(resultsHolder.name);
    }
    
    //public void Start()
    //{
        //?? How to Acess its variables from this script?

        //get result box & set its image to result.
     //   if (resultsHolder.result2 != null)
       // {
        //    resultsbox1.GetComponent<Image>().sprite = resultsHolder.result1;
        //}
        //if two results needed duplicate result
        //if (resultsHolder.result2 != null) {
         //   resultsbox2 = Instantiate(resultsbox1, resultspanel);
           // resultsbox2.GetComponent<Image>().sprite = resultsHolder.result2;
       // }
    
   
    public void PressReturnButton()
    {
        GameObject rh = GameObject.Find("ResultsHolder");
        Destroy(rh);
        //destroy 2nd image in results panel if there is one?
        //loads in single mode automatically
        SceneManager.LoadScene(0);
    }
}


