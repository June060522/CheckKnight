using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPItem : MonoBehaviour
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
            HP.Instance.hp += 3;
            Destroy(gameObject);
        }
    }
}
