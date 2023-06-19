using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpeed : MonoBehaviour
{
    [SerializeField] private int xIndex = 3;
    [SerializeField] private int yIndex = 0;

    private void Awake()
    {
        CheckMark.Instance.InputExclamation(xIndex, yIndex);
    }

    void Update()
    {
        if (BlackKing.Instance.x == xIndex && BlackKing.Instance.y == yIndex)
        {
            FirstPersonController.Instance.walkSpeed -= 4;
            FirstPersonController.Instance.sprintSpeed += 4;

            Destroy(gameObject);
        }
    }
}
