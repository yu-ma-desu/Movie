using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    //音種類
    public enum Sounds
    {
        attack,
        comand,
        level,
        novel
    }

    [Header("効果音")]
    [SerializeField] static AudioClip Attack;
    [SerializeField] static AudioClip Comand;
    [SerializeField] static AudioClip Level;
    [SerializeField] static AudioClip Novel;

    [SerializeField] public static AudioSource Audio;

    private void Start()
    {
        Novel = Resources.Load<AudioClip>("button40");
        Comand = Resources.Load<AudioClip>("button37");
        Audio = GetComponent<AudioSource>();
    }

    /// <summary>音楽再生</summary>
    /// <param name="sounds">効果音 enum</param>
    public void SoundEffect(Sounds sounds)
    {
        switch (sounds)
        {
            case Sounds.attack:
                Audio.PlayOneShot(Attack);
                break;
            case Sounds.comand:
                Audio.PlayOneShot(Comand);
                break;
            case Sounds.level:
                Audio.PlayOneShot(Level);
                break;
            case Sounds.novel:
                Audio.PlayOneShot(Novel);
                break;
            default:
                break;
        }
    }
}