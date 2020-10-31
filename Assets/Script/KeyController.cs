using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    TalkStaitas talk = TalkStaitas.Ins();

    int num;

    private void Awake()
    {
        num = talk.GetMessageIndex();
    }

    void Update()
    {
        if (num == 1)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                EventManeger.WindowChoice(EventManeger.Windows.MessageWindow, EventManeger.Key.UpArrow);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                EventManeger.WindowChoice(EventManeger.Windows.MessageWindow, EventManeger.Key.DownArrow);
            }

        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                EventManeger.WindowChoice(EventManeger.Windows.MessageWindow, EventManeger.Key.Space);
            }
        }
    }
}
