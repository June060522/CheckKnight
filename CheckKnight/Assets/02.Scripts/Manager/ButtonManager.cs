using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] GameObject StagePanel;
    [SerializeField] GameObject OptionPanel;
    [SerializeField] GameObject StageInfo;
    public void ClickScreen()
    {
        if (OptionPanel.activeSelf == false && StageInfo.activeSelf == false)
            StagePanel.SetActive(true);
    }

    public void ClickOption()
    {

        if (StagePanel.activeSelf == false && StageInfo.activeSelf == false)
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

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            StagePanel.SetActive(false);
            OptionPanel.SetActive(false);
            for(int i = 0; i < StageInfo.transform.childCount; i++)
            {
                StageInfo.transform.GetChild(i).gameObject.SetActive(false);
            }
            StageInfo.SetActive(false);
        }
    }

    public void StageBtnClick(GameObject obj)
    {
        StageInfo.SetActive(true);
        StagePanel.SetActive(false);
        obj.SetActive(true);
    }
}