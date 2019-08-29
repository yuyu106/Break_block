using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallOrbit : MonoBehaviour {

    [SerializeField]
    private GameObject ball;
 

	// Use this for initialization
	void Start () {
   //     transform.eulerAngles = new Vector3(0, Random.Range(30, 120), 0);
        transform.eulerAngles = new Vector3(0, 90, 0);
        ball.GetComponent<Rigidbody>().AddForce(transform.forward * 500);
	}
	
	// Update is called once per frame
	void Update () {
        if(Mathf.Abs(ball.GetComponent<Rigidbody>().velocity.x) < 1)
        {
            ball.transform.GetComponent<Rigidbody>().velocity += new Vector3(1f,0,0);
        }
        if (Mathf.Abs(ball.GetComponent<Rigidbody>().velocity.z) < 1)
        {
            ball.transform.GetComponent<Rigidbody>().velocity += new Vector3(0, 0, 1f);
        }


    }
}
