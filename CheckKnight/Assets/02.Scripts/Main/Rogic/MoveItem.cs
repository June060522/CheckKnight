using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveItem : MonoBehaviour
{
    [SerializeField] private int xIndex;
    [SerializeField] private int yIndex;
    private void Awake()
    {
        CheckMark.Instance.InputExclamation(xIndex, yIndex);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            LimitMove.Instance.move += 3;
            Destroy(gameObject);
        }
    }
}
