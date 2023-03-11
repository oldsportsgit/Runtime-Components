using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RuntimeConstructers
{
    public class UnityObject : UnityEngine.Object
    {
        public static T GetAssetInMemoryByName<T>(string name) where T : UnityEngine.Object
        {
            T[] memoryassets = Resources.FindObjectsOfTypeAll(typeof(T)) as T[];
            T matvar = null;
            for (int i = 0; i < memoryassets.Length; i++)
            {
                if (memoryassets[i].name == name)
                {
                    matvar = memoryassets[i];
                }
            }
            return matvar;
        }

        public static GameObject[] GetAllPrefabs()
        {
            GameObject[] prefabs = Resources.FindObjectsOfTypeAll<GameObject>();
            List<GameObject> cprefabs = new List<GameObject>();
            for (int i = 0; i < prefabs.Length; i++)
            {
                if (!prefabs[i].scene.IsValid() & prefabs[i].transform.parent == null)
                {
                    cprefabs.Add(prefabs[i]);
                }
            }
            return cprefabs.ToArray();
        }

        public static GameObject FindChildGameObjectByName(GameObject gameObject, string name)
        {
            Transform[] children = gameObject.GetComponentsInChildren<Transform>();
            foreach (Transform transform in children)
            {
                if (transform.name == name)
                {
                    return transform.gameObject;
                }
            }
            return null;
        }

        public static void CreateScene(string SceneName, bool IsBlankScene)
        {
            Scene newScene = SceneManager.CreateScene(SceneName);
            SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
            SceneManager.SetActiveScene(SceneManager.GetSceneByName(SceneName));
            if (!IsBlankScene)
            {
                GameObject MainCamera = new GameObject("Main Camera", typeof(Camera), typeof(AudioListener));
                GameObject DirectionalLight = new GameObject("Directional Light", typeof(Light));
                RenderSettings.sun = DirectionalLight.GetComponent<Light>();
                DirectionalLight.GetComponent<Light>().type = LightType.Directional;
                DirectionalLight.GetComponent<Transform>().localEulerAngles = new Vector3(50, -30, 0);
            }
        }

        public static void CreateScene(string SceneName,bool IsBlankScene, params GameObject[] GameObjectsToAdd)
        {
            CreateScene(SceneName, IsBlankScene);
            for (int i = 0; i < GameObjectsToAdd.Length; i++)
            {
                UnityEngine.Object.Instantiate(GameObjectsToAdd[i]);
            }
        }
    }
}
