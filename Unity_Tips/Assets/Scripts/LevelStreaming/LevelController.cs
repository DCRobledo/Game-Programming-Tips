using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Features.LevelStreaming
{
    public class LevelController : MonoBehaviour
    {
        public static LevelController Instance;

        private Dictionary<string, LoadSceneMode> _loadedScenes = new Dictionary<string, LoadSceneMode>();

        private List<string> _neededScenes = new List<string>();

        private AsyncOperation _loadingOperation;
        private AsyncOperation _unloadingOperation;


        private void Awake() 
        {
            Instance = this;
        }

        private void Start() 
        {
            _neededScenes.Add(SceneManager.GetActiveScene().name);
        }


        private void Update() 
        {
            if(_loadingOperation == null || _loadingOperation.isDone)
            {
                CheckForLoad();
            }

            if(_unloadingOperation == null || _unloadingOperation.isDone)
            {
                CheckForUnload();
            }
        }

        private void CheckForLoad()
        {
            foreach(string sceneName in _neededScenes)
            {
                if(!_loadedScenes.ContainsKey(sceneName))
                {
                    _loadingOperation = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
                }
            }
        }

        private void CheckForUnload()
        {
            foreach(KeyValuePair<string, LoadSceneMode> loadedScene in _loadedScenes)
            {
                if(!_neededScenes.Contains(loadedScene.Key))
                {
                    _unloadingOperation = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName(loadedScene.Key));
                }
            }
        }


        private void OnEnable() 
        {
            SceneManager.sceneLoaded += OnSceneLoaded;
            SceneManager.sceneUnloaded += OnSceneUnloaded;
        }

        private void OnDisable() 
        {
            SceneManager.sceneLoaded -= OnSceneLoaded;
            SceneManager.sceneUnloaded -= OnSceneUnloaded;
        }

        private void OnSceneLoaded(Scene scene, LoadSceneMode loadMode)
        {
            if(!_loadedScenes.ContainsKey(scene.name))
            {
                _loadedScenes.Add(scene.name, loadMode);
            }
            else
            {
                _loadedScenes[scene.name] = loadMode;
            }
        }

        private void OnSceneUnloaded(Scene scene)
        {
            if(_loadedScenes.ContainsKey(scene.name))
            {
                _loadedScenes.Remove(scene.name);
            }
        }


        public void RequestLoadScene(string sceneName)
        {
            if(!_neededScenes.Contains(sceneName))
            {
                _neededScenes.Add(sceneName);
            }
        }

        public void RequestUnloadScene(string sceneName)
        {
            if(_neededScenes.Contains(sceneName))
            {
                _neededScenes.Remove(sceneName);
            }
        }
    }
}