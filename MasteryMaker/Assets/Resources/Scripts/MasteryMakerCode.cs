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

    public void PressApparatusButton ()
    {
        ApparatusButtonPanelVisible = !ApparatusButtonPanelVisible;
        ApparatusButtonPanel.SetActive(ApparatusButtonPanelVisible);
    }

}
