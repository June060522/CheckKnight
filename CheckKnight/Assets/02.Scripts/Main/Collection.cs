using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Collection : MonoBehaviour
{
    [SerializeField] private int xIndex;
    [SerializeField] private int yIndex;

    [SerializeField] private GameObject canvas;
    [SerializeField] TextMeshProUGUI textMeshPro;

    private bool isStart = false;
    private void Awake()
    {
        CheckMark.Instance.InputQuestion(xIndex, yIndex);
    }

    // Update is called once per frame
    void Update()
    {
        if (BlackKing.Instance.x == xIndex && BlackKing.Instance.y == yIndex && !isStart)
        {
            isStart = true;
            GameStart.instance.Wall();
            canvas.SetActive(true);
        }
        
        if (transform.childCount - 1 == 0)
        {
            EndEvent();
            Destroy(gameObject);
        }

        if (isStart)
        {
            textMeshPro.text = $"Left : {transform.childCount - 1}";
        }
    }

    public void EndEvent()
    {
        LimitMove.Instance.move += 3;
        GameStart.instance.End();
    }
}
