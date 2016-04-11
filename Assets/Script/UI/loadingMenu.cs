using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadingMenu : MonoBehaviour {

    public GameObject LoadPanel;
    int MaxRan = 3;

	// Use this for initialization
	void Start () {
        LoadPanel = LoadPanel.GetComponent<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {




	     if(Time.deltaTime >= 10)
        {
            ///LoadPanel.GetComponent<Image>().

            SceneManager.LoadScene(3);
        }
	}
}
