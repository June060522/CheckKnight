using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Animator animator;
    public static PlayerAttack Instance;
    [SerializeField] GameObject joint;

    private MeshRenderer weapon;

    private bool isAttack = false;
    private float cool = 3f;
    private bool hidden = false;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        Instance = this;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && !hidden)
        {
            if(!isAttack)
            {
                StartCoroutine(Attack());
            }
        }

        if(Input.GetKeyDown(KeyCode.F))
        {
            if(!hidden)
            {
                hidden = true;
                Transform[] obj = GetComponentsInChildren<Transform>();
                foreach(Transform obj2 in obj)
                {
                    obj2.gameObject.SetActive(false);
                }
                transform.gameObject.SetActive(true);
                joint.gameObject.SetActive(true);
            }
            else
            {
                hidden=false;
                Transform[] obj = GetComponentsInChildren<Transform>();
                foreach (Transform obj2 in obj)
                {
                    obj2.gameObject.SetActive(true);
                }
            }
        }
    }

    IEnumerator Attack()
    {
        isAttack = true;
        animator.SetBool("Attack",true);
        yield return new WaitForSeconds(0.1f);
        animator.SetBool("Attack", false);
        yield return new WaitForSeconds(cool-0.1f);
        isAttack = false;
    }
}
