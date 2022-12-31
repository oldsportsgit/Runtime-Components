using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace RuntimeConstructers
{
    public class ThreeD
    {
        public static GameObject TextTMPro(string name, Vector3 position, string text)
        {
            GameObject threeD_text = new GameObject(name, typeof(TextMeshPro));
            threeD_text.GetComponent<TextMeshPro>().text = text;
            threeD_text.GetComponent<Transform>().position = position;
            return threeD_text;
        }

        public static GameObject TextMesh(string name, Vector3 Position, string text)
        {
            GameObject textmesh = new GameObject(name, typeof(TextMesh));
            textmesh.GetComponent<TextMesh>().text = text;
            textmesh.GetComponent<MeshRenderer>().allowOcclusionWhenDynamic = false;
            textmesh.GetComponent<Transform>().position = Position;
            return textmesh;
        }
    }
}
