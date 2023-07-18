using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MasteryMakerCode : MonoBehaviour
{
    
    private GameObject ApparatusButtonPanel;
    private GameObject AboutPanel;
    private bool ApparatusButtonPanelVisible = false;
    private bool AboutPanelVisible = false;

    private void Awake()
    {  
        //Set reference for ApparatusButtonPanel and set to not-active.
        ApparatusButtonPanel = GameObject.Find("ApparatusButtonPanel");
        if (ApparatusButtonPanel != null){
            ApparatusButtonPanel.SetActive(false);
        }

        //Set reference for AboutPanel and set to not-active.
        AboutPanel = GameObject.Find("AboutPanel");
        if (AboutPanel != null){
            AboutPanel.SetActive(false);
        }

        // Ensures that transition fade image is active.
        var transition_in = GameObject.Find("Transition_In");
        if (transition_in != null) {
            transition_in.SetActive(true);
        }
    }
    

    // Open and close panel with buttons for different apparatus.
    private void PressApparatusButton ()
    {
        ApparatusButtonPanelVisible = !ApparatusButtonPanelVisible;
        ApparatusButtonPanel.SetActive(ApparatusButtonPanelVisible);
    }

    // Open and close About information Panel
    private void pressAboutButton()
    {
        AboutPanelVisible = !AboutPanelVisible;
        AboutPanel.SetActive(AboutPanelVisible);
    }

    private void pressBackButtonAboutPanel()
    {
        AboutPanel.SetActive(false);
    }
}
