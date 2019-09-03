using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class GameMaster : MonoBehaviour {

    public int boxNum;
    public float nowTime;
    public int score;
    public float TimeLimit;


    [SerializeField]
    private Text timeText;
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private int MaxScore;

    public int[] fruitesNum;

    public GameObject[] uniqueNum = new GameObject[60];

	// Use this for initialization
	void Start () {
        nowTime = 0;
	}
	
	// Update is called once per frame
	void Update () {
        nowTime += Time.deltaTime;
        TimeLimit -= Time.deltaTime;
        string minuteLimit = ((int)TimeLimit / 60).ToString();
        string secondLimit = ((int)TimeLimit % 60).ToString();

        if (minuteLimit.Length < 2) minuteLimit = "0" + minuteLimit;
        if (secondLimit.Length < 2) secondLimit = "0" + secondLimit;


        timeText.text = minuteLimit + ":" + secondLimit;
       

        if(TimeLimit < 0)
        {
            GameOver(resultStatus.GAMEOVER);
        }

        if(boxNum <= 0 || score >= MaxScore)
        {
            GameOver(resultStatus.GAMECLEAR );
        }


        //華ちゃん用
        if (Input.GetKey(KeyCode.Space))
        {
            player.transform.localScale = new Vector3(1f, 1f, 4f);
        }
    }

    public void GameOver(resultStatus result)
    {
        if(result == resultStatus.GAMECLEAR)
        {
            DataSender.result = "Game Clear";
            DataSender.resultMessage = "おめでとう!";
        }
        else
        {
            DataSender.result = "Game Over";
            DataSender.resultMessage = (score >= (MaxScore * 0.8)) ? "もう少し！" : "もっとがんばろう";
        }
        
        
        DataSender.score = score;
        DataSender.resultStatus = result;
        SceneManager.LoadScene("Result");
    }
}
