using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>アニメーション関係</summary>
public class Anim : MonoBehaviour
{
    Animation animation;
    bool isStop;

    private void Start()
    {
        animation = GetComponent<Animation>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            AnimPouse();
        }
    }

    void AnimPouse()
    {
        if (!isStop)
        {
            animation.Stop();
            isStop = true;
        }
        else
        {
            animation.Play();
            isStop = false;
        }
    }

    void CloseBack()
    {
        BackController.Anim();
    }
}
