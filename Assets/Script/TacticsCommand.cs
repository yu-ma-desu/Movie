using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
