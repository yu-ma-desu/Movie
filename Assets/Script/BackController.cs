using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>背景関係</summary>
public class BackController : MonoBehaviour
{
    static TalkStaitas talk = TalkStaitas.Ins();
    static int i;
    public static void Anim()
    {
        talk.BackArray[i].SetActive(true);
        i++;
    }
}