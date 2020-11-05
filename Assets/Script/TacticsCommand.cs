using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>押したら取り合えず、たたかうコマンドに移動</summary>
public class TacticsCommand : Cursor_Inherit
{
    [SerializeField] GameObject MovePanel;
    protected override void SelectEnter()
    {
        BattleObj battleobj = BattleObj.Ins();
        battleobj.BattlePanel.SetActive(false);
        MovePanel.SetActive(true);
    }
}
