using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Features.LevelStreaming
{
    public class LevelSwitcher : MonoBehaviour
    {
        [SerializeField]
        private string sceneName;

        private bool shouldLoad = true;

        private void OnTriggerEnter(Collider other) 
        {
            if(other.tag.Equals("Player"))
            {
                if(shouldLoad)
                {
                    LevelController.Instance.RequestLoadScene(sceneName);

                    shouldLoad = false;
                }

                else
                {
                    LevelController.Instance.RequestUnloadScene(sceneName);

                    shouldLoad = true;
                }
            }
        }
    }
}