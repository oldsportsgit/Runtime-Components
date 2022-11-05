using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using System.Text;
using System.Reflection;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace RuntimeComponents
{
    public class SaveGameObject : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            childObjects = gameObj.GetComponentsInChildren<Transform>();
            childObjects = childObjects.Where((val, idx) => idx != 0).ToArray();
            string fileName = "";
            switch (saveAs)
            {
                case SaveGameObject.SaveAs.Prefab:
                    {
                        fileName = gameObj.name + ".prefab";
                        break;
                    }
                case SaveGameObject.SaveAs.UnityScene:
                    {
                        fileName = gameObj.name + ".unity";
                        break;
                    }
                default: break;
            }

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                // Create a new Prefab    
                using (FileStream fs = File.Create(fileName))
                {
                    Byte[] Base = new UTF8Encoding(true).GetBytes("%YAML 1.1\n%TAG !u! tag:unity3d.com,2011:\n--- !u!1 &8396258920621007300");
                    fs.Write(Base, 0, Base.Length);
                    GameObjectWritter(fs, gameObj);
                }

                // Open the stream and read it back.    
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
            if (File.Exists(fileName))
            {
                Debug.Log("Saved Sucessfuly at " + Application.dataPath + "/" + fileName);
            }
            Debug.Log(gameObj.transform.childCount);
        }
        public GameObject gameObj;
        public Transform[] childObjects;
        public SaveGameObject.SaveAs saveAs;

        public void GameObjectWritter(FileStream fs, GameObject gameObject)
        {
            string LPx = gameObject.transform.localPosition.x.ToString();
            string LPy = gameObject.transform.localPosition.y.ToString();
            string LPz = gameObject.transform.localPosition.z.ToString();
            string LRx = gameObject.transform.localRotation.x.ToString();
            string LRy = gameObject.transform.localRotation.y.ToString();
            string LEAx = gameObject.transform.eulerAngles.x.ToString();
            string LEAy = gameObject.transform.eulerAngles.y.ToString();
            string LEAz = gameObject.transform.eulerAngles.z.ToString();
            string LSx = gameObject.transform.localScale.x.ToString();
            string LSy = gameObject.transform.localScale.y.ToString();
            string LSz = gameObject.transform.localScale.z.ToString();
            MonoBehaviour[] gamj = gameObject.GetComponentsInChildren<MonoBehaviour>();
            Debug.Log(gamj.Length);
            if (gameObject.transform.childCount > 0)
            {
                for(int i = 0; i < gameObject.transform.childCount; i++)
                {

                }
            }
            Byte[] GameObj = new UTF8Encoding(true).GetBytes("\nGameObject:\n  m_ObjectHideFlags: 0\n  m_CorrespondingSourceObject: {fileID: 0}" +
            "\n  m_PrefabInstance: {fileID: 0}\n  m_PrefabAsset: {fileID: 0}\n  serializedVersion: 6\n  m_Component:\n  - component: {fileID: 7802531951908947121}\n  m_Layer: " + gameObject.layer + "\n  m_Name: " + gameObject.name +
            "\n  m_TagString: " + gameObject.tag + "\n  m_Icon: { fileID: 0}\n  m_NavMeshLayer: 0\n  m_StaticEditorFlags: 0\n  m_IsActive: " + Convert.ToInt32(gameObject.activeInHierarchy) + "\n--- !u!4 &7802531951908947121\nTransform:\n  m_ObjectHideFlags: 0\n  m_CorrespondingSourceObject: {fileID: 0}" +
            "\n  m_PrefabInstance: {fileID: 0}\n  m_PrefabAsset: {fileID: 0}\n  m_GameObject: {fileID: 8396258920621007300}\n  m_LocalRotation: {x: " + LRx.Replace(',', '.') + ", y: " + LRy.Replace(',', '.') + ", z: 0, w: 1}\n  m_LocalPosition: {x: " + LPx.Replace(',', '.') + ", y: " + LPy.Replace(',', '.') + ", z: " + LPz.Replace(',', '.') + "}" +
            "\n  m_LocalScale: {x: " + LSx.Replace(',', '.') + ", y: " + LSy.Replace(',', '.') + ", z: " + LSz.Replace(',', '.') + "}\n  m_ConstrainProportionsScale: 0\n  m_Children: []\n  m_Father: {fileID: 0}\n  m_RootOrder: 10\n  m_LocalEulerAnglesHint: {x: " + LEAx.Replace(',', '.') + ", y: " + LEAy.Replace(',', '.') + ", z: " + LEAz.Replace(',', '.') + "}");
            fs.Write(GameObj, 0, GameObj.Length);
        }
        public enum SaveAs
        {
            UnityScene,
            Prefab
        }
    }
}
