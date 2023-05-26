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
    public bool criteria = false; //The result is a criteria, not a base


    void Awake()
    {
        DontDestroyOnLoad(this);
        allBases = new Sprite[][]{hoopBases, clubsBases, ropeBases, ribbonBases, ballBases};

    }

    public void ChooseCriteriaOneButton()
    {
        criteria = true;
        int r = Random.Range(0,criterias.Length-1);
        result1 = criterias[r];
        changeScene();
    }

    public void ChooseCriteriaTwoButton()
    {
        criteria = true;
        int r = Random.Range(0,criterias.Length-1);
        int s = 0;
        do
        {
            s = Random.Range(0,criterias.Length-1);
        } 
        while (r == s);
        result1 = criterias[r];
        result2 = criterias[s];
        changeScene();
    }

    public void ChooseRandomBase()
    {
        // Pick random sprite out of jagged array of all bases.
        int r = Random.Range(0,allBases.Length-1);
        //RECHECK when all lists are filled
        int s = Random.Range(0,(allBases[r].Length-1)); //not currently working as length 0- (0-1) is out of bounds
        result1 =  allBases[r][s];
        changeScene();
    }

    public void ChooseHoop()
    {
        int r = Random.Range(0,hoopBases.Length-1);
        result1 = hoopBases[r]; 
        changeScene();
    }

    public void ChooseBall()
   {
        int r = Random.Range(0,ballBases.Length-1);
        result1 = ballBases[r];
        changeScene();
    }

    public void ChooseRope()
    {
        int r = Random.Range(0,ropeBases.Length-1);
        result1 = ropeBases[r];
        changeScene();
    }

    public void ChooseClubs()
    {
        int r = Random.Range(0,clubsBases.Length-1);
        result1 = clubsBases[r];
       changeScene();
    }

    public void ChooseRibbon()
    {
        int r = Random.Range(0,ribbonBases.Length-1);
        result1 = ribbonBases[r];
        changeScene();
    }

    public void changeScene()
    {
        SceneManager.LoadScene(1);
    }

    public Sprite[] getResults()
    {   
        Sprite[] results = new Sprite[]{result1, result2};
        return (results);
    }
}
