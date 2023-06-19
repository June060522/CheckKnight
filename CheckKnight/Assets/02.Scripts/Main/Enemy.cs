using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int xIndex;
    [SerializeField] private int yIndex;

    [SerializeField] private GameObject canvas;
    [SerializeField] TextMeshProUGUI textMeshPro;

    [SerializeField] private GameObject enemy;

    private bool isStart = false;
    private float time = 20f;

    private void Awake()
    {
        CheckMark.Instance.InputQuestion(xIndex, yIndex);
    }

    void Update()
    {
        if (BlackKing.Instance.x == xIndex && BlackKing.Instance.y == yIndex && !isStart)
        {
            isStart = true;
            LimitTime.Instance.time += 20;
            GameStart.instance.Wall();
            canvas.SetActive(true);
            enemy.SetActive(true);
        }

        if (time <= 0)
        {
            EndEvent();
            Destroy(gameObject);
        }

        if (isStart)
        {
            time -= Time.deltaTime;
            textMeshPro.text = $"Time : {time.ToString("N1")}";
        }
    }

    public void EndEvent()
    {
        LimitTime.Instance.time += 20;
        GameStart.instance.End();
    }
}
