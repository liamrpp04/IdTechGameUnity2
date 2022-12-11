using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class Monster : MonoBehaviour
{
    #region Private vals
    #endregion
    #region SerializeFielded vals
    [SerializeField] private Transform target;
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Animator anim;
    #endregion
    #region Public vals
    public static Monster Instance;
    #endregion
    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this; 
    }


    private void Update()
    {
        float distToTarget = Vector3.Distance(transform.position, target.position);
        if (distToTarget < 2.5f)
        {
            agent.isStopped = true;
            // ToolAnimation
            anim.SetBool("Attack_1", true);
        }
        else
        {
            anim.SetBool("Attack_1", false);

            agent.isStopped = false;
            agent.SetDestination(target.position);

        }

        if (agent.velocity.normalized.magnitude > 0.001f)
        {
            anim.SetBool("Walking", true);
        }
        else
        {
            anim.SetBool("Walking", false);

        }
    }
}
