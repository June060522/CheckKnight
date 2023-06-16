using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalWall : MonoBehaviour
{
    GameObject Board;
    private void Awake()
    {
        Board = GameObject.Find("BoradImg");
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Board.SetActive(true);

            if (other.transform.position.x > transform.position.x)
            {
                other.transform.position = new Vector3(transform.position.x - 3f,other.transform.position.y,other.transform.position.z);
                BlackKing.Instance.MoveLeft();
            }
            else
            {
                other.transform.position = new Vector3(transform.position.x + 3f, other.transform.position.y, other.transform.position.z);
                BlackKing.Instance.MoveRight();
            }

            Board.SetActive(false);
        }
    }
}
