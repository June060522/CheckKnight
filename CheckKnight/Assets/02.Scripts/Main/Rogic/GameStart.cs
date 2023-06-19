using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public static GameStart instance;
    BoxCollider[] box;
    CapsuleCollider[] capsule;
    private void Awake()
    {
        instance = this;
        box = GetComponentsInChildren<BoxCollider>();
        capsule = GetComponentsInChildren<CapsuleCollider>();
    }

    public void Wall()
    {
        foreach (BoxCollider boxCollider in box)
        {
            boxCollider.isTrigger = false;
        }

        foreach(CapsuleCollider capsule in capsule)
        {
            capsule.isTrigger = false;
        }
    }

    public void End()
    {
        foreach (BoxCollider boxCollider in box)
        {
            boxCollider.isTrigger = true;
        }

        foreach (CapsuleCollider capsule in capsule)
        {
            capsule.isTrigger = true;
        }
    }
}
