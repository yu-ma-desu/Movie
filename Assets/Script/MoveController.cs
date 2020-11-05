using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

/// <summary>たたかうを押した後の処理</summary>
public class MoveController : Cursor_Inherit
{
    [SerializeField] GameObject SkillPanel;
    [SerializeField] GameObject MessagePanel;
    override protected void SelectEnter()
    {
        switch (ArrayIndex)
        {
            case 0:
                MessagePanel.SetActive(true);
                break;
            case 1:
                SkillPanel.SetActive(true);
                break;
            case 2:
                SkillPanel.SetActive(true);
                break;
            case 3:
                SkillPanel.SetActive(true);
                break;
            case 4:
                MessagePanel.SetActive(true);
                break;
            case 5:
                MessagePanel.SetActive(true);
                break;
            default:
                break;
        }
    }
}
