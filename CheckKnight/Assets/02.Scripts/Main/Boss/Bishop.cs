using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bishop : MonoBehaviour
{
    [SerializeField] GameObject bullet;
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
            if (!one && bossHP.hp / bossHP.maxhp <= 0.50f)
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
            yield return new WaitForSeconds(4f);
        }
    }

    IEnumerator Pattern2()
    {
        while (true)
        {
            FirstPersonController.Instance.CanAttack = false;
            FirstPersonController.Instance.playerCanMove = false;
            yield return new WaitForSeconds(1f);
            FirstPersonController.Instance.playerCanMove = true;
            FirstPersonController.Instance.CanAttack = true;

            yield return new WaitForSeconds(5f);
        }
    }

    private void OnDisable()
    {
        StopAllCoroutines();
        FirstPersonController.Instance.CanAttack = true;
        LimitTime.Instance.time += 25;
    }
}