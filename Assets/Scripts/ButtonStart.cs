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


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        greenPepper.DOLocalJump(
            Vector3.one,
            50,
            1,
            1.0f
        );

        buttonSE.Play();
        Invoke("loadScene", 1.0f);



    }
    private void loadScene()
    {
         SceneManager.LoadScene("Main");
    }

    public void OnPointerEnter()
    {
            Debug.Log("Mouse is over GameObject.");
    }

    public void  OnPointerExsit()
    {
            Debug.Log("Mouse is no longer on GameObject.");
    }

}
