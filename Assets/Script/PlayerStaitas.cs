using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;
using UnityEngine.Assertions.Must;

/// <summary>キャラクター継承元</summary>
class Charactor
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int MP { get; set; }
    public int LV { get; set; }
    /// <summary>特技関係</summary>
    public string[] Skill { get; set; }
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
    [SerializeField] int LvEight = 0;
    [SerializeField] string[] SkillEight = null;

    [Header("ヤンガスステータス")]
    [SerializeField] string NameYanges = "";
    [SerializeField] int HpYangas = 0;
    [SerializeField] int MpYangas = 0;
    [SerializeField] int LvYangas = 0;
    [SerializeField] string[] SkillYangas = null;

    //ステータスを代入する
    private void Awake()
    {
        var eight = Eight.Ins();
        var yangas = Yangas.Ins();

        eight.Name = NameEight;
        eight.HP = HpEight;
        eight.MP = MpEight;
        eight.Skill = SkillEight;
        eight.LV = LvEight;

        yangas.Name = NameYanges;
        yangas.HP = HpYangas;
        yangas.MP = MpYangas;
        yangas.LV = LvYangas;
        yangas.Skill = SkillYangas;
    }
}