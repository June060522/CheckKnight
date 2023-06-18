using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalWall : MonoBehaviour
{
    GameObject Board;
    private void Awake()
    {
        Board = GameObject.Find("BoradImg");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            LimitMove.Instance.move--;

            Board.SetActive(true);
            CheckMark.Instance.Input(BlackKing.Instance.x, BlackKing.Instance.y);
            if (other.transform.position.z > transform.position.z)
            {
                other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y, transform.position.z - 3f);
                BlackKing.Instance.MoveDown();
            }
            else
            {
                other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z + 3f);
                BlackKing.Instance.MoveUp();
            }

            Board.SetActive(false);
        }
    }
}
