using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OrderFeel : MonoBehaviour
{
    [SerializeField] private int xIndex;
    [SerializeField] private int yIndex;

    public int index = 1;

    [SerializeField] private GameObject canvas;
    [SerializeField] TextMeshProUGUI textMeshPro;

    private bool isStart = false;
    private void Awake()
    {
        CheckMark.Instance.InputQuestion(xIndex, yIndex);
    }

    private void Update()
    {
        if (BlackKing.Instance.x == xIndex && BlackKing.Instance.y == yIndex && !isStart)
        {
            isStart = true;
            GameStart.instance.Wall();
            canvas.SetActive(true);
        }

        if(index == 7)
        {
            EndEvent();
            Destroy(gameObject);
        }

        if(isStart)
        {
            textMeshPro.text = $"NUM : {index}";
        }
    }

    public void EndEvent()
    {
        LimitTime.Instance.time += 20;
        GameStart.instance.End();
    }
}
