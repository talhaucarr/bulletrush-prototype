using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Character
{
    public interface IMovementModule
    {
        void MoveTo(Vector3 dir);
    }
}

