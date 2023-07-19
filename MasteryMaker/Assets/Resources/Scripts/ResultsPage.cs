using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ResultsPage : MonoBehaviour
{
    [SerializeField]
    public GameObject resultsHolder;
    private ResultHolder resultHolderScript;
    [SerializeField] private GameObject resultspanel;
    [SerializeField] private RectTransform resultsbox1;
    [SerializeField] private RectTransform resultsbox2;
    [SerializeField] private GameObject basebox;
    [SerializeField] private TMP_Text apparatusText;
    private Sprite[] results;
    private bool isCriteria;
    private string apparatusName;


    public void Start()
    {
        // Find results holder and its script, which shares generated result to show.
        // If no result holder, return to menu page.
        resultsHolder = GameObject.Find("ResultsHolder");
        if (resultsHolder != null){
        resultHolderScript = resultsHolder.GetComponent<ResultHolder>();  
        } else {
            SceneManager.LoadScene(0);
        }
       
       
        // Gets from results holder: result sprites, iscriteria bool, name of apparatus for base.
        // Sets apparatus name in text in UI.
        // Initiates showing result, 1 of 2 formats dependent on criteria or base result.
        if (resultHolderScript != null)
        {
            results = resultHolderScript.getResults();
            isCriteria = resultHolderScript.getIsCriteria();
            apparatusText.text = resultHolderScript.getApparatusName();
            if (results[0] != null){
                if (isCriteria)
                {
                    criteriaResult();
                } else {
                    baseResult();
                }
            } 
        }
    }

    // These are treated as two different functions due to the different shape of the
    // 'bases' images and the 'criteria' images.
    // Each therefore has its own 'image' in the scene, and will delete the one not needed.
    // Each sets the appropriate result sprite to the appropriate shaped panel image.
    // For criteria where there may be two, this image is in a panel with a layout group.
    public void baseResult()
    {        
        resultspanel.SetActive(false);
        basebox.GetComponent<Image>().sprite = results[0];
    }


    public void criteriaResult()
    {
        basebox.SetActive(false);
            if (results[1] != null) 
        {
            resultsbox2 = Instantiate(resultsbox1, resultspanel.GetComponent<RectTransform>());
            resultsbox2.GetComponent<Image>().sprite = results[1]; 
        } 
            resultsbox1.GetComponent<Image>().sprite = results[0];       
    }


    // Return button, returns user to main menu page.
    // This deletes the 'resultsHolder' so that it doesn't duplicate.
    public void PressReturnButton()
    {
        Destroy(resultsHolder);
        SceneManager.LoadScene(0);
    }
}


