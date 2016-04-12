using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMneuScript : MonoBehaviour
{

    public GameObject StartGBn;
    // Use this for initialization
    void Start()
    {
        StartGBn = StartGBn.GetComponent<GameObject>();
    }

    public void startLevel()
    {
        SceneManager.LoadScene(2);
    }

   public void MultiPlMenu()
    {

    }

    public void Setting()
    {

    }
    
}
