using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using ProjectUtils;

public class Monster : MonoBehaviour
{
    #region Private vals
    #endregion
    #region SerializeFielded vals
    [SerializeField] private Transform target;
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Animator anim;
    [SerializeField] private float seperationDistanceForMonnster = 2.5f;
    #endregion
    #region Public vals
    public static Monster Instance;
    #endregion

    public void ForcePosition(Vector3 position)
    {
        //agent.ResetPath();
        agent.enabled = false;
        transform.position = position;
        this.ActionAfterReturnedNull(() =>
        {
            agent.enabled = true;
        });
    }

    private void Update()
    {
        if (!PlayerController.ControlEnabled) return;
        if (!agent.enabled) return;

        float distToTarget = Vector3.Distance(transform.position, target.position);
        if (distToTarget < seperationDistanceForMonnster)
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
