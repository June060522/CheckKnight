using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{
    BossHP bossHP;
    [SerializeField] GameObject bullet;
    private void Awake()
    {
        bossHP = GetComponent<BossHP>();
    }

    private void OnEnable()
    {
        StartCoroutine(Pattern());
    }

    IEnumerator Pattern()
    {
        while (true)
        {
            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y + 5f, transform.position.z), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y + 5f, transform.position.z), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y + 5f, transform.position.z), Quaternion.identity);
            yield return new WaitForSeconds(4f);
        }
    }

    private void OnDisable()
    {
        LimitTime.Instance.time += 20;
        StopAllCoroutines();
    }
}
