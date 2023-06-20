using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour
{
    GameObject target;
    Vector3 dir;
    

    private void Update()
    {
        target = GameObject.Find("Player");
        dir = target.transform.position - transform.position;
        transform.position += dir.normalized * 4f * Time.deltaTime;
        Destroy(gameObject,12f);
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
