using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GameStart : MonoBehaviour {


    public GameObject player;
    public GameObject img;
    public Sprite im2;
    public Sprite im3;
    public Sprite go;

    // Use this for initialization
    void Start () {

        player.GetComponent<Drive2>().enabled = false;
        

        
	}
	
	// Update is called once per frame
	void Update () {

        var currettime = 0.0;
        currettime = Time.timeSinceLevelLoad;

        if (Time.timeSinceLevelLoad>2)
            img.GetComponent<Image>().sprite = im2;

        if (Time.timeSinceLevelLoad > 4)
        {
            img.GetComponent<Image>().sprite = im3;

        }
        if (Time.timeSinceLevelLoad >6)
        {
            player.GetComponent<Drive2>().enabled = true;
            img.GetComponent<Image>().sprite = go;

        }
        if(Time.timeSinceLevelLoad >7) img.SetActive(false);

    }
}
