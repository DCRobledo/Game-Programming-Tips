using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Command
{
    public class JumpCommand : Command
    {
        public override void Execute()
        {
            // Jump code
        }

        public override void Undo()
        {
            throw new System.NotImplementedException();
        }
    }
}