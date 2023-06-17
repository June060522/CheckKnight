using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public static PlayerAttack Instance;

    private MeshRenderer weapon;

    private bool isAttack = false;
    private float cool = 1f;
    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if(!isAttack)
            {
                StartCoroutine(Attack());
            }
        }
    }

    IEnumerator Attack()
    {
        isAttack = true;
        weapon = GetComponentInChildren<MeshRenderer>();
        Debug.Log(weapon);
        weapon.transform.DOLocalMove(new Vector3(0, 1.3f, -2f),0.4f);
        weapon.transform.DOLocalRotate(new Vector3(-48f, 0, 0),0.4f);
        yield return new WaitForSeconds(0.3f);
        weapon.transform.DOLocalMove(new Vector3(-0.92f, 0.69f, 1.49f), 0.4f);
        weapon.transform.DOLocalRotate(new Vector3(-38.27f, 0, 0), 0.4f);
        yield return new WaitForSeconds(0.4f);
        weapon.transform.DOLocalMove(new Vector3(0f, 0, 0),0.4f);
        weapon.transform.DOLocalRotate(new Vector3(0f, 0, 0),0.4f);
        yield return new WaitForSeconds(cool);
        isAttack = false;
    }
}
