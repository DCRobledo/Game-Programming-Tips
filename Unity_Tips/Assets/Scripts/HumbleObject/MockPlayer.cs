using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.HumbleObject
{
    public class MockPlayer : IPlayer
    {
        public Vector3 Position { get; set; }

        public float HorizontalMaxLimit { get; set; }

        public float HorizontalMinLimit { get; set; }
    }
}