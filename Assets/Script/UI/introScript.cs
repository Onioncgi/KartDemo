using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class introScript : MonoBehaviour {


    ///Games Convas
    public Canvas loadmenu;
    public Canvas SetPlayer;
    public Canvas SetCar;

    public Canvas SelOkReturn;



    /// <summary>
    /// panel showing 
    /// </summary>
    public GameObject expanel;
    public GameObject stpanel;
    public static bool ishowing = false;
    public static bool EtShowing = false;
    static int setuptoreturn =(3);



    //button showing
    GameObject PExit;
    GameObject PStart;
    GameObject Pload;

    GameObject buttonok;
    GameObject buttoncan;

    GameObject PlayerOkBn;
    GameObject PlayerRetBn;

    // Use this for initialization
    void Start () {

        loadmenu = loadmenu.GetComponent<Canvas>();
        SetPlayer = SetPlayer.GetComponent<Canvas>();
        SetCar = SetCar.GetComponent<Canvas>();
        SelOkReturn = SelOkReturn.GetComponent<Canvas>();
        ////////
        PlayerOkBn = GetComponent<GameObject>();
        PlayerOkBn = GameObject.Find("OkBn");
        PlayerRetBn = GetComponent<GameObject>();
        PlayerRetBn = GameObject.Find("ReturnBn");


        buttonok = GetComponent<GameObject>();
        buttonok = GameObject.Find("Yes");

        buttoncan = GetComponent<GameObject>();
        buttoncan = GameObject.Find("No");

        Pload  = GetComponent<GameObject>();
        Pload = GameObject.Find("Load");

        PStart = PStart.GetComponent<GameObject>();
        PStart = GameObject.Find("create");

        PStart = PStart.GetComponent<GameObject>();
        PStart = GameObject.Find("exit");

        stpanel = stpanel.GetComponent<GameObject>();
        expanel = expanel.GetComponent<GameObject>();

       
    }
	
    public void StartPanelV()
    {
        expanel.SetActive(false);
        ishowing = !ishowing;
        stpanel.SetActive(ishowing);
        
        
    }

    public void ExitPanelV()
    {
        stpanel.SetActive(false);
        EtShowing = !EtShowing;
        expanel.SetActive(EtShowing);
        
    }
    
    public void LoadPanel()
    {
        print("Load button is press");
    }

    public void SetupPlayerMenu()
    {
        SetPlayer.enabled = true;
        loadmenu.enabled  = false;
        SetCar.enabled    = false;
        SelOkReturn.enabled = true;
    }

        public void playerSelection()
    {

    }

    public void playerok()
    {
        SetPlayer.enabled = false;
        loadmenu.enabled = false;
        SetCar.enabled = true;
        
    }

    public void playerReturn()
    {
        if (setuptoreturn ==0)
        {
            SetPlayer.enabled = true;
            loadmenu.enabled = false;
            SetCar.enabled = false;
            setuptoreturn = 2;
        }
        else if(setuptoreturn==2)
        {
            SetPlayer.enabled = false;
            loadmenu.enabled = true;
            SetCar.enabled = false;
            SelOkReturn.enabled = false;
            setuptoreturn = 1;
        }
        else
        {
            LoadMainMenu();
        }    
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(1);

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    
}
