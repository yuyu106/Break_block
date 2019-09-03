using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    double yuka = 10/2 - 0.1;
    double player = 1.3/2;

    [SerializeField]
    private GameObject master;
    [SerializeField]
    private GameObject righitWall;
    [SerializeField]
    private GameObject leftWall;

    private float rightSpeed;
    private float leftSpeed;

	// Use this for initialization
	void Start () {
        rightSpeed = 0.1f;
        leftSpeed = 0.1f;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 tmp = transform.position;
        float z = tmp.z;

		if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += transform.forward * leftSpeed;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position -= transform.forward * rightSpeed;
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("当たった");
        Debug.Log(collision.gameObject.name);

        master.GetComponent<BallSE>().PlaySE(SE.WOOD);

    }

}
