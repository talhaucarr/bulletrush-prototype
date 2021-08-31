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
            if(PlayerManager.Instance.IsDead)
                return;
            MoveToPlayer();
        }

        private void MoveToPlayer()
        {
            
            _movementModule.MoveTo(PlayerManager.Instance.Player.position);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name != "Player") return;
            PlayerManager.Instance.IsDead = true;
            Destroy(other.gameObject);
            SceneManager.Instance.EndGame("Loser!");
        }
    }
}

