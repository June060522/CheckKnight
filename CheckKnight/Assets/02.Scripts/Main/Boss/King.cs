using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class King : MonoBehaviour
{
    BossHP bossHP;
    bool one = false;
    bool two = false;
    bool three = false;

    [SerializeField] string stage;
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject bullet1;

    private void Awake()
    {
        bossHP = GetComponent<BossHP>();
    }

    private void OnEnable()
    {
        StartCoroutine(Pattern());
        StartCoroutine(Pattern0());
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
    IEnumerator Pattern0()
    {
        while (true)
        {
            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y + 5f, transform.position.z), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }

    IEnumerator Pattern1()
    {
        while (true)
        {
            Instantiate(bullet1, new Vector3(transform.position.x, transform.position.y + 5f, transform.position.z), Quaternion.identity);
            yield return new WaitForSeconds(15f);
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

            yield return new WaitForSeconds(3f);
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
        if(bossHP.hp <= 0)
        {
            PlayerPrefs.SetInt(stage, 1);
            HP.Instance.hp = 0;
        }
    }
}
