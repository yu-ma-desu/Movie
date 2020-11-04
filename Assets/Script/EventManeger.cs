using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

/// <summary>ウィンドウコントローラー選択</summary>
public class EventManeger
{
    static readonly MessageController message = new GameObject("").AddComponent<MessageController>();
    static readonly CommandController command = new CommandController();

    //ウィンドウの名称
    public enum Windows
    {
        MessageWindow,
        CommandWindow,
    }

    //ウィンドウコントローラーを選択
    public static void WindowChoice(Windows windows)
    {
        switch (windows)
        {
            case Windows.MessageWindow:
                message.MassageStart();
                break;
            case Windows.CommandWindow:
                command.CommandStart();
                break;
            default:
                break;
        }
    }
}