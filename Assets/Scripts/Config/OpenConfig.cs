using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class OpenConfig : MonoBehaviour
{
    [SerializeField]
    private GameObject config;

    [SerializeField]
    private GameObject[] cutlery;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //ボタン押したら設定画面が開くor閉じる
    public void OnClick()
    {
        if(config.activeSelf == true)
        {
            config.transform.DOLocalMove(
                new Vector3(0f, -650f, 0f),
                0.5f
                )
                .OnComplete(() => config.SetActive(false));

            cutlery[0].SetActive(true);
            cutlery[1].SetActive(true);
            cutlery[2].SetActive(false);
            cutlery[3].SetActive(false);
        }
        else
        {
            config.transform.localPosition = new Vector3(0f, -20f, 0f);
            config.transform.localScale = new Vector3(0f, 0f, 0f);
            config.SetActive(true);
            config.transform.DOScale(
                Vector3.one,
                0.5f
                );

            cutlery[0].SetActive(false);
            cutlery[1].SetActive(false);
            cutlery[2].SetActive(true);
            cutlery[3].SetActive(true);
        }
    }
}
