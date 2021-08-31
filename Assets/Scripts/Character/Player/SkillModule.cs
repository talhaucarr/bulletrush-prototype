using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Character.Player
{
    public class SkillModule : MonoBehaviour, ISkillModule
    {
        [SerializeField] private Transform sphere;
        [SerializeField] private float skillSpeed;
       

        private float _scaleMultiplier = 1;
        private Vector3 _originalScale;

        private void Start()
        {
            _originalScale = sphere.localScale;
        }

        public void IncreaseScale()
        {
            StartCoroutine(ScaleOverTime(skillSpeed));
        }

        public void IncreaseScaleMultiplier()
        {
            Debug.Log(_scaleMultiplier);
            _scaleMultiplier += _scaleMultiplier * Time.deltaTime;
        }

        public void DecreaseScale()
        {
            sphere.localScale = _originalScale;
        }
        

        private IEnumerator ScaleOverTime(float time)
        {           
            Vector3 destinationScale = new Vector3(_scaleMultiplier, _scaleMultiplier, _scaleMultiplier);

            float currentTime = 0.0f;

            do
            {
                sphere.localScale = Vector3.Lerp(_originalScale, destinationScale, currentTime / time);  
                currentTime += Time.deltaTime;
                yield return null;
            } while (currentTime <= time);


        }
    }
}

