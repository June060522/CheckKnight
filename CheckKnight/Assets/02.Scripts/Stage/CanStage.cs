using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanStage : MonoBehaviour
{
    [SerializeField] string index;
    Button btn;

    private void Awake()
    {
        btn = GetComponent<Button>();
    }

    private void Update()
    {
        if (PlayerPrefs.GetInt(index, 0) == 1)
        {
            btn.interactable = true;
        }
    }
}
