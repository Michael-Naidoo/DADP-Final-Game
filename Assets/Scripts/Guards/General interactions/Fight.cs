using System;
using System.Collections;
using System.Collections.Generic;
using Player.Interactions;
using UnityEngine;

public class Fight : MonoBehaviour
{
    private PlayerInfo pI;
    private Guards.General_interactions.Bribe _bribe;
    private GameObject player;
    [SerializeField] private float attackRadius;
    private float attackInterval;
    [SerializeField] private float attackIntervalMax;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        pI = player.GetComponent<PlayerInfo>();
        _bribe = GetComponent<Guards.General_interactions.Bribe>();
    }

    private void Update()
    {
        DistCheck(gameObject.transform, player.transform); 
    }

    void DistCheck(Transform start, Transform target)
    {
        var dist = Vector3.Distance(start.position, target.position);
        Debug.Log(attackInterval);
        if (dist < attackRadius && _bribe.state == Guards.General_interactions.Bribe.bribe_state.Attacking)
        {
            
            attackInterval -= Time.deltaTime;
            if (attackInterval <= 0)
            {
                pI.hp--;
                attackInterval = attackIntervalMax;
            }
        }
        else
        {
            attackInterval = attackIntervalMax;
        }
    }
}
