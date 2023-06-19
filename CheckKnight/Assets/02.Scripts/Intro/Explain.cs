using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Explain : MonoBehaviour
{
    int index = 0;
    [SerializeField] GameObject rightBtn;
    [SerializeField] GameObject leftBtn;
    [SerializeField] [TextArea] string[] explainTxt;
    [SerializeField] TextMeshProUGUI tmpro;
    [SerializeField] AudioClip btnClick;

    private void OnEnable()
    {
        index = 0;
        Page();
    }

    private void Update()
    {
        if (index == 0)
            leftBtn.SetActive(false);
        else
            leftBtn.SetActive(true);

        if(index == explainTxt.Length - 1)
            rightBtn.SetActive(false);
        else
            rightBtn.SetActive(true);
    }

    public void Left()
    {
        EffectAudio.Instance.ListenEff(btnClick);
        index--;
        Page();
    }

    public void Right()
    {
        EffectAudio.Instance.ListenEff(btnClick);
        index++;
        Page();
    }

    public void Page()
    {
        tmpro.text = explainTxt[index];
    }
}
