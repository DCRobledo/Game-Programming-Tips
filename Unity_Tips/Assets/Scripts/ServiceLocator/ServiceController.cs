using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.ServiceLocator
{
    public class ServiceController : MonoBehaviour
    {
        private void Start() 
        {
            AudioLocator.SetAudioService(new AudioProvider());
        }
    }
}