using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.ServiceLocator
{
    public class AudioProvider : IAudioService
    {
        public void PlaySound(string soundName)
        {
            // Play a sound
        }

        public void StopSound(string soundName)
        {
            // Stop a sound
        }
    }
}