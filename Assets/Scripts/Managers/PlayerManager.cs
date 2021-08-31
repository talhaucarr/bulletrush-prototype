using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core;

namespace Managers
{
    public class PlayerManager : Singleton<PlayerManager>
    {
        [SerializeField] private Transform player;

        public Transform Player => player;
    }
}

