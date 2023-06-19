using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPos : MonoBehaviour
{
    [SerializeField] private int xIndex;
    [SerializeField] private int yIndex;

    [SerializeField] private GameObject canvas;
    [SerializeField] private GameObject enemy;

    private bool isStart = false;

    // Update is called once per frame
    void Update()
    {
        if (BlackKing.Instance.x == xIndex && BlackKing.Instance.y == yIndex && !isStart)
        {
            isStart = true;
            GameStart.instance.Wall();
            canvas.SetActive(true);
            enemy.SetActive(true);
        }
    }
}
