using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MasteryMakerCode : MonoBehaviour
{
    [SerializeField]
    public GameObject ApparatusButtonPanel;
    private bool ApparatusButtonPanelVisible = false;


    
    void Start ()
    {
     
    }
    
    //MENUPAGE SCENE
    public void PressApparatusButton ()
    {
        ApparatusButtonPanelVisible = !ApparatusButtonPanelVisible;
        ApparatusButtonPanel.SetActive(ApparatusButtonPanelVisible);
    }

    //RESULTSPAGE SCENE
    public void PressReturnButton()
    {
        //loads in single mode automatically
        SceneManager.LoadScene(0);
    }

}
