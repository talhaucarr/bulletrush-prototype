using System;
using System.Collections;
using System.Collections.Generic;
using Character.Combat;
using Managers;
using UnityEngine;


namespace Character.Player
{
    public class InputModule : MonoBehaviour
    {
        [SerializeField] private Camera camera;
        [SerializeField] private Transform tas;
        private IMovementModule _movementModule;

        private void Start()
        {
            _movementModule = GetComponent<MovementModule>();
        }

        private void Update()
        {
            MoveToMousePos();
        }

        private void MoveToMousePos()
        {
            Ray ray = GetMouseRay();
            bool hasHit = Physics.Raycast(ray, out RaycastHit hit);
            
            if(!hasHit)
                return;
            
            if(Input.GetMouseButton(0))
                _movementModule.MoveTo(hit.point);
            
        }

        private Ray GetMouseRay()
        {
            return camera.ScreenPointToRay(Input.mousePosition);
        }
    }
}

