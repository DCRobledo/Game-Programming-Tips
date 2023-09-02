using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Bridge
{
    public abstract class FightingBehaviour
    {
        protected ICompanion _companion;

        public abstract void Fight();

        public void SetCompanion(ICompanion companion)
        {
            _companion = companion;
        }
    }
}