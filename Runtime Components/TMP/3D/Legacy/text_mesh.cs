using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text_mesh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       textmesh = new GameObject();
       textmesh.name = "New Text";
       textmesh.AddComponent<TextMesh>(); 
       textmesh.GetComponent<TextMesh>().text = text;
    }
    public GameObject textmesh;
    public string text;
}
