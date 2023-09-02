using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.ServiceLocator
{
    public interface IAudioService
    {
        public void PlaySound(string soundName);

        public void StopSound(string soundName);
    }
}