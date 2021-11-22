using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldOfView : MonoBehaviour
{
    public float radius;
    [Range(0,360)]
    public float angle;
    public EnemyAi enemyAiScpt;
    public AudioSource source;

    public GameObject playerRef;

    public LayerMask targetMask;
    public LayerMask obstructionMask;

    public bool canSeePlayer;
    public bool isPlayingSong = false;



    private void Update() 
    {
        checkView();
        enemyAiScpt.FollowPlayer = canSeePlayer;
        
        if (canSeePlayer && !isPlayingSong)
        {   
            source.Play();
            isPlayingSong = true;
        }
        if (!canSeePlayer)
        {
            isPlayingSong = false;
            source.Pause();
        }
    }

    private void checkView()
    {
        Collider[] rangeChecks = Physics.OverlapSphere(transform.position, radius, targetMask);
        if (rangeChecks.Length != 0)
        {   
            Transform target = rangeChecks[0].transform;
            Vector3 directionToTarget = (target.position - transform.position).normalized;

            if (Vector3.Angle(transform.forward, directionToTarget) < angle / 2)
            {
                float distanceToTarget = Vector3.Distance(transform.position, target.position);

                if (!Physics.Raycast(transform.position, directionToTarget, distanceToTarget, obstructionMask))
                {   
                    canSeePlayer = true;
                }
                else
                {
                    canSeePlayer = false;
                }
                    
            }
            else
            {
                canSeePlayer = false;
            }
                
        }
        else
        {
            canSeePlayer = false;
        }
            
    }
    

}