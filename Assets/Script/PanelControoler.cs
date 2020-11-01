using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelControoler : MonoBehaviour
{
    [SerializeField] GameObject[] SelectText;
    [Multiline][SerializeField] string[] text_array;
    int ArrayIndex;
    int text_array_index;
    bool isEnter;

    MessageController message;
    Sound sound = new Sound();


    private void Start()
    {
        message = new GameObject("").AddComponent<MessageController>();
    }
    void Update()
    {
        if (!isEnter)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                ArrayIndex++;
                PanelArrayIndex();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                ArrayIndex--;
                PanelArrayIndex();
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SelectEnter();
        }
    }

    void PanelArrayIndex()
    {
        if (ArrayIndex > SelectText.Length - 1)
        {
            ArrayIndex = 0;
        }
        else if (ArrayIndex < 0)
        {
            ArrayIndex = 1;
        }

        for (int i = 0; i < SelectText.Length; i++)
        {
            if (i == ArrayIndex)
            {
                SelectText[i].SetActive(true);
            }
            else
            {
                SelectText[i].SetActive(false);
            }
        }
        sound.SoundEffect(Sound.Sounds.comand);
    }

    void SelectEnter()
    {
        isEnter = true;
        sound.SoundEffect(Sound.Sounds.comand);
        //はい
        if (ArrayIndex == 0)
        {
            text_array_index++;
            message.ChoicePanelClose();
        }
        //いいえ
        else if (ArrayIndex == 1)
        {
            isEnter = false;
            StartCoroutine(message.TalkMode(text_array[text_array_index], false));
        }
        isEnter = false;
    }
}
