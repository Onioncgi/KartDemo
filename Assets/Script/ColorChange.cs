using UnityEngine;
using System.Collections;

public class ColorChange : MonoBehaviour {

    public GameObject player;
    

	// Use this for initialization
	void Start () {
        
    }
	
	public void redcolor()
    {
        player.GetComponent<Renderer>().material.color = new Color(0f, 1, 0f);
    }
    public void bluecolr()
    {
        player.GetComponent<Renderer>().material.color = new Color(0f, 0f, 1);
    }

    public void greencolor()
    {
        player.GetComponent<Renderer>().material.color = new Color(1.0f, 0f, 0f);
    }
    public void orangecolor()
    {
        player.GetComponent<Renderer>().material.color = new Color(0f, 1, 1);
    }
}
