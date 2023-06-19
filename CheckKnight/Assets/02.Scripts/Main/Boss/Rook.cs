using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rook : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject bullet1;

    BossHP bossHP;
    bool one = false;
    private void Awake()
    {
        bossHP = GetComponent<BossHP>();
    }

    private void OnEnable()
    {
        StartCoroutine(Pattern());
        StartCoroutine(Pattern1());
    }

    IEnumerator Pattern()
    {
        while (true)
        {
            if(!one && bossHP.hp / bossHP.maxhp <= 0.50f)
            {
                one = true;
                StartCoroutine(Pattern2());
            }
            yield return null;
        }
    }
    IEnumerator Pattern1()
    {
        while (true)
        {
            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y + 5f, transform.position.z), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }

    IEnumerator Pattern2()
    {
        while(true)
        {
            Instantiate(bullet1, new Vector3(transform.position.x, transform.position.y + 5f, transform.position.z), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }
}
