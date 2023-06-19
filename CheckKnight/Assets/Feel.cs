using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feel : MonoBehaviour
{
    [SerializeField] int index = 0;
    OrderFeel orderFeel;

    private void Awake()
    {
        orderFeel = transform.GetComponentInParent<OrderFeel>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(index == orderFeel.index)
            {
                orderFeel.index++;
                Destroy(gameObject);
            }
        }
    }
}
