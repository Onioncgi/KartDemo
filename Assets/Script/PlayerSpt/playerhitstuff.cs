using UnityEngine;
using System.Collections;

public class playerhitstuff : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "luck")
        {
            Destroy(col.gameObject);
        }

        if (col.gameObject.name == "luckset")
        {
            Destroy(col.gameObject);
        }
        if (col.gameObject.name == "luck(3)")
        {
            Destroy(col.gameObject);
        }
        if (col.gameObject.name == "luck(4)")
        {
            Destroy(col.gameObject);
        }
        if (col.gameObject.name == "luck(5)")
        {
            Destroy(col.gameObject);
        }
        if (col.gameObject.name == "luck(6)")
        {
            Destroy(col.gameObject);
        }
        if (col.gameObject.name == "luck(7)")
        {
            Destroy(col.gameObject);
        }
        if (col.gameObject.name == "luck(8)")
        {
            Destroy(col.gameObject);
        }
        if (col.gameObject.name == "luck(9)")
        {
            Destroy(col.gameObject);
        }
        if (col.gameObject.name == "luck(10)")
        {
            Destroy(col.gameObject);
        }
        if (col.gameObject.name == "luck(11)")
        {
            Destroy(col.gameObject);
        }
        if (col.gameObject.name == "luck(12)")
        {
            Destroy(col.gameObject);
        }
    }
}
