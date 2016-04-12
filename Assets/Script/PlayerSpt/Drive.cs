using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Drive : MonoBehaviour {

    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        ////if this your payer object
        float translation = CrossPlatformInputManager.GetAxis("Vertical");
        float rotation = CrossPlatformInputManager.GetAxis("Horizontal") ;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);	
	}
}
