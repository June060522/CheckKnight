using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonManager : MonoBehaviour
{
    [SerializeField] GameObject escPanel;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
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
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene("Intro");
        Time.timeScale = 1f;
    }

    public void ClickX()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        escPanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
