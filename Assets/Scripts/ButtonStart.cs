using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;
using Data;

public class ButtonStart : MonoBehaviour
{
    [SerializeField]
    private AudioSource buttonSE;
    [SerializeField]
    private RectTransform greenPepper;
    [SerializeField]
    private RectTransform greenPepper2 = null;
    [SerializeField]
    private RectTransform greenPepper3 = null;
    [SerializeField]
    private GameObject[] gameObjects;
    [SerializeField]
    private difficulty difficulty;

    [SerializeField]
    private GameObject config;

    public SelectableData data;

    // Start is called before the first frame update
    void Start()
    {
        gameObjects[2].SetActive(false);
        gameObjects[3].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnClick()
    {

        //データセット
        if(difficulty != difficulty.SET)
        {
            DataSet.Instance.data = SettingDataUtility.GetDifficltySelectableData(difficulty);
        }
        else
        {
            DataSet.Instance.data = config.GetComponent<ConfigData>().getData();
        }


        cutleryOpen();

        greenPepper.DOLocalJump(
            greenPepper.transform.localPosition,
            40,
            1,
            0.8f
        )
        .OnComplete(() => loadScene());

        if(greenPepper2 != null)
        {
            greenPepper2.DOLocalJump(
                greenPepper2.transform.localPosition,
                30,
                1,
                0.6f
            );
        }


        if (greenPepper3 != null)
        {
            greenPepper3.DOLocalJump(
                greenPepper3.transform.localPosition,
                20,
                1,
                0.6f
            );
        }

        buttonSE.Play();

        Invoke("cutleryClose", 0.6f);
//        Invoke("loadScene", 0.8f);



    }
    private void loadScene()
    {
         SceneManager.LoadScene("Main");
    }

    public void OnPointerEnter()
    {
        Debug.Log("触った");
        cutleryOpen();
    }

    public void  OnPointerExsit()
    {
        cutleryClose();
    }

    private void cutleryOpen()
    {
        gameObjects[0].SetActive(false);
        gameObjects[1].SetActive(false);
        gameObjects[2].SetActive(true);
        gameObjects[3].SetActive(true);
    }

    private void cutleryClose()
    {
        gameObjects[0].SetActive(true);
        gameObjects[1].SetActive(true);
        gameObjects[2].SetActive(false);
        gameObjects[3].SetActive(false);
    }

}
