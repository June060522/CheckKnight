using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] private int xIndex;
    [SerializeField] private int yIndex;

    [SerializeField] private int x;
    [SerializeField] private int y;
    [SerializeField] private int xPos;
    [SerializeField] private int yPos;

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
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.CompareTag("Player"))
        {
            GameStart.instance.End();

            CheckMark.Instance.Input(BlackKing.Instance.x, BlackKing.Instance.y);

            other.transform.position = new Vector3(xPos, 6, yPos);

            while(x > BlackKing.Instance.x)
            {
                BlackKing.Instance.MoveRight();
            }

            while (x < BlackKing.Instance.x)
            {
                BlackKing.Instance.MoveLeft();
            }

            while (y < BlackKing.Instance.y)
            {
                BlackKing.Instance.MoveDown();
            }

            while (y > BlackKing.Instance.y)
            {
                BlackKing.Instance.MoveUp();
            }
        }
    }
}
