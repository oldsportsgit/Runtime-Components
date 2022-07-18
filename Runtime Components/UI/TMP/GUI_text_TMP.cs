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
          GameObject GUI_text = new GameObject("Text (TMP)", typeof(TextMeshProUGUI));
          GUI_text.transform.SetParent(Canvas.transform);
          GUI_text.GetComponent<TextMeshProUGUI>().text = text;
          GUI_text.GetComponent<TextMeshProUGUI>().alignment = align;
          GUI_text.GetComponent<TextMeshProUGUI>().color = colorOfText;
          GUI_text.GetComponent<TextMeshProUGUI>().fontSize = fontSize;
       }
    }
    public GameObject Canvas;
    public string text = "New Text";
    public Color colorOfText = Color.white;
    public int fontSize = 36;
    public TextAlignmentOptions align = TextAlignmentOptions.Left;
}
