using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxInit : MonoBehaviour {

    [SerializeField]
    private GameObject[] boxObjPrefab;
    [SerializeField]
    private GameObject boxesObj;
    [SerializeField]
    private Material[] materials;
    [SerializeField]
    private int[] score;
    [SerializeField]
    private string[] fruiteName;
    [SerializeField]
    private collisionAction[] collisionAction;
    [SerializeField]
    private int type;
    [SerializeField]
    private GameObject scoreBoard;

    [SerializeField]
    private GameObject masterObject;

    void Awake()
    {

        GameObject masterObj = GameObject.Find("Master");

        //得点分け乱数
        int scoreRandom;
        var random = new System.Random();

        //フルーツの数数える
        int[] countFruites = new int[type];

        for (int x = 0; x < 8; x++)
        {
            for(int y = 0; y < 5; y++)
            {

                scoreRandom = random.Next(type);

                //フルーツがいっぱいいっぱい
                
                while(masterObject.GetComponent<GameMaster>().fruitesNum[scoreRandom] <= countFruites[scoreRandom])
                {
                    scoreRandom =random.Next(type);
                }
                

                countFruites[scoreRandom]++;
                

                GameObject g = Instantiate(boxObjPrefab[scoreRandom], boxesObj.transform);

                g.transform.position = new Vector3((2f + (1f * y)), 0.4f, (-4.2f + (1.2f * x)));
                if(fruiteName[scoreRandom] == "GreenPepper")
                {
                    g.transform.position = new Vector3((2f + (1f * y) - 0.25f), 0.4f, (-4.2f + (1.2f * x)));
                }
           

                g.GetComponent<Fruits>().fruiteName = fruiteName[scoreRandom];
                g.GetComponent<Fruits>().score = score[scoreRandom];
                g.GetComponent<Fruits>().collisionAction = collisionAction[scoreRandom];

                g.GetComponent<Fruits>().masterObj = masterObj;
                g.GetComponent<Fruits>().scoreBoard = scoreBoard;

                masterObj.GetComponent<GameMaster>().uniqueNum[10 * y + x] = g;
                g.GetComponent<Fruits>().uniqueNumX = x;
                g.GetComponent<Fruits>().uniqueNumY = y;


 //               g.GetComponent<Renderer>().material = materials[scoreRandom];
                
            }
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
