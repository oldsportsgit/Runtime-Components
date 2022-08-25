using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace RuntimeComponents.UI
{
 public class GUI_text_TMP : MonoBehaviour
 {
    // Start is called before the first frame update
    public static void text_TMP(GameObject Canvas, Vector2 position, string text, Color colorOfText, int fontSize, TextAlignmentOptions align, int id)
    {         
          GameObject gobj = new GameObject("Text (TMP)", typeof(TextMeshProUGUI));
          GUI_text.Add(gobj);
          GUI_text[id].transform.SetParent(Canvas.transform);
          GUI_text[id].GetComponent<TextMeshProUGUI>().text = text;
          GUI_text[id].GetComponent<TextMeshProUGUI>().alignment = align;
          GUI_text[id].GetComponent<TextMeshProUGUI>().color = colorOfText;
          GUI_text[id].GetComponent<TextMeshProUGUI>().fontSize = fontSize;
          GUI_text[id].GetComponent<RectTransform>().anchoredPosition = position;
    }

    public static void Change(GameObject Canvas, Vector2 position, string text, Color colorOfText, int fontSize, TextAlignmentOptions align, int id)
    {
          GUI_text[id].transform.SetParent(Canvas.transform);
          GUI_text[id].GetComponent<TextMeshProUGUI>().text = text;
          GUI_text[id].GetComponent<TextMeshProUGUI>().alignment = align;
          GUI_text[id].GetComponent<TextMeshProUGUI>().color = colorOfText;
          GUI_text[id].GetComponent<TextMeshProUGUI>().fontSize = fontSize;
          GUI_text[id].GetComponent<RectTransform>().anchoredPosition = position;
    }
    private static List<GameObject> GUI_text = new List<GameObject>();
 }
}
