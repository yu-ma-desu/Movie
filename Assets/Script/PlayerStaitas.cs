using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;
using UnityEngine.Assertions.Must;

class Charactor
{
    private int hp = 0;
    private int mp = 0;

    public string Name { get; set; }
    public int HP
    {
        get { return hp; }
        set { hp += value; }
    }
    public int MP
    {
        get { return mp; }
        set { mp += value; }
    }
}

/// <summary>エイトステータス</summary>
class Eight : Charactor
{
    private static Eight GetEight;

    public static Eight Ins()
    {
        if (GetEight == null)
        {
            GetEight = new Eight();
        }
        return GetEight;
    }
}

/// <summary>ヤンガスステータス</summary>
class Yangas : Charactor
{
    private static Yangas GetYangas;

    public static Yangas Ins()
    {
        if (GetYangas == null)
        {
            GetYangas = new Yangas();
        }
        return GetYangas;
    }
}

/// <summary>初期ステータス関係</summary>
public class PlayerStaitas : MonoBehaviour
{
    [Header("エイトステータス")]
    [SerializeField] string NameEight = "";
    [SerializeField] int HpEight = 0;
    [SerializeField] int MpEight = 0;

    [Header("ヤンガスステータス")]
    [SerializeField] string NameYanges = "";
    [SerializeField] int HpYangas = 0;
    [SerializeField] int MpYangas = 0;

    //ステータスを代入する
    private void Awake()
    {
        var eight = Eight.Ins();
        var yangas = Yangas.Ins();

        eight.Name = NameEight;
        eight.HP = HpEight;
        eight.MP = MpEight;

        yangas.Name = NameYanges;
        yangas.HP = HpYangas;
        yangas.MP = MpYangas;
    }
}