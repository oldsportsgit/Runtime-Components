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
          GameObject TMPtext = new GameObject("Text (TMP)", typeof(TextMeshProUGUI));
          GUI_text.Add(TMPtext);
          TMPtext.transform.SetParent(Canvas.transform);
          TMPtext.GetComponent<TextMeshProUGUI>().text = text;
          TMPtext.GetComponent<TextMeshProUGUI>().alignment = align;
          TMPtext.GetComponent<TextMeshProUGUI>().color = colorOfText;
          TMPtext.GetComponent<TextMeshProUGUI>().fontSize = fontSize;
          TMPtext.GetComponent<RectTransform>().anchoredPosition = position;
    }

    public static GameObject GetRootGameObject(int id)
    {
       return GUI_text[id];
    }
    private static List<GameObject> GUI_text = new List<GameObject>();
 }
}