using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Facade
{
    public class ScreenSwitcher : MonoBehaviour
    {
        public static ScreenSwitcher instance;

        private void Awake() 
        {
            instance = this;
        }

        public void SwitchScreen(string screenMode)
        {
            // Transition screen to a particular gamemode
        }
    }
}