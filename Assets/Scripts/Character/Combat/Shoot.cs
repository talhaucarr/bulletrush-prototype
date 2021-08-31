using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers;

namespace Character.Combat
{
    public class Shoot : MonoBehaviour, IShoot
    {
        [SerializeField] private Transform firePoint;
        [SerializeField] private GameObject bulletPrefab;
        
        [SerializeField] private float bulletSpeed;
        
        [SerializeField] private float fireRate;

        private bool _allowFire = true;
        private Transform _targetedEnemy = null;

        private void Update()
        {
            if(EnemyManager.Instance.AreEnemiesDead())
                return;
            
            _targetedEnemy = EnemyManager.Instance.ClosestTarget(transform.position, 0);
            
            transform.LookAt(_targetedEnemy.position + -1 * Vector3.right * _targetedEnemy.GetComponent<CapsuleCollider>().height / 2);

            
            if (_allowFire)
                StartShoot();
        }

        public void StartShoot()
        {
            StartCoroutine(ShootTarget());
        }
        

        private IEnumerator ShootTarget()
        {
            _allowFire = false;
            
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
            bullet.GetComponent<Bullet>().SetBulletSpeed(bulletSpeed);//default bullet set 5
            bullet.GetComponent<Bullet>().SetTransform(_targetedEnemy.position - firePoint.position);
            
            yield return new WaitForSeconds(fireRate);
            _allowFire = true;

        }
    }
}

