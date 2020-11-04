using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        var talk = TalkStaitas.Ins();
        var battleobj = BattleObj.Ins();

        if (!isClose)
        {
            BattleTemplate();
            isClose = false;
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