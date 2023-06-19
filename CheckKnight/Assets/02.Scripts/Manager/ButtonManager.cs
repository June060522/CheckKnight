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

    [SerializeField] AudioClip btnclick;
    [SerializeField] AudioClip esc;
    public void ClickScreen()
    {
        if (!OptionPanel.activeSelf && !StageInfo.activeSelf && !ExplainPanel.activeSelf)
        {
            EffectAudio.Instance.ListenEff(btnclick);
            StagePanel.SetActive(true);
        }
    }

    public void ClickOption()
    {

        if (!StagePanel.activeSelf && !StageInfo.activeSelf && !ExplainPanel.activeSelf)
        {
            EffectAudio.Instance.ListenEff(btnclick);
            OptionPanel.SetActive(true);
        }
    }

    public void ClickHelp()
    {
        if(!StagePanel.activeSelf && !StageInfo.activeSelf && !OptionPanel.activeSelf)
        {
            EffectAudio.Instance.ListenEff(btnclick);
            ExplainPanel.SetActive(true);
        }
    }

    public void CloseOption()
    {
        EffectAudio.Instance.ListenEff(btnclick);
        OptionPanel.SetActive(false);
    }

    public void CloseStage()
    {
        EffectAudio.Instance.ListenEff(btnclick);
        StagePanel.SetActive(false);
    }

    public void CloseExplain()
    {
        EffectAudio.Instance.ListenEff(btnclick);
        ExplainPanel.SetActive(false);
    }

    public void QuitButton()
    {
        EffectAudio.Instance.ListenEff(btnclick);
        Application.Quit();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(StagePanel.activeSelf || OptionPanel.activeSelf || ExplainPanel.activeSelf || StageInfo.activeSelf)
                EffectAudio.Instance.ListenEff(esc);
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
        EffectAudio.Instance.ListenEff(btnclick);
        StageInfo.SetActive(true);
        StagePanel.SetActive(false);
        obj.SetActive(true);
    }

    public void GameStart(string SceneName)
    {
        EffectAudio.Instance.ListenEff(btnclick);
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