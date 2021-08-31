using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Character.Player
{
    public class PlayerLookAt : MonoBehaviour
    {
        [SerializeField] private Transform body;
        [SerializeField] private Transform rightHand;
        [SerializeField] private Transform leftHand;

        private void Update()
        {
            body.LookAt(rightHand.position-leftHand.position);
        }
    }
}

