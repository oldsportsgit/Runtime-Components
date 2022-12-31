using System;
using System.IO;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace RuntimeConstructers
{
    public class SaveGameObject : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            List<Transform> ss = gameobject.GetComponentsInChildren<Transform>(true).ToList();
            string text = "First line" + Environment.NewLine;
            string docPath = Application.dataPath;
            File.WriteAllText(Path.Combine(docPath, "WriteFile.txt"), text);
            List<string> lines = new List<string>();
            foreach (Transform t in ss)
            {
                lines.Add(t.name);
            }
            File.AppendAllLines(Path.Combine(docPath, "WriteFile.txt"), lines);

            string fileName = "99";
            switch (saveAs)
            {
                case SaveGameObject.SaveAs.Prefab:
                    {
                        fileName = gameobject.name + ".prefab";
                        break;
                    }
                case SaveGameObject.SaveAs.UnityScene:
                    {
                        fileName = gameobject.name + ".unity";
                        break;
                    }
                default: break;
            }
        }

        public SaveAs saveAs;
        public GameObject gameobject;
        public enum SaveAs
        {
            UnityScene,
            Prefab
        }
    }
}
