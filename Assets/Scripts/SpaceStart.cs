﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceStart : MonoBehaviour {
    [SerializeField]
    GameObject Button;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Space))
        {
            Button.GetComponent<ButtonStart>().OnClick();
 //           SceneManager.LoadScene("Main");
        }
	}

}


