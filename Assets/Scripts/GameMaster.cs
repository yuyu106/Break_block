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
            GameOver("Game Over", "また挑戦してね！", resultStatus.GameOver);
        }

        if(boxNum <= 0 || score >= MaxScore)
        {
            GameOver("Game Clear"," " + nowTime.ToString("F0") + "秒でクリア！",resultStatus.GameClear );
        }


        //華ちゃん用
        if (Input.GetKey(KeyCode.Space))
        {
            player.transform.localScale = new Vector3(1f, 1f, 5f);
        }
    }

    public void GameOver(string result, string resultMessage, resultStatus resultStatus)
    {
        DataSender.result = result;
        DataSender.resultMessage = resultMessage;
        DataSender.score = score;
        DataSender.resultStatus = resultStatus;
        SceneManager.LoadScene("Result");
    }
}
