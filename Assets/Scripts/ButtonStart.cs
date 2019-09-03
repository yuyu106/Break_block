using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;

public class ButtonStart : MonoBehaviour
{
    [SerializeField]
    private AudioSource buttonSE;
    [SerializeField]
    private RectTransform greenPepper;
    [SerializeField]
    private GameObject[] gameObjects;


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
        cutleryOpen();

        greenPepper.DOLocalJump(
            Vector3.one,
            40,
            1,
            0.8f
        );

        buttonSE.Play();

        Invoke("cutleryClose", 0.6f);
        Invoke("loadScene", 0.8f);



    }
    private void loadScene()
    {
         SceneManager.LoadScene("Main");
    }

    public void OnPointerEnter()
    {
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
