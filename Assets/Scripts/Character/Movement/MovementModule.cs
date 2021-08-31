using System;
using System.Collections;
using System.Collections.Generic;
using Character;
using UnityEngine;
using UnityEngine.AI;

namespace Character
{
    public class MovementModule : MonoBehaviour, IMovementModule
    {
        private NavMeshAgent _navMeshAgent;
        
        private void Start()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();
        }
        
        public void MoveTo(Vector3 dir)
        {
            _navMeshAgent.destination = dir;
        }


    }
}

