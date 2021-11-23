using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookPlayer : MonoBehaviour
{
    public Transform Player;

    Transform target;
    void Start()
    {
        target = Player.transform;
    }

    void Update()
    {
            transform.LookAt(Player);
    }
}
