using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

namespace RuntimeComponents.UI
{
  public class GUI_button_TMP : MonoBehaviour
  {
    public static void Button(GameObject Canvas, Vector2 size, Vector2 Position, string text, Color colorOfText, int fontSize, TextAlignmentOptions align)
    {
          GameObject button = new GameObject("Button", typeof(Image), typeof(Button));
          GUI_Button.Add(button);
		  Sprite[] Sprites = Resources.FindObjectsOfTypeAll(typeof(Sprite)) as Sprite[];
          Sprite sprite = null;
          for (int i = 0; i < Sprites.Length; i++)
		  {
                if (Sprites[i].name == "UISprite")
                {
                    sprite = Sprites[i];
                }
          }
          button.transform.SetParent(Canvas.transform);
          button.GetComponent<Image>().sprite = sprite;
          button.GetComponent<Image>().type = Image.Type.Sliced;
          GameObject GUI_text = new GameObject("Text (TMP)", typeof(TextMeshProUGUI));
          GUI_text.transform.SetParent(button.transform);
          GUI_text.GetComponent<TextMeshProUGUI>().text = text;
          GUI_text.GetComponent<TextMeshProUGUI>().alignment = align;
          button.GetComponent<RectTransform>().sizeDelta = size;
          GUI_text.GetComponent<RectTransform>().anchorMin = new Vector2 (0, 0);
          GUI_text.GetComponent<RectTransform>().anchorMax = new Vector2 (1, 1);
          GUI_text.GetComponent<TextMeshProUGUI>().color = colorOfText; 
          GUI_text.GetComponent<TextMeshProUGUI>().fontSize = fontSize;
          GUI_text.GetComponent<RectTransform>().anchorMax = new Vector2(1,1);
          GUI_text.GetComponent<RectTransform>().anchorMin = new Vector2(0,0);
          GUI_text.GetComponent<RectTransform>().offsetMax = new Vector2(0,0);
          GUI_text.GetComponent<RectTransform>().offsetMin = new Vector2(0,0);
          GUI_text.GetComponent<RectTransform>().anchoredPosition = Position;
    }
        private static List<GameObject> GUI_Button = new List<GameObject>();

        public static GameObject GetRootGameObject(int id)
        {
            return GUI_Button[id];
        }
    }
}
