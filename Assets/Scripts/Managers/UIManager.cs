using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Core;

namespace Managers
{
    public class UIManager : Singleton<UIManager>
    {
        [SerializeField] private GameObject notificationUI;
        [SerializeField] private TextMeshProUGUI notificationText;
        [SerializeField] private TextMeshProUGUI enemiesCount;

        public void TriggerNotification(string message)
        {
            SetNotificationMessage(message);
            notificationUI.gameObject.SetActive(true);
        }

        private void SetNotificationMessage(string message)
        {
            notificationText.text = message;
        }

        public void SetEnemyCounterText(string count)
        {
            enemiesCount.text = count;
        }
    }
}


