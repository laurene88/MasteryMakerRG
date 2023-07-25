using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ResultHolder : MonoBehaviour
{
    // Sprite lists of all criteria/base images from the Code of Points.
    [SerializeField] private Sprite[] criterias;
    [SerializeField] private Sprite[] hoopBases;
    [SerializeField] private Sprite[] clubsBases;
    [SerializeField] private Sprite[] ropeBases;
    [SerializeField] private Sprite[] ribbonBases;
    [SerializeField] private Sprite[] ballBases;

    // Create empty jagged array for all base sprites.
    private Sprite[][] allBases;

    // Parameters for storing randomly selected sprites.
    public Sprite result1;
    public Sprite result2;
    
    // Parameters for result information, criteria/base and relevant apparatus name.
    public bool isCriteria = false;
    public string apparatusName;


    void Awake()
    {
        // Result Holder must persist between menu page and result page.
        DontDestroyOnLoad(this);

        // Create jagged array of all bases.
        allBases = new Sprite[][]{hoopBases, clubsBases, ropeBases, ribbonBases, ballBases};

        // Load in all result sprites to their respective list.
        criterias = Resources.LoadAll<Sprite>("Images/criteria");
        hoopBases = Resources.LoadAll<Sprite>("Images/Hoop Bases");
        clubsBases = Resources.LoadAll<Sprite>("Images/Clubs Bases");
        ropeBases = Resources.LoadAll<Sprite>("Images/Rope Bases");
        ribbonBases = Resources.LoadAll<Sprite>("Images/Ribbon Bases");
        ballBases = Resources.LoadAll<Sprite>("Images/Ball Bases");
    }
    

    // Accessor for results, returning sprites in array form
    public Sprite[] getResults()
    {   
        Sprite[] results = new Sprite[]{result1, result2};
        return (results);
    }


    public bool getIsCriteria()
    {
        return isCriteria;
    }

    public string getApparatusName()
    {
        return apparatusName;
    }


    // Change to Scene 1 (The Results page)
    public void changeScene()
    {
        SceneManager.LoadScene(1);
    }


    //---------------------------------------------------------------------------------
    // RESULT RANDOMISER FUNCTIONS
    // The below functions all choose a random result or two from the appropriate list.
    // The chosen Sprites are set as result1 (+/- result2)
    // The scene is then changed to the results page
    //--------------------------------------------------------------------------------- 

    public void ChooseCriteriaOneButton()
    {
        int r = Random.Range(0,criterias.Length);
        result1 = criterias[r];
        isCriteria = true;
        changeScene();
    }


    // Choose 2 different criteria results.
    public void ChooseCriteriaTwoButton()
    {
        int r = Random.Range(0,criterias.Length);
        int s = 0;
        do
        {
            s = Random.Range(0,criterias.Length);
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
        // Switch identifies appropriate apparatus name, to be printed in the corner of the 
        //    result image on the results page. This is because some bases are duplicated and
        //    so the apparatus type needs to be explicit.
        int r = Random.Range(0,allBases.Length);
        int s = Random.Range(0,(allBases[r].Length));
        result1 =  allBases[r][s];
        isCriteria = false;
        switch(r)
        {
            case 0:
                apparatusName = "Hoop";
                break;
            case 1:
                apparatusName = "Clubs";
                break;
            case 2:
                apparatusName = "Rope";
                break;
            case 3:
                apparatusName = "Ribbon";
                break;
            case 4:
                apparatusName = "Ball";
                break;
            default:
                break;
        }
        changeScene();
    }

    // Choose base from appropriate Apparatus list after button press.
    public void ChooseHoop()
    {
        apparatusName = "Hoop";
        int r = Random.Range(0,hoopBases.Length);
        result1 = hoopBases[r]; 
        isCriteria = false;
        changeScene();
    }

    public void ChooseBall()
   {
        apparatusName = "Ball";
        int r = Random.Range(0,ballBases.Length);
        result1 = ballBases[r];
        isCriteria = false;
        changeScene();
    }

    public void ChooseRope()
    {
        apparatusName = "Rope";
        int r = Random.Range(0,ropeBases.Length);
        result1 = ropeBases[r];
        isCriteria = false;
        changeScene();
    }

    public void ChooseClubs()
    {
        apparatusName = "Clubs";
        int r = Random.Range(0,clubsBases.Length);
        result1 = clubsBases[r];
        isCriteria = false;
       changeScene();
    }

    public void ChooseRibbon()
    {
        apparatusName = "Ribbon";
        int r = Random.Range(0,ribbonBases.Length);
        result1 = ribbonBases[r];
        isCriteria = false;
        changeScene();
    }


}
