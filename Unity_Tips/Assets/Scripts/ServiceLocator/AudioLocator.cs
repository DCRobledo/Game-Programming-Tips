using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.ServiceLocator
{
    public class AudioLocator
    {
        private static IAudioService _audioService;

        public static IAudioService GetAudioService()
        {
            return _audioService;
        }

        public static void SetAudioService(IAudioService audioService)
        {
            _audioService = audioService;
        }
    }
}