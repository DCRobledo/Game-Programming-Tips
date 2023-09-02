using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.HumbleObject
{
    public interface IPlayer
    {
        Vector3 Position { get; set; }

        float HorizontalMaxLimit { get; }
        float HorizontalMinLimit { get; }
    }
}