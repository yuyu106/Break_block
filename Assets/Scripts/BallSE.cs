﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSE : MonoBehaviour

{
    [SerializeField]
    private AudioSource[] collisionSE;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySE(SE se)
    {
        collisionSE[(int)se].Play();
    }
}
