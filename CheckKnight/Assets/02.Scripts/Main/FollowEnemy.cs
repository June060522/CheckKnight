using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowEnemy : MonoBehaviour
{
    private Transform m_Target;
    NavMeshAgent agent;
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        m_Target = GameObject.Find("Player").transform;
    }

    private void Update()
    {
        agent.SetDestination(m_Target.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
            HP.Instance.hp--;
    }
}
