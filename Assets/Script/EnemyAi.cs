using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyAi : MonoBehaviour
{
    public Transform Player;
    CharacterController _controller;
    Transform target;
    public bool FollowPlayer = false;
    [SerializeField]
    float _moveSpeed = 5.0f;


    // Use this for initialization
    void Start()
    {
        target = Player.transform;
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    { 
        if (FollowPlayer)
        {   
            transform.LookAt(Player);
            Vector3 direction = target.position - transform.position;
            direction = direction.normalized;
            Vector3 velocity = direction * _moveSpeed;
            _controller.Move(velocity * Time.deltaTime);  
        }
    }
}
