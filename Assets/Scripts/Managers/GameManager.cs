using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public class GameManager : MonoBehaviour
    {
        
        private void Start()
        {
            UIManager.Instance.SetEnemyCounterText(EnemyManager.Instance.Enemies.Count.ToString());
        }
        
        private void Update()
        {
            if (!EnemyManager.Instance.AreEnemiesDead()) return;
            SceneManager.Instance.EndGame("Winner!");
        }
    }
}

