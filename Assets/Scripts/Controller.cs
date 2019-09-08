using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    [SerializeField]
    private GameObject master;
    [SerializeField]
    private GameObject righitWall;
    [SerializeField]
    private GameObject leftWall;

//    private float rightSpeed;
//   private float leftSpeed;

    public float speed;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Left Key  " + speed);
            transform.position += transform.forward * speed;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position -= transform.forward * speed;
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("当たった");
        Debug.Log(collision.gameObject.name);

        master.GetComponent<BallSE>().PlaySE(SE.WOOD);

    }

}
