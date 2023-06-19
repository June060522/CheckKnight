using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    public void Go()
    {
        StartCoroutine(Fire());
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
            Destroy(gameObject);
    }

    IEnumerator Fire()
    {
        while(true)
        {
            yield return new WaitForSeconds(3f);
            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y + 3f, transform.position.z),Quaternion.identity) ;
        }
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }
}
