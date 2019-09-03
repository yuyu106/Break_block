using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Score : MonoBehaviour
{

    [SerializeField]
    private GameObject master;
    [SerializeField]
    private Text scoreText;
    [SerializeField]
    private RectTransform rectTransform;


    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = master.GetComponent<GameMaster>().score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void scoreBoard(int score)
    {

        int scoreTimes = master.GetComponent<GameMaster>().score / 1000;
        Debug.Log("スコアボード呼んだ");
        master.GetComponent<GameMaster>().score += score;

        rectTransform.DOKill();
        rectTransform.localScale = Vector3.one;
        rectTransform.DOPunchScale
        (
            new Vector3(1.0f, 1.0f, 1.0f),
            0.2f
        );

        scoreText.text = master.GetComponent<GameMaster>().score.ToString();
        

    }
}
