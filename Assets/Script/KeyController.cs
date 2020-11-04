using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    [SerializeField] int EventChange;
    TalkStaitas talk = TalkStaitas.Ins();
    int num;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            WindowChange();
        }
    }

    void WindowChange()
    {
        num = talk.GetMessageIndex();
        if (EventChange > num)
        {
            EventManeger.WindowChoice(EventManeger.Windows.MessageWindow);
        }
        else
        {
            EventManeger.WindowChoice(EventManeger.Windows.CommandWindow);
        }

    }
}
