using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Fruites : MonoBehaviour {

    public GameObject masterObj;
    
    public GameObject scoreBoard;

    [SerializeField]
    private RectTransform rectTransform;

    public string fruiteName;
    public  int score;
    public collisionAction collisionAction;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {

       scoreBoard.GetComponent<Score>().scoreBoard(score);
       
        switch (collisionAction)
        {
            case collisionAction.DESTROY:
                Debug.Log("消します");
                Destroy(gameObject);
                masterObj.GetComponent<GameMaster>().boxNum--;
                break;

            case collisionAction.Freeze:
                
                break;
            
        }
       
    }
}

