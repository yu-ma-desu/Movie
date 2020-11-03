using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackController : MonoBehaviour
{
    [SerializeField] GameObject[] BackImage;
    public float speed = 0.01f;  //透明化の速さ

    void Start()
    {
        BackImage[0].GetComponent<Image>();
    }

    void Update()
    {

    }
}