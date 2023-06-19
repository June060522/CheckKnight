using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    GameObject target;
    Vector3 dir;
    private void OnEnable()
    {
        target = GameObject.Find("Player");
        dir = target.transform.position - transform.position;
    }

    private void Update()
    {
        transform.position += dir.normalized * 4f * Time.deltaTime;
        Destroy(gameObject,6f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HP.Instance.hp--;
            Destroy(gameObject);
        }
    }
}
