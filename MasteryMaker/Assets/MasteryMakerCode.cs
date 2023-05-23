using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MasteryMakerCode : MonoBehaviour
{
    [SerializeField]
    public GameObject ApparatusButtonPanel;
    private bool ApparatusButtonPanelVisible = false;
    public Sprite[] criterias;
    public Sprite[] hoopBases;
    public Sprite[] clubsBases;
    public Sprite[] ropeBases;
    public Sprite[] ribbonBases;
    public Sprite[] ballBases;
    //public Sprite[][] allBases 

    //How to link between scenes. 

    void Start ()
    {
        //initialise array of arrays?
        //allBases = new Sprite[][] (hoopBases, clubsBases, ropeBases, ribbonBases, ballBases);
    }

    //MENUPAGE SCENE
    private void PressApparatusButton ()
    {
        ApparatusButtonPanelVisible = !ApparatusButtonPanelVisible;
        ApparatusButtonPanel.SetActive(ApparatusButtonPanelVisible);
    }

    private void PressCriteriaOneButton()
    {
        //
    }

    private void PressCriteriaTwoButton()
    {
        //
    }

    private void ChooseRandomBase()
    {
        //random choice of array name
        int r = Random.Range(0,5);
        //string arrayChoiceName = allBases[r];
        //Sprite[] arrayChoice = then find array/private varieble named that.
        //int s = RandomRange(0,arrayChoice.Length);
       //return arrayChoice[s];
   
        // then random number from length of that array
    }

    private void ChooseHoop()
    {
        int r = Random.Range(0,hoopBases.Length);
       // return hoopBases[r];
    }

    private void ChooseBall()
    {
        int r = Random.Range(0,ballBases.Length);
       // return ballBases[r];
    }

    private void ChooseRope()
    {
        int r = Random.Range(0,ropeBases.Length);
       // return ropeBases[r];
    }

    private void ChooseClubs()
    {
        int r = Random.Range(0,clubsBases.Length);
       // return clubsBases[r];
    }

    private void ChooseRibbon()
    {
        int r = Random.Range(0,ribbonBases.Length);
       // return ribbonBases[r];
    }


    
    public void toResultPage(Sprite resultSprite) // THis may give either 1 or two sprites!
    {
        SceneManager.LoadScene(1);
        //so resultcode in ResultPage
        //do animation
        //show result sprite
    }

    public void toResultPage(Sprite resultSpritea, Sprite resultSpriteb)
    {
        SceneManager.LoadScene(1);
        //so resultcode in ResultPage
        //do animation
        //show result sprite
    }

}
