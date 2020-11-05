using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>バトルコマンドを回す</summary>
public class CommandController : MonoBehaviour
{
    static CommandController GetCommand;
    bool isClose;

    static public CommandController Ins()
    {
        if (GetCommand == null)
        {
            GetCommand = new CommandController();
        }
        return GetCommand;
    }

    public void CommandStart()
    {
        if (!isClose)
        {
            BattleTemplate();
            isClose = true;
        }
    }

    public void BattleTemplate()
    {
        Tactics();
        PlayerMove();
        SkillCommand();
        End();
    }

    void Tactics()
    {
        var talk = TalkStaitas.Ins();
        var battleobj = BattleObj.Ins();
        battleobj.BattlePanel.SetActive(true);
        talk.MessageObj.SetActive(false);
    }

    void PlayerMove()
    {

    }

    void SkillCommand()
    {

    }

    void End()
    {
        isClose = true;
    }
}