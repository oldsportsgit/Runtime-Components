using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class text_TMP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       GameObject threeD_text = new GameObject("Text (TMP)", typeof(TextMeshPro));
       threeD_text.GetComponent<TextMeshPro>().text = text;
       threeD_text.GetComponent<TextMeshPro>().color = color;
       threeD_text.GetComponent<TextMeshPro>().alignment = tao;
    }
    public Color color = Color.white;
    public TextAlignmentOptions tao;
    public string text = "Sample text";
}
