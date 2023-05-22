using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasteryMakerCode : MonoBehaviour
{
    [SerializeField]
    public GameObject ApparatusButtonPanel;
    private bool ApparatusButtonPanelVisible = false;
    
    void Start ()
    {

    }
    
    
    public void PressApparatusButton ()
    {
        ApparatusButtonPanelVisible = !ApparatusButtonPanelVisible;
        ApparatusButtonPanel.SetActive(ApparatusButtonPanelVisible);
    }

}
