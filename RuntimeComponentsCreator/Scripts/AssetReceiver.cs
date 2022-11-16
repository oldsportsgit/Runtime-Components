using System;
using System.Collections.Generic;
using UnityEngine;

//the asset receiver is just a simplified version of getting a specific file
namespace RuntimeComponents.AssetBundle
{
    public class AssetReceiver
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
    }
}
