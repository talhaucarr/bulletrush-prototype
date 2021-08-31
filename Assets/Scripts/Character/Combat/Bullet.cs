using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using Managers;
using UnityEngine;

namespace Character.Combat
{
    public class Bullet : MonoBehaviour
    {
        private float _speed = 5f;

        private Vector3 _target = Vector3.zero;
        
        private void Update()
        {
            transform.Translate(_target.normalized * _speed *Time.deltaTime);
        }

        public void SetTransform(Vector3 setTransform)
        {
            _target = setTransform;
        }
        
        public void SetBulletSpeed(float speed)
        {
            _speed = speed;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (!other.gameObject.GetComponent<TagSystem>().Tags.Contains(Tags.Enemy))
                return;
            
            EnemyManager.Instance.DeathEnemy(other.transform);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}

