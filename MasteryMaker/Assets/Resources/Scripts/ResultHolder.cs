using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultHolder : MonoBehaviour
{
    [SerializeField] private Sprite[] criterias;
    [SerializeField] private Sprite[] hoopBases;
    [SerializeField] private Sprite[] clubsBases;
    [SerializeField] private Sprite[] ropeBases;
    [SerializeField] private Sprite[] ribbonBases;
    [SerializeField] private Sprite[] ballBases;
    private Sprite[][] allBases;
    public Sprite result1;
    public Sprite result2;
    public bool isCriteria = false; //The result is a criteria, not a base


    void Awake()
    {
        DontDestroyOnLoad(this);
        // Create jagged array of all bases.
        allBases = new Sprite[][]{hoopBases, clubsBases, ropeBases, ribbonBases, ballBases};

    }
    
    // Accessor for results sprites in list form
    public Sprite[] getResults()
    {   
        Sprite[] results = new Sprite[]{result1, result2};
        return (results);
    }

    // Accessor for boolean if result is a criteria (or not, and is therefore a base).
    public bool getIsCriteria()
    {
        return isCriteria;
    }

    // Changes scene to show result page.
    public void changeScene()
    {
        SceneManager.LoadScene(1);
    }

    // The below functions all choose a random result or two from the appropriate list.
    // The result(s) are set as result1 (+/- result2)
    // And the scene is changed to the results page
    public void ChooseCriteriaOneButton()
    {
        int r = Random.Range(0,criterias.Length-1);
        result1 = criterias[r];
        isCriteria = true;
        changeScene();
    }


    // Choose 2 different criteria results.
    public void ChooseCriteriaTwoButton()
    {
        int r = Random.Range(0,criterias.Length-1);
        int s = 0;
        do
        {
            s = Random.Range(0,criterias.Length-1);
        } 
        while (r == s);
        result1 = criterias[r];
        result2 = criterias[s];
        isCriteria = true;
        changeScene();
    }

    public void ChooseRandomBase()
    {
        // Pick random sprite out of jagged array of all bases.
        int r = Random.Range(0,allBases.Length-1);
        int s = Random.Range(0,(allBases[r].Length-1));
        result1 =  allBases[r][s];
        isCriteria = false;
        changeScene();
    }

    public void ChooseHoop()
    {
        int r = Random.Range(0,hoopBases.Length-1);
        result1 = hoopBases[r]; 
        isCriteria = false;
        changeScene();
    }

    public void ChooseBall()
   {
        int r = Random.Range(0,ballBases.Length-1);
        result1 = ballBases[r];
        isCriteria = false;
        changeScene();
    }

    public void ChooseRope()
    {
        int r = Random.Range(0,ropeBases.Length-1);
        result1 = ropeBases[r];
        isCriteria = false;
        changeScene();
    }

    public void ChooseClubs()
    {
        int r = Random.Range(0,clubsBases.Length-1);
        result1 = clubsBases[r];
        isCriteria = false;
       changeScene();
    }

    public void ChooseRibbon()
    {
        int r = Random.Range(0,ribbonBases.Length-1);
        result1 = ribbonBases[r];
        isCriteria = false;
        changeScene();
    }



}
