using UnityEngine;
using System.Collections;

public class ColorChange : MonoBehaviour {

    private GameObject player;
    

	// Use this for initialization
	void Start () {

        player = this.player.GetComponent<GameObject>();

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("1"))
        {

            player.GetComponent<Renderer>().material.color = new Color(0f, 1, 1);
        }
	}
}
