using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using  TMPro;
using UnityEngine.UI;
using DG.Tweening;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] GameObject StagePanel;
    [SerializeField] GameObject OptionPanel;
    [SerializeField] GameObject StageInfo;
    [SerializeField] GameObject ExplainPanel;
    [SerializeField] Image BlackScreen;
    public void ClickScreen()
    {
        if (!OptionPanel.activeSelf && !StageInfo.activeSelf && !ExplainPanel.activeSelf)
            StagePanel.SetActive(true);
    }

    public void ClickOption()
    {

        if (!StagePanel.activeSelf && !StageInfo.activeSelf && !ExplainPanel.activeSelf)
            OptionPanel.SetActive(true);
    }

    public void ClickHelp()
    {
        if(!StagePanel.activeSelf && !StageInfo.activeSelf && !OptionPanel.activeSelf)
            ExplainPanel.SetActive(true);
    }

    public void CloseOption()
    {
        OptionPanel.SetActive(false);
    }

    public void CloseStage()
    {
        StagePanel.SetActive(false);
    }

    public void CloseExplain()
    {
        ExplainPanel.SetActive(false);
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
            ExplainPanel.SetActive(false);
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

    public void GameStart(string SceneName)
    {
        StartCoroutine(SceneChange(SceneName));
    }

    IEnumerator SceneChange(string SceneName)
    {
        BlackScreen.gameObject.SetActive(true);
        BlackScreen.DOFade(1, 0.5f);

        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(SceneName);
    }
}