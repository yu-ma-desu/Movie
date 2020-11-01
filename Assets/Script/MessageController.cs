using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageController : MonoBehaviour
{
    Text text;                //テキストボックス
    int text_array_index;     //配列の要素数
    bool isClose;

    TalkStaitas talk = TalkStaitas.Ins();
    Sound sound = new Sound();


    public void MassageStart()
     {
        text_array_index = talk.GetMessageIndex();
        if (text_array_index == talk.PanelOpenNum)
        {
            ChoicePanelOpen();
        }
        else if (text_array_index < talk.TextLength &&  !isClose)
        {
            StartCoroutine(TalkMode(talk.Text, true));
        }

    }

    public IEnumerator TalkMode(string _text, bool isStory)
    {
        isClose = true;
        text = talk.GetText;
        int talkCount = 0;
        text.text = "";

        while (_text.Length > talkCount)
        {
            //効果音
            sound.SoundEffect(Sound.Sounds.novel);

            //文字送り
            text.text += _text[talkCount];
            talkCount++;
            yield return new WaitForSeconds(talk.TextSpeed);
        }

        if (isStory) talk.GetNextMessageIndex();
        isClose = false;
    }

    /// <summary>2択パネルを表示</summary>
    public void ChoicePanelOpen() => talk.GetPanel.SetActive(true);

    /// <summary>2択パネルを非表示</summary>
    public void ChoicePanelClose()
    {
        TextStart.NextPanelOpenNum();
        talk.GetPanel.SetActive(false);
        StartCoroutine(TalkMode(talk.Text, true));
    }
}
