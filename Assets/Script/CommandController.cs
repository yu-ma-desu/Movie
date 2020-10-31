using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandController : MonoBehaviour
{
    void Start()
    {
        var yangas = Yangas.Ins();
        var eight = Eight.Ins();

        Debug.Log(eight.Name);
        Debug.Log(eight.HP);
        Debug.Log(eight.MP);

        Debug.Log(yangas.Name);
        Debug.Log(yangas.HP);
        Debug.Log(yangas.MP);
    }

    public void CommandStart()
    {

    }
}