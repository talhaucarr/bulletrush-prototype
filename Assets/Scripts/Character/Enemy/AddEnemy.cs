using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers;

namespace Character.Enemy
{
    public class AddEnemy : MonoBehaviour
    {
        private void Awake()
        {
            EnemyManager.Instance.Enemies.Add(transform);   
            
        }
    }
}

