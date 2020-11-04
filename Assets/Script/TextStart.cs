using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkStaitas
{
    //文字列の順番
    int use_talk_num = 0;

    static TalkStaitas GetTalk;

    public static TalkStaitas Ins()
    {
        if (GetTalk == null)
        {
            GetTalk = new TalkStaitas();
        }
        return GetTalk;
    }

    /// <summary>現在のTalk配列の要素数</summary>
    /// <returns>Talk配列の要素数</returns>
    public int GetMessageIndex() => use_talk_num;

    /// <summary>次のTalk配列の要素数を出す処理</summary>
    public void GetNextMessageIndex()
    {
        use_talk_num++;
        TextStart.GetNextText(use_talk_num);
    }

    public float TextSpeed { get; set; }

    public int TextLength { get; set; }

    public string Text { get; set; }

    public Text GetText { get; set; }

    public GameObject GetPanel { get; set; }

    public GameObject MessageObj { get; set; }

    public int PanelOpenNum { get; set; }
}

class TextStart:MonoBehaviour
{
    [Header("テキスト関係")]
    [SerializeField] GameObject messageObj;
    [SerializeField] float TextSpeed;
    [Multiline] [SerializeField] string[] Talk;
    [SerializeField] Text text;
    static string[] privete_Talk;

    [Header("はい、いいえ")]
    [SerializeField] GameObject SelectPanel;
    [SerializeField] int[] PanelNum;
    static int[] private_num;
    static int panel_index;

    private void Awake()
    {
        var talk = TalkStaitas.Ins();

        talk.TextSpeed = TextSpeed;
        talk.Text = Talk[talk.GetMessageIndex()];
        talk.GetText = text;
        talk.TextLength = Talk.Length;
        privete_Talk = Talk;

        private_num = PanelNum;

        talk.GetPanel = SelectPanel;
        talk.PanelOpenNum = private_num[panel_index];

        talk.MessageObj = messageObj;
    }

    static public void GetNextText(int use_talk_index)
    {
        var talk = TalkStaitas.Ins();
        if (use_talk_index < privete_Talk.Length)
        {
            talk.Text = privete_Talk[use_talk_index];
        }
    }

    static public void NextPanelOpenNum()
    {
        panel_index++;
        var talk = TalkStaitas.Ins();
        if (panel_index < private_num.Length)
        {
            talk.PanelOpenNum = private_num[panel_index];
        }
    }
}
