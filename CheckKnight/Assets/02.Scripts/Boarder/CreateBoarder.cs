using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBoarder : MonoBehaviour
{
    [Header("벽 위치")]
    [SerializeField] bool cylinder = true;
    [SerializeField] bool left = true;
    [SerializeField] bool right = true;
    [SerializeField] bool up = true;
    [SerializeField] bool down = true;

    [Header("오브젝트")]
    [SerializeField] GameObject circle;
    [SerializeField] GameObject wall;
    [SerializeField] GameObject VerticalWall;

    public void Create()
    {
        if (cylinder)
        {
            GameObject obj = Instantiate(circle, transform);
            obj.transform.position = new Vector3(transform.position.x - 37.5f, transform.position.y, transform.position.z + 75);
        }

        if (left)
        {
            GameObject obj = Instantiate(wall, transform);
            obj.transform.position = new Vector3(transform.position.x - 37.5f, transform.position.y, transform.position.z + 37.5f);
            obj.transform.rotation = Quaternion.Euler(0, 90, 0);
        }

        if (right)
        {
            GameObject obj = Instantiate(wall, transform);
            obj.transform.position = new Vector3(transform.position.x + 37.5f, transform.position.y, transform.position.z + 37.5f);
            obj.transform.rotation = Quaternion.Euler(0, 90, 0);
        }

        if (up)
        {
            GameObject obj = Instantiate(VerticalWall, transform);
            obj.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 75);
        }

        if (down)
        {
            GameObject obj = Instantiate(VerticalWall, transform);
            obj.transform.position = transform.position;
        }
    }
}
