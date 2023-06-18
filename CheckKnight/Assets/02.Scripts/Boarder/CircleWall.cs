using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleWall : MonoBehaviour
{
    GameObject Board;
    bool isLeft = false;
    bool isUp = false;

    private void Awake()
    {
        Board = GameObject.Find("BoradImg");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            LimitMove.Instance.move--;

            if (other.transform.position.z > transform.position.z)
                isUp = true;
            else
                isUp = false;

            if (other.transform.position.x < transform.position.x)
                isLeft = true;
            else
                isLeft = false;

            Board.SetActive(true);
            CheckMark.Instance.Input(BlackKing.Instance.x, BlackKing.Instance.y);
            if (isUp)
            {
                if (isLeft)
                {
                    other.transform.position =
                        new Vector3(transform.position.x + 10f, other.transform.position.y, transform.position.z - 10f);

                    BlackKing.Instance.MoveRight();
                    BlackKing.Instance.MoveDown();
                }
                else
                {
                    other.transform.position =
                        new Vector3(transform.position.x - 10f, other.transform.position.y, transform.position.z - 10f);

                    BlackKing.Instance.MoveLeft();
                    BlackKing.Instance.MoveDown();
                }
            }
            else
            {
                if (isLeft)
                {
                    other.transform.position =
                        new Vector3(transform.position.x + 10f, other.transform.position.y, transform.position.z + 10f);

                    BlackKing.Instance.MoveRight();
                    BlackKing.Instance.MoveUp();
                }
                else
                {
                    other.transform.position =
                        new Vector3(transform.position.x - 10f, other.transform.position.y, transform.position.z + 10f);

                    BlackKing.Instance.MoveLeft();
                    BlackKing.Instance.MoveUp();
                }
            }

            Board.SetActive(false);
        }
    }
}
