using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    float i = 0f;
    private void Update()
    {
        i -= 0.03f;
        transform.rotation = Quaternion.Euler(0f, i, 0f);
    }
}
