using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MasteryMakerCode : MonoBehaviour
{
    
    [SerializeField] private GameObject ApparatusButtonPanel;
    [SerializeField] private GameObject AboutPanel;
   // [SerializeField] private GameObject resultsHolder;
    private bool ApparatusButtonPanelVisible = false;

    private void Start()
    {
        //ensure all things are found - null check?
        //get apparatus panel
        //get about panel
        //get results holder - actually not necessary? this code doesnt use it.
        AboutPanel.SetActive(false);
        ApparatusButtonPanel.SetActive(false);

    }

    public void PressApparatusButton ()
    {
        ApparatusButtonPanelVisible = !ApparatusButtonPanelVisible;
        ApparatusButtonPanel.SetActive(ApparatusButtonPanelVisible);
    }

    public void pressAboutButton()
    {
        AboutPanel.SetActive(true);
    }

    public void pressBackButtonAboutPanel()
    {
        AboutPanel.SetActive(false);
    }
}
