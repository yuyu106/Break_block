using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingButton : MonoBehaviour
{

    [SerializeField]
    private configurable configurable;

    [SerializeField]
    private int plus;

    [SerializeField]
    private GameObject configData;

    [SerializeField]
    private Text text;

    // Start is called before the first frame update
    void Start()
    {
        if(plus > 0)
        {
            text.text = configData.GetComponent<ConfigData>().getText(configurable);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        configData.GetComponent<ConfigData>().setNum(configurable, plus);
        text.text = configData.GetComponent<ConfigData>().getText(configurable);

    }
}
