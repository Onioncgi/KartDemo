using UnityEngine;
using System.Collections;

public class Drive2 : MonoBehaviour {


    public float turnSpeed = 1000f;
    public float accellerateSpeed = 1000f;
    public Rigidbody rbody;
    // Use this for initialization


    void Start () {
        rbody = GetComponent < Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal")*turnSpeed;
        float v = Input.GetAxis("Vertical")* accellerateSpeed;


       // h *= Time.deltaTime;
        //v *= Time.deltaTime;

        //transform.Translate(0, 0, v);
        //transform.Rotate(0, h, 0);
            
          rbody.AddTorque(0f, h * turnSpeed*Time.deltaTime, 0f);
          rbody.AddForce(transform.forward * v * accellerateSpeed*Time.deltaTime);

    }
}
