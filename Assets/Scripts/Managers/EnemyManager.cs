using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core;

namespace Managers
{
    public class EnemyManager : Singleton<EnemyManager>
    {
        public List<Transform> Enemies { get; private set; } = new List<Transform>();

        public Transform ClosestTarget(Vector3 point, int order)
        {
            if (Enemies == null) return null;

            Vector2 tempPoint = new Vector2(point.x, point.z);
            Enemies.Sort((a, b) => Vector2
                .Distance(tempPoint, new Vector2(a.transform.position.x, a.transform.position.z))
                .CompareTo(
                    Vector2.Distance(tempPoint, new Vector2(b.transform.position.x, b.transform.position.z))));
            return Enemies[order];
        }

        public void DeathEnemy(Transform currentEnemy)
        {
            Enemies.Remove(currentEnemy);
        }

        public bool AreEnemiesDead()
        {
            return Enemies.Count == 0;
        } 
        
    }
}

