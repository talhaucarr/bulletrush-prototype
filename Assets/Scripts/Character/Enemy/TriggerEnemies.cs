using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Core;
using Character.Enemy;

public class TriggerEnemies : MonoBehaviour
{
    [SerializeField] private GameObject[] enemies;

    private BoxCollider _collider;

    private void Start()
    {
        _collider = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _collider.enabled = false;
        if(other.gameObject.GetComponent<TagSystem>().Tags.Contains(Tags.Player))
            TriggerAllEnemies();
    }

    private void TriggerAllEnemies()
    {
        foreach (var enemy in enemies)
        {
            enemy.GetComponent<AIController>().enabled = true;
        }
    }
}
