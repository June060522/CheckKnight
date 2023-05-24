using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackKing : MonoBehaviour
{
    [SerializeField] private int xIndex = 3;
    [SerializeField] private int yIndex = 0;

    RectTransform rect;

    private void Awake()
    {
        rect = GetComponent<RectTransform>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            MoveUp();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            MoveLeft();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            MoveDown();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            MoveRight();
        }
    }

    private void MoveUp()
    {
        yIndex++;
    }
    private void MoveDown()
    {
        yIndex--;
    }
    private void MoveRight()
    {
        xIndex++;
    }
    private void MoveLeft()
    {
        xIndex--;
    }
}
