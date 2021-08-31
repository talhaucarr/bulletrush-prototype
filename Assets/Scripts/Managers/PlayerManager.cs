using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core;

namespace Managers
{
    public class PlayerManager : Singleton<PlayerManager>
    {
        [SerializeField] private Transform player;
        [SerializeField] private bool isDead = false;
        public Transform Player => player;

        public bool IsDead
        {
            get => isDead;
            set => isDead = true;
        }
    }
}

