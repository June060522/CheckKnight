using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class King : MonoBehaviour
{
    BossHP bossHP;
    bool one = false;
    bool two = false;
    bool three = false;
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
            if (!one && bossHP.hp / bossHP.maxhp <= 0.75f)
            {
                one = true;
                StartCoroutine(Pattern2());
            }
            if (!two && bossHP.hp / bossHP.maxhp <= 0.50f)
            {
                two = true;
                Pattern3();
            }
            if (!three && bossHP.hp / bossHP.maxhp <= 0.25f)
            {
                three = true;
                Pattern4();
            }
            yield return null;
        }
    }
    IEnumerator Pattern1()
    {
        while (true)
        {
            yield return null;
        }
    }
    IEnumerator Pattern2()
    {
        while (true)
        {
            yield return null;
        }
    }
    public void Pattern3()
    {
        HP.Instance.hp /= 2;
    }
    public void Pattern4()
    {
        FirstPersonController.Instance.walkSpeed -= 3;
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }
}
