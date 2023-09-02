using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Bridge
{
    public interface ICompanion
    {
        public void Attack();
        
        public void Help();

        public void Run();

        public void Flee();
    }
}