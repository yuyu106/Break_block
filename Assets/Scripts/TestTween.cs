using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class TestTween : MonoBehaviour
{
    [SerializeField]
    private RectTransform rectTran;

    // Start is called before the first frame update
    void Start()
    {
        rectTran.DOPunchScale( new Vector3(1.5f, 1.5f), 10.0f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
