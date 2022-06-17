using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class text_TMP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       threeD_text = new GameObject();
       threeD_text.name = "Text (TMP)";
       threeD_text.AddComponent<TextMeshPro>(); 
       threeD_text.GetComponent<TextMeshPro>().text = text;
    }
    public GameObject threeD_text;
    public string text;
}
