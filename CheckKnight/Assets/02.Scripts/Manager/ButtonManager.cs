using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] GameObject StagePanel;
    [SerializeField] GameObject OptionPanel;
    public void ClickScreen()
    {
        if (OptionPanel.activeSelf == false)
            StagePanel.SetActive(true);
    }

    public void ClickOption()
    {

        if (StagePanel.activeSelf == false)
            OptionPanel.SetActive(true);
    }

    public void CloseOption()
    {
        OptionPanel.SetActive(false);
    }

    public void CloseStage()
    {
        StagePanel.SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}