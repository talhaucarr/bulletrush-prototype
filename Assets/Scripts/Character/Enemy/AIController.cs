using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using Managers;
using UnityEngine;

namespace Character.Enemy
{
    public class AIController : MonoBehaviour
    {
        private IMovementModule _movementModule;

        private void Start()
        {
            _movementModule = GetComponent<MovementModule>();
        }

        private void Update()
        {
            MoveToPlayer();
        }

        private void MoveToPlayer()
        {
            _movementModule.MoveTo(PlayerManager.Instance.Player.position);
        }

        private void OnTriggerEnter(Collider other)
        {
            
            Debug.Log("here"+other);
            if(other.gameObject.GetComponent<TagSystem>().Tags.Contains(Tags.Player))
                Destroy(other.gameObject);
        }
    }
}

