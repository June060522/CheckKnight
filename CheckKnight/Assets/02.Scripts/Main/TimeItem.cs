using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeItem : MonoBehaviour
{
    [SerializeField] private int xIndex;
    [SerializeField] private int yIndex;
    private void Awake()
    {
        CheckMark.Instance.InputExclamation(xIndex, yIndex);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            LimitTime.Instance.time += 30f;
            Destroy(gameObject);
        }
    }
}
