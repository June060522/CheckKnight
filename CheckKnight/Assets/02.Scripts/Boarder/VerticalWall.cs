using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalWall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.transform.position.z > transform.position.z)
            {
                other.transform.position = new Vector3(transform.position.x, other.transform.position.y, other.transform.position.z - 3f);
                BlackKing.Instance.MoveDown();
            }
            else
            {
                other.transform.position = new Vector3(transform.position.x, other.transform.position.y, other.transform.position.z + 3f);
                BlackKing.Instance.MoveUp();
            }
        }
    }
}
