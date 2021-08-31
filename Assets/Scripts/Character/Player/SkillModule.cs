using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core;
using Managers;

namespace Character.Player
{
    public class SkillModule : MonoBehaviour, ISkillModule
    {
        [SerializeField] private Transform sphere;
        [SerializeField] private float skillSpeed;
        
        private float _scaleMultiplier = 1;
        private Vector3 _originalScale;
        private Vector3 _destinationScale;

        private void Start()
        {
            _originalScale = sphere.localScale;
        }

        public void IncreaseScale()
        {
            _destinationScale = new Vector3(_scaleMultiplier, _scaleMultiplier, _scaleMultiplier);
            StartCoroutine(ScaleOverTime(_originalScale,_destinationScale,skillSpeed));
        }

        public void IncreaseScaleMultiplier()
        {
            if(_scaleMultiplier<=25)
                _scaleMultiplier += _scaleMultiplier * Time.deltaTime;
        }

        private IEnumerator ScaleOverTime(Vector3 a, Vector3 b, float time)
        {
            float currentTime = 0.0f;

            do
            {
                sphere.localScale = Vector3.Lerp(_originalScale, _destinationScale, currentTime / time);  
                currentTime += Time.deltaTime;
                yield return null;
            } while (currentTime <= time);

            BackToOld();
        }

        private void BackToOld()
        {
            _scaleMultiplier = 1;
            sphere.localScale = _originalScale;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (!other.gameObject.GetComponent<TagSystem>().Tags.Contains(Tags.Enemy))
                return;
            
            EnemyManager.Instance.DeathEnemy(other.transform);
            
        }
    }
}

