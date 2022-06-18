using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GUI_button_TMP : MonoBehaviour
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
          GameObject button = new GameObject();
          button.name = "Button";
          button.transform.SetParent(Canvas.transform);
          button.AddComponent<Image>(); 
          button.AddComponent<Button>(); 
          GameObject GUI_text = new GameObject();
          GUI_text.name = "Text (TMP)";
          GUI_text.transform.SetParent(button.transform);
          GUI_text.AddComponent<TextMeshProUGUI>(); 
          GUI_text.GetComponent<TextMeshProUGUI>().text = text;
          GUI_text.GetComponent<TextMeshProUGUI>().alignment = align;
          button.GetComponent<RectTransform>().sizeDelta = size;
          GUI_text.GetComponent<RectTransform>().anchorMin = new Vector2 (0, 0);
          GUI_text.GetComponent<RectTransform>().anchorMax = new Vector2 (1, 1);
          GUI_text.GetComponent<TextMeshProUGUI>().color = colorOfText; 
          GUI_text.GetComponent<TextMeshProUGUI>().fontSize = fontSize;
       }
    }
    public GameObject Canvas;
    public string text = "Button";
    public int fontSize = 24;
    public TextAlignmentOptions align = TextAlignmentOptions.Center;
    public Color colorOfText = Color.black;
    public Vector2 size = new Vector2 (160, 30);
}
