using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GUI_text_TMP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       if(Canvas == null)
       {
          Debug.LogError("Canvas cannot be null");
       }
       else 
       {
          GUI_text = new GameObject();
          GUI_text.name = "Text (TMP)";
          GUI_text.transform.SetParent(Canvas.transform);
          GUI_text.AddComponent<TextMeshProUGUI>(); 
          GUI_text.GetComponent<TextMeshProUGUI>().text = text;
          GUI_text.GetComponent<TextMeshProUGUI>().alignment = align;
          GUI_text.GetComponent<TextMeshProUGUI>().color = color_of_text;
          GUI_text.GetComponent<TextMeshProUGUI>().fontSize = font_size;
       }
    }
    public GameObject GUI_text;
    public GameObject Canvas;
    public string text;
    public Color color_of_text;
    public int font_size;
    public TextAlignmentOptions align;
}
