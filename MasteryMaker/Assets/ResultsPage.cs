using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultsPage : MonoBehaviour
{
    public void PressReturnButton()
    {
        //loads in single mode automatically
        SceneManager.LoadScene(0);
    }

}
