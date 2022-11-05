using System;
using UnityEngine;

//the asset receiver is just a simplified version of getting a specific file
namespace RuntimeComponents.AssetBundle
{
    public class AssetReceiver
    {
        public static UnityEngine.Object GetAssetInMemoryByName<T>(string name) where T : UnityEngine.Object
        {
            T[] memoryassets = Resources.FindObjectsOfTypeAll(typeof(T)) as T[];
            UnityEngine.Object matvar = null;
            for (int i = 0; i < memoryassets.Length; i++)
            {
                if (memoryassets[i].name == name)
                {
                    matvar = memoryassets[i];
                }
            }
            return matvar;
        }
    }
}
