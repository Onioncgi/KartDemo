using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class loadingMenu : MonoBehaviour
{
    public Sprite red;
    public Sprite green;
    public Sprite blue;
    public GameObject loadingpl;
 
  
    void Start()
    {
        
        int x = Random.Range(0, 2);
        if (x == 0)
            loadingpl.GetComponent<Image>().sprite = red;
        else if(x==1)
        loadingpl.GetComponent<Image>().sprite = blue;
        else if(x==2)
        loadingpl.GetComponent<Image>().sprite = green;
    }
    
      // Update is called once per frame
    void Update()
    {
        
        if (Time.timeSinceLevelLoad > 10)
        {                       
            SceneManager.LoadScene(3);
        }

    }


}