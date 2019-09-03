using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSE : MonoBehaviour

{
    [SerializeField]
    private GameObject mastar;
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
        mastar.GetComponent<BallSE>().PlaySE(SE.WOOD);
    }
}
