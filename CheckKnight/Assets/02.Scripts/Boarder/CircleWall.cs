using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleWall : MonoBehaviour
{
    bool isLeft = false;
    bool isUp = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.position.z > transform.position.z)
            isUp = true;
        else
            isUp = false;

        if(other.transform.position.x < transform.position.x)
            isLeft = true;
        else
            isLeft = false;

        if (isUp)
        {
            if(isLeft)
            {
                other.transform.position = 
                    new Vector3(transform.position.x + 10f, other.transform.position.y, other.transform.position.z - 15f);

                BlackKing.Instance.MoveRight();
                BlackKing.Instance.MoveDown();
            }
            else
            {
                other.transform.position = 
                    new Vector3(transform.position.x - 10f, other.transform.position.y, other.transform.position.z - 15f);

                BlackKing.Instance.MoveLeft();
                BlackKing.Instance.MoveDown();
            }
        }
        else
        {
            if (isLeft)
            {
                other.transform.position = 
                    new Vector3(transform.position.x + 10f, other.transform.position.y, other.transform.position.z + 15f);

                BlackKing.Instance.MoveRight();
                BlackKing.Instance.MoveUp();
            }
            else
            {
                other.transform.position = 
                    new Vector3(transform.position.x - 10f, other.transform.position.y, other.transform.position.z + 15f);

                BlackKing.Instance.MoveLeft();
                BlackKing.Instance.MoveUp();
            }
        }
    }
}
