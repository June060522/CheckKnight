using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceInput : MonoBehaviour
{
    int count = 0;
    [SerializeField] Slider slider;

    private void OnCollisionStay(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.Space))
                count++;
        }
    }

    private void Update()
    {
        slider.value = (float)count / 50;

        if(count == 50)
        {
            transform.parent.GetComponent<OccupyZone>().EndEvent();
        }
    }
}
