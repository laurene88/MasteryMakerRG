using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MasteryMakerCode : MonoBehaviour
{
    [SerializeField]
    public GameObject ApparatusButtonPanel;
    public GameObject resultsHolder;
    private bool ApparatusButtonPanelVisible = false;


    //How to link between scenes. 
    // How to git push particular parts
    //   how to change sprites to show ans


    void Start ()
    {
        // Initialise array of all apparatus arrays. 

    }

    //MENUPAGE SCENE
    public void PressApparatusButton ()
    {
        ApparatusButtonPanelVisible = !ApparatusButtonPanelVisible;
        ApparatusButtonPanel.SetActive(ApparatusButtonPanelVisible);
    }

    public void ChooseBall()
    {
        //TEST
        SceneManager.LoadScene(1);
      //  int r = Random.Range(0,ballBases.Length-1);
       // return ballBases[r];
    }

}
