using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultHolder : MonoBehaviour
{

    [SerializeField]
    public Sprite[] criterias;
    public Sprite[] hoopBases;
    public Sprite[] clubsBases;
    public Sprite[] ropeBases;
    public Sprite[] ribbonBases;
    public Sprite[] ballBases;
    public Sprite[][] allBases;
    public Sprite result1;
    public Sprite result2;


    void Awake()
    {
        DontDestroyOnLoad(this);
        allBases = new Sprite[][]{hoopBases, clubsBases, ropeBases, ribbonBases, ballBases};
    }

    public void ChooseCriteriaOneButton()
    {
        int r = Random.Range(0,criterias.Length-1);
        result1 = criterias[r];
        Debug.Log(r);
        Debug.Log(criterias[r].name);
    }

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
        Debug.Log(criterias[r].name);
        Debug.Log(criterias[s].name);

    }

    public void ChooseRandomBase()
    {
        // Pick random sprite out of jagged array of all bases.
        int r = Random.Range(0,allBases.Length-1);
        int s = Random.Range(0,allBases[r].Length-1);
        Sprite result =  allBases[r][s];
        Debug.Log(result.name);
        
    }

    public void ChooseHoop()
    {
        int r = Random.Range(0,hoopBases.Length-1);
       // return hoopBases[r];
       Debug.Log(r);
       Debug.Log(hoopBases[r].name);

       
    }

    //public void ChooseBall()
   // {
        //TEST
      //  SceneManager.LoadScene(1);
      //  int r = Random.Range(0,ballBases.Length-1);
       // return ballBases[r];
    //}

    public void ChooseRope()
    {
        int r = Random.Range(0,ropeBases.Length-1);
       // return ropeBases[r];
    }

    public void ChooseClubs()
    {
        int r = Random.Range(0,clubsBases.Length-1);
       // return clubsBases[r];
    }

    public void ChooseRibbon()
    {
        int r = Random.Range(0,ribbonBases.Length-1);
       // return ribbonBases[r];
    }


    
}
