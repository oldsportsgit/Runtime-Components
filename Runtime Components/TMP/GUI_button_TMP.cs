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
          button = new GameObject();
          button.name = "Button";
          button.transform.SetParent(Canvas.transform);
          button.AddComponent<Image>(); 
          button.AddComponent<Button>(); 
          GUI_text = new GameObject();
          GUI_text.name = "Text (TMP)";
          GUI_text.transform.SetParent(button.transform);
          GUI_text.AddComponent<TextMeshProUGUI>(); 
          GUI_text.GetComponent<TextMeshProUGUI>().text = text;
          GUI_text.GetComponent<TextMeshProUGUI>().alignment = align;
          button.GetComponent<RectTransform>().sizeDelta = size;
          GUI_text.GetComponent<RectTransform>().anchorMin = new Vector2 (0, 0);
          GUI_text.GetComponent<RectTransform>().anchorMax = new Vector2 (1, 1);
          GUI_text.GetComponent<TextMeshProUGUI>().color = color_of_text;
       }
    }
    public GameObject button;
    public GameObject GUI_text;
    public GameObject Canvas;
    public string text;
    public TextAlignmentOptions align;
    public Color color_of_text;
    public Vector2 size = new Vector2 (160, 30);
}
