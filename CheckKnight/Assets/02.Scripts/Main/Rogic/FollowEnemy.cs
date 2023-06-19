using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowEnemy : MonoBehaviour
{
    private Transform m_Target;
    NavMeshAgent agent;
    private float delay = 0f;
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        m_Target = GameObject.Find("Player").transform;
    }

    private void Update()
    {
        delay -= Time.deltaTime;
        agent.SetDestination(m_Target.position);
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.transform.CompareTag("Player") && delay <= 0)
        {
            delay = 1f;
            HP.Instance.hp--;
        }
    }
}
