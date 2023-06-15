using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour
{
    [SerializeField] GameObject Minimap;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            if(Minimap.activeSelf)
                Minimap.SetActive(false);
            else
                Minimap.SetActive(true);
        }
    }
}
