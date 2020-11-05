using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageController : MonoBehaviour
{
    Text text;                //テキストボックス
    int text_array_index;     //配列の要素数
    static public bool isClose;

    TalkStaitas talk = TalkStaitas.Ins();
    Sound sound = Sound.Ins();

    /// <summary>メッセ―ジコントローラーの最初の処理をするところ</summary>
    public void MassageStart()
    {
        talk.MessageObj.SetActive(true);
        
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
   
    /// <summary>一文字だけ出す処理</summary>
    /// <param name="_text">一文字出す文章</param>
    /// <param name="isStory">メインにかかわっているか</param>
    /// <returns>秒間</returns>
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
