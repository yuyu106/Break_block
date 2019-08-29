using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSE : MonoBehaviour

{
    [SerializeField]
    private AudioSource ballSE;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        ballSE.Play();
    }
}
