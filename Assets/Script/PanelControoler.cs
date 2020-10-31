using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelControoler : MonoBehaviour
{
    [SerializeField] GameObject[] SelectText;
    [Multiline][SerializeField] string[] text_array;
    int ArrayIndex;
    bool isEnter;



    string s;
    MessageController message;


    private void Start()
    {
        message = new GameObject("").AddComponent<MessageController>();
    }
    void Update()
    {
        if (!isEnter)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                ArrayIndex++;
                PanelArrayIndex();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                ArrayIndex--;
                PanelArrayIndex();
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SelectEnter();
        }
    }

    void PanelArrayIndex()
    {
        Debug.Log(ArrayIndex);
        if (ArrayIndex > SelectText.Length - 1)
        {
            ArrayIndex = 0;
        }
        else if (ArrayIndex < 0)
        {
            ArrayIndex = 1;
        }

        for (int i = 0; i < SelectText.Length; i++)
        {
            if (i == ArrayIndex)
            {
                SelectText[i].SetActive(true);
            }
            else
            {
                SelectText[i].SetActive(false);
            }
        }
    }

    void SelectEnter()
    {
        isEnter = true;
        //はい
        if (ArrayIndex == 0)
        {
            s = text_array[0];
        }
        //いいえ
        else if (ArrayIndex == 1)
        {
            s = text_array[1];
            isEnter = false;
        }
        StartCoroutine(message.TalkMode( s,  false));
    }
}
