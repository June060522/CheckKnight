using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queen : MonoBehaviour
{
    BossHP bossHP;
    bool one = false;
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
            if (!one && bossHP.hp / bossHP.maxhp <= 0.66f)
            {
                one = true;
                StartCoroutine(Pattern2());
            }
            yield return null;
        }
    }

    IEnumerator Pattern2()
    {
        yield return null;
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }
}
