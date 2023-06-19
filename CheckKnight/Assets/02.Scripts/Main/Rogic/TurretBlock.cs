using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TurretBlock : MonoBehaviour
{
    [SerializeField] private int xIndex;
    [SerializeField] private int yIndex;

    [SerializeField] GameObject canvas;

    [SerializeField] TextMeshProUGUI tmpro;

    private bool isStart = false;

    private void Awake()
    {
        CheckMark.Instance.InputQuestion(xIndex, yIndex);
    }

    private void Update()
    {
        if(BlackKing.Instance.x == xIndex && BlackKing.Instance.y == yIndex && !isStart)
        {
            isStart = true;
            StartEvent();
        }

        if(transform.childCount - 1 == 0)
        {
            EndEvent();
            Destroy(gameObject);
        }

        if(isStart)
        {
            tmpro.text = $"LEFT : {transform.childCount - 1}";
        }
    }

    public void StartEvent()
    {
        GameStart.instance.Wall();

        Tower[] obj = GetComponentsInChildren<Tower>();
        foreach (Tower go in obj)
        {
            go.Go();
        }

        canvas.SetActive(true);
    }

    public void EndEvent()
    {
        LimitMove.Instance.move += 5;
        GameStart.instance.End();
    }
}
