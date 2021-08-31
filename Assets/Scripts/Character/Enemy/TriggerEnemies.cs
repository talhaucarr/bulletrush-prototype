using System;
using System.Collections;
using System.Collections.Generic;
using Character.Combat;
using UnityEngine;
using UnityEngine.AI;
using Core;
using Character.Enemy;
using Managers;

namespace Character.Enemy
{
    public class TriggerEnemies : MonoBehaviour
    {
        [SerializeField] private GameObject[] enemies;
        [SerializeField] private float enemyTriggerRange;
        [SerializeField] private Transform triggerPoint;

        private bool _isTriggered = false;
        
        private void Update()
        {
            if(PlayerManager.Instance.IsDead)
                return;
            
            if(Vector3.Distance(PlayerManager.Instance.Player.position, triggerPoint.position) > enemyTriggerRange) 
                return;
            
            if(_isTriggered)
                return;
            
            TriggerAllEnemies();
        }

        /*private void OnTriggerEnter(Collider other)
        {
            _collider.enabled = false;
            if(other.gameObject.GetComponent<TagSystem>().Tags.Contains(Tags.Player))
                TriggerAllEnemies();
        }*/

        private void TriggerAllEnemies()
        {
            foreach (var enemy in enemies)
            {
                enemy.GetComponent<AIController>().enabled = true;
            }

            _isTriggered = true;
        }
    }
}

