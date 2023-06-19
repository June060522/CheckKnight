using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SwapKeyBlock : MonoBehaviour
{
    [SerializeField] private int xIndex;
    [SerializeField] private int yIndex;
    private void Awake()
    {
        CheckMark.Instance.InputExclamation(xIndex, yIndex);
    }

    // Update is called once per frame
    void Update()
    {
        if (BlackKing.Instance.x == xIndex && BlackKing.Instance.y == yIndex)
        {
            if(FirstPersonController.Instance.isSwap)
                FirstPersonController.Instance.isSwap = false;
            else
                FirstPersonController.Instance.isSwap = true;

            Destroy(gameObject);
        }
    }
}
