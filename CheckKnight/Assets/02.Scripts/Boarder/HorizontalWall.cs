using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalWall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(other.transform.position.x > transform.position.x)
            {
                other.transform.position = new Vector3(transform.position.x - 3f,other.transform.position.y,other.transform.position.z);
            }
            else
            {
                other.transform.position = new Vector3(transform.position.x + 3f, other.transform.position.y, other.transform.position.z);
            }
        }
    }
}
