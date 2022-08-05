using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using System.Text;
using System.Linq;
using UnityEngine;

namespace AssetBundle
{
 public class SaveGameObjectAsPrefab : MonoBehaviour
 {
    // Start is called before the first frame update
    void Start()
    {
        string fileName = gameObj.name + ".prefab";
        string LPx = gameObj.transform.localPosition.x.ToString();
        string LPy = gameObj.transform.localPosition.y.ToString();
        string LPz = gameObj.transform.localPosition.z.ToString();
        string LRx = gameObj.transform.localRotation.x.ToString();
        string LRy = gameObj.transform.localRotation.y.ToString();
        string LEAx = gameObj.transform.eulerAngles.x.ToString();
        string LSx = gameObj.transform.localScale.x.ToString();
        string LSy = gameObj.transform.localScale.y.ToString();
        string LSz = gameObj.transform.localScale.z.ToString();

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
                Byte[] GameObj = new UTF8Encoding(true).GetBytes("\nGameObject:\n  m_ObjectHideFlags: 0\n  m_CorrespondingSourceObject: {fileID: 0}" +
                "\n  m_PrefabInstance: {fileID: 0}\n  m_PrefabAsset: {fileID: 0}\n  serializedVersion: 6\n  m_Component:\n  - component: {fileID: 7802531951908947121}\n  m_Layer: " + gameObj.layer + "\n  m_Name: " + gameObj.name +
                "\n  m_TagString: " + gameObj.tag + "\n  m_Icon: { fileID: 0}\n  m_NavMeshLayer: 0\n  m_StaticEditorFlags: 0\n  m_IsActive: "+Convert.ToInt32(gameObj.activeInHierarchy)+ "\n--- !u!4 &7802531951908947121\nTransform:\n  m_ObjectHideFlags: 0\n  m_CorrespondingSourceObject: {fileID: 0}" +
                "\n  m_PrefabInstance: {fileID: 0}\n  m_PrefabAsset: {fileID: 0}\n  m_GameObject: {fileID: 8396258920621007300}\n  m_LocalRotation: {x: "+ LRx.Replace(',', '.') + ", y: "+LRy.Replace(',', '.') +", z: 0, w: 1}\n  m_LocalPosition: {x: "+LPx.Replace(',', '.')+", y: "+LPy.Replace(',', '.')+", z: "+ LPz.Replace(',', '.') + "}" +
                "\n  m_LocalScale: {x: "+LSx.Replace(',', '.')+ ", y: "+LSy.Replace(',', '.')+ ", z: "+LSz.Replace(',', '.')+ "}\n  m_ConstrainProportionsScale: 0\n  m_Children: []\n  m_Father: {fileID: 0}\n  m_RootOrder: 10\n  m_LocalEulerAnglesHint: {x:"+LEAx.Replace(',', '.')+ ", y: 0, z: 0}");
                fs.Write(GameObj, 0, GameObj.Length);
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
        Debug.Log("Saved Sucessfuly at " + Application.dataPath + "/" +fileName);
        Debug.Log(gameObj.transform.childCount);
    }

    public GameObject gameObj;
 }
}
