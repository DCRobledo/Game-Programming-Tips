using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.State
{
    public interface IGhostState
    {
        IGhostState DoState(Ghost ghost);
    }
}