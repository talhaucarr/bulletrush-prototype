using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public enum Tags
    {
        Ground,
        Player,
        Enemy,
        None,
        Bullet,
        Skill,
        Body,
    }
    public class TagSystem : MonoBehaviour
    {
        [SerializeField] private List<Tags> tags;
        public List<Tags> Tags => tags;
    }
}

