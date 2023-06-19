using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonManager : MonoBehaviour
{
    public static PlayButtonManager Instance;

    [SerializeField] private GameObject blackScreen;
    [SerializeField] GameObject escPanel;
    [SerializeField] AudioClip esc;
    [SerializeField] AudioClip btnclick;

    private void Awake()
    {
        Instance = this;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && !blackScreen.activeSelf)
        {
            EffectAudio.Instance.ListenEff(esc);
            if(escPanel.activeSelf)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                escPanel.SetActive(false);
                Time.timeScale = 1f;
            }
            else
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                escPanel.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }

    public void ClickQuit()
    {
        EffectAudio.Instance.ListenEff(btnclick);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene("Intro");
        Time.timeScale = 1f;
    }

    public void ClickX()
    {
        EffectAudio.Instance.ListenEff(btnclick);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        escPanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
