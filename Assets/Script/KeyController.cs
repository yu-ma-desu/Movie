using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>キーボード処理</summary>
public class KeyController : MonoBehaviour
{
    /// <summary>画面を切り替える数字</summary>
    [SerializeField] int EventChange;

    TalkStaitas talk = TalkStaitas.Ins();

    /// <summary>現在のテキスト番号</summary>
    int num;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            WindowChange();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            BackController.Anim();
        }
    }

    /// <summary>ボタンを押したら切り替える所を参照</summary>
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
