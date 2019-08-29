using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    double yuka = 10/2 - 0.1;
    double player = 1.3/2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 tmp = transform.position;
        float z = tmp.z;

		if (Input.GetKey(KeyCode.LeftArrow) && z <= yuka - player)
        {
            transform.position += transform.forward * 0.1f;
        }
        else if (Input.GetKey(KeyCode.RightArrow) && z >= -yuka + player)
        {
            transform.position -= transform.forward * 0.1f;
        }
	}
}
