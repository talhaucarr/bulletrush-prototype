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
        [SerializeField] private Transform sphere;
        [SerializeField] private Camera camera;
              
        private IMovementModule _movementModule;
        private ISkillModule _skillModule;

        private void Start()
        {
            _movementModule = GetComponent<MovementModule>();
            _skillModule = GetComponent<SkillModule>();
        }

        private void Update()
        {
            MovementInput();
            SkillInput();
        }

        private void MovementInput()
        {
            Ray ray = GetMouseRay();
            bool hasHit = Physics.Raycast(ray, out RaycastHit hit);

            if (!hasHit)
                return;

            /*if(Input.GetMouseButton(0))
                _movementModule.MoveTo(hit.point);*/          

        }

        private void SkillInput()
        {
            if (Input.GetMouseButton(0))
            {
                Debug.Log("Tiklanmaya baslandi");
                _skillModule.IncreaseScaleMultiplier();
            }
                

            if (Input.GetMouseButtonUp(0))
            {
                Debug.Log("Tiklanma birakildi");
                _skillModule.IncreaseScale();
            }
                
        }

        private Ray GetMouseRay()
        {
            return camera.ScreenPointToRay(Input.mousePosition);
        }


    }
}

