using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Managers
{
    public class SceneManager : Singleton<SceneManager>
    {
        private void RestartGame()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Scenes/Level1");
        }
        
        private IEnumerator ShowUI(string message)
        {
            UIManager.Instance.TriggerNotification(message);
            yield return new WaitForSeconds(5);
            RestartGame();
        }

        public void EndGame(string message)
        {
            StartCoroutine(ShowUI(message));
        }
    }
}

