using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Character.Player
{
    public interface ISkillModule
    {
        void IncreaseScaleMultiplier();
        void IncreaseScale();

        void DecreaseScale();
    } 
}


