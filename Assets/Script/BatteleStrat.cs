using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>バトル関係のオブジェクトのデータ</summary>
public class BattleObj
{
    static public BattleObj GetBattle;

    public static BattleObj Ins()
    {
        if (GetBattle == null)
        {
            GetBattle = new BattleObj();
        }
        return GetBattle;
    }

    public GameObject BattlePanel { get; set; }

}

public class BatteleStrat : MonoBehaviour
{
    [SerializeField] GameObject BatteleCommand;

    private void Awake()
    {
        var battleObj = BattleObj.Ins();

        battleObj.BattlePanel = BatteleCommand;
    }
}
