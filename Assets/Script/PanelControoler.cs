using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelControoler : Cursor_Inherit
{    int text_array_index;
    MessageController message;
    [Multiline] [SerializeField] protected string[] text_array;

    private void Start()
    {
        message = new GameObject("").AddComponent<MessageController>();
    }

     override protected void SelectEnter()
    {
        sound.SoundEffect(Sound.Sounds.comand);
        //はい
        if (ArrayIndex == 0)
        {
            text_array_index++;
            message.ChoicePanelClose();
        }
        //いいえ
        else if (ArrayIndex == 1)
        {
            StartCoroutine(message.TalkMode(text_array[text_array_index], false));
        }
    }
}
