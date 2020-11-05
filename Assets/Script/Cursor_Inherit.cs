using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

/// <summary>コマンドカーソルの継承元</summary>
abstract public class Cursor_Inherit : MonoBehaviour
{
    [Header("選択カーソル関係")]
    /// <summary>テキスト横のアイコン</summary>
    [SerializeField] GameObject[] SelectIcon;

    //表記するSelectIconの配列の要素数
    protected int ArrayIndex;

    [Header("二行以上あるか確認")]
    [SerializeField] bool isTwoArray;

    protected Sound sound = Sound.Ins();

    void Update()
    {
        if (!MessageController.isClose)
        {
            if (!isTwoArray)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    ArrayIndex--;
                    CommandArrayIndex();
                }
                else if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    ArrayIndex++;
                    CommandArrayIndex();
                }
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    SelectEnter();
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    ArrayIndex -= 2;
                    CommandArrayIndex();
                }
                else if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    ArrayIndex += 2;
                    CommandArrayIndex();
                }
                else if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    ArrayIndex--;
                    CommandArrayIndex();
                }
                else if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    ArrayIndex++;
                    CommandArrayIndex();
                }
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    SelectEnter();
                }
            }
        }
    }
    /// <summary>カーソルの移動処理</summary>
    void CommandArrayIndex()
    {
        if (!isTwoArray)
        {

            if (ArrayIndex > SelectIcon.Length - 1)
            {
                ArrayIndex = 0;
            }
            else if (ArrayIndex < 0)
            {
                ArrayIndex = SelectIcon.Length - 1;
            }

            for (int i = 0; i < SelectIcon.Length; i++)
            {
                if (i == ArrayIndex)
                {
                    SelectIcon[i].SetActive(true);
                }
                else
                {
                    SelectIcon[i].SetActive(false);
                }
            }
        }
        else
        {
            if (ArrayIndex > SelectIcon.Length - 1)
            {
                ArrayIndex -= SelectIcon.Length;
            }
            else if (ArrayIndex < 0)
            {
                ArrayIndex += SelectIcon.Length;
            }
            for (int i = 0; i < SelectIcon.Length; i++)
            {
                if (i == ArrayIndex)
                {
                    SelectIcon[i].SetActive(true);
                }
                else
                {
                    SelectIcon[i].SetActive(false);
                }
            }
        }
        sound.SoundEffect(Sound.Sounds.comand);
    }
    /// <summary>決定した時の処理　抽象化</summary>
    abstract protected void SelectEnter();
}
