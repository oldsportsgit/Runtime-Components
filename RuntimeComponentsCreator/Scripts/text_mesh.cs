using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ThreeD
{
 public class text_mesh : MonoBehaviour
 {
    // Start is called before the first frame update
    public static void Text(Vector3 Position, Vector3 Rotation, Vector3 Scale, string text, int FontSize, Color ColorOfText, TextAlignment Alignment, float CharacterSize)
    {
       GameObject textmesh = new GameObject("New Text", typeof(TextMesh));
       textmesh.GetComponent<TextMesh>().text = text;
       textmesh.GetComponent<TextMesh>().fontSize = FontSize;
       textmesh.GetComponent<TextMesh>().color = ColorOfText;
       textmesh.GetComponent<TextMesh>().alignment = Alignment;
       textmesh.GetComponent<TextMesh>().characterSize = CharacterSize;
       textmesh.GetComponent<TextMesh>().anchor = TextAnchor.MiddleCenter;
       textmesh.GetComponent<MeshRenderer>().allowOcclusionWhenDynamic = false;
       textmesh.GetComponent<Transform>().position = Position;
       textmesh.GetComponent<Transform>().eulerAngles = Rotation;
       textmesh.GetComponent<Transform>().localScale = Scale;
    }
 }
}
