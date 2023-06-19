using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OccupyZone : MonoBehaviour
{
    [SerializeField] private int xIndex;
    [SerializeField] private int yIndex;

    [SerializeField] GameObject canvas;

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
            StartEvent();
        }
    }

    public void StartEvent()
    {
        GameStart.instance.Wall();

        canvas.SetActive(true);
    }

    public void EndEvent()
    {
        GameStart.instance.End();
        HP.Instance.hp += 3;
        Destroy(gameObject);
    }
}
