using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextFetcher : MonoBehaviour {

    public Text resultMessageText;
    public Text result;
    public Text score;

    [SerializeField]
    private AudioSource bgm;

    [SerializeField]
    private AudioClip gameClear;

    [SerializeField]
    private AudioClip gameOver;

	// Use this for initialization
	void Start () {
        result.text = DataSender.result;
        resultMessageText.text = DataSender.resultMessage;
        score.text = DataSender.score.ToString() + "点";

        bgm.clip = (DataSender.resultStatus == resultStatus.GAMEOVER) ? gameOver : gameClear;

        bgm.Play();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("Title");
        }
		
	}
}
