using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text_mesh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       GameObject textmesh = new GameObject("New Text", typeof(TextMesh));
       textmesh.GetComponent<TextMesh>().text = text;
       textmesh.GetComponent<TextMesh>().fontSize = FontSize;
       textmesh.GetComponent<TextMesh>().color = ColorOfText;
       textmesh.GetComponent<TextMesh>().alignment = Alignment;
       textmesh.GetComponent<TextMesh>().characterSize = CharacterSize;
       textmesh.GetComponent<TextMesh>().anchor = TextAnchor.MiddleCenter;
       textmesh.GetComponent<MeshRenderer>().allowOcclusionWhenDynamic = false;
    }
    public string text = "Hello World";
    public int FontSize;
    public Color ColorOfText = Color.white;
    public TextAlignment Alignment;
    public float CharacterSize = 1;
}
