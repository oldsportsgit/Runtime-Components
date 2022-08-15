using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace RuntimeComponents.UI
{
 public class GUI_text_TMP : MonoBehaviour
 {
    // Start is called before the first frame update
    public static void text_TMP(GameObject Canvas, Vector2 position, string text, Color colorOfText, int fontSize, TextAlignmentOptions align)
    {
          GameObject GUI_text = new GameObject("Text (TMP)", typeof(TextMeshProUGUI));
          GUI_text.transform.SetParent(Canvas.transform);
          GUI_text.GetComponent<TextMeshProUGUI>().text = text;
          GUI_text.GetComponent<TextMeshProUGUI>().alignment = align;
          GUI_text.GetComponent<TextMeshProUGUI>().color = colorOfText;
          GUI_text.GetComponent<TextMeshProUGUI>().fontSize = fontSize;
          GUI_text.GetComponent<RectTransform>().anchoredPosition = position;
    }
 }
}
