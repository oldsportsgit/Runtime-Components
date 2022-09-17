using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Reflection;
using System;

namespace RuntimeComponents.UI
{
 public class GUI_InputField_TMP : MonoBehaviour
 {
    public static void InputField(GameObject Canvas)
    {
          Sprite[] Sprites = Resources.FindObjectsOfTypeAll(typeof(Sprite)) as Sprite[];
          Sprite inputfieldbackground = null;
          for (int i = 0; i < Sprites.Length; i++)
		  {
                if (Sprites[i].name == "InputFieldBackground")
                {
                    inputfieldbackground = Sprites[i];
                }
          }
          GameObject InputField = new GameObject("InputField (TMP)", typeof(Image), typeof(TMP_InputField));
          InputField.transform.SetParent(Canvas.transform);
          InputField.GetComponent<Image>().type = Image.Type.Sliced;
          InputField.GetComponent<Image>().sprite = inputfieldbackground;
          InputField.GetComponent<RectTransform>().sizeDelta = new Vector2 (160, 30);
          GameObject Text_area = new GameObject("Text Area", typeof(RectMask2D));
          Text_area.transform.SetParent(InputField.transform);
          Text_area.GetComponent<RectTransform>().anchorMax = new Vector2(1,1);
          Text_area.GetComponent<RectTransform>().anchorMin = new Vector2(0,0);
          Text_area.GetComponent<RectTransform>().anchoredPosition = new Vector2(+0, -1);
          Text_area.GetComponent<RectTransform>().sizeDelta = new Vector2 (-20, -12);
          GameObject Placeholder = new GameObject("Placeholder", typeof(TextMeshProUGUI), typeof(LayoutElement));
          Placeholder.transform.SetParent(Text_area.transform);
          Placeholder.GetComponent<LayoutElement>().ignoreLayout = true;
          Placeholder.GetComponent<RectTransform>().anchorMax = new Vector2(1,1);
          Placeholder.GetComponent<RectTransform>().anchorMin = new Vector2(0,0);
          Placeholder.GetComponent<RectTransform>().offsetMax = new Vector2(0,0);
          Placeholder.GetComponent<RectTransform>().offsetMin = new Vector2(0,0);
          Placeholder.GetComponent<TextMeshProUGUI>().text = "Enter text..."; 
          Placeholder.GetComponent<TextMeshProUGUI>().enableWordWrapping = false;
          Placeholder.GetComponent<TextMeshProUGUI>().fontSize = 14;
          Placeholder.GetComponent<TextMeshProUGUI>().fontStyle = FontStyles.Italic;
          Placeholder.GetComponent<TextMeshProUGUI>().color = new Color(0f, 0f, 0f, 0.5f);
          GameObject text = new GameObject("Text", typeof(TextMeshProUGUI));
          text.transform.SetParent(Text_area.transform);
          text.GetComponent<RectTransform>().anchorMax = new Vector2(1,1);
          text.GetComponent<RectTransform>().anchorMin = new Vector2(0,0);
          text.GetComponent<RectTransform>().offsetMax = new Vector2(0,0);
          text.GetComponent<RectTransform>().offsetMin = new Vector2(0,0);
          text.GetComponent<TextMeshProUGUI>().fontSize = 14;
          text.GetComponent<TextMeshProUGUI>().color = Color.black;
          InputField.GetComponent<TMP_InputField>().textViewport = Text_area.GetComponent<RectTransform>();
          InputField.GetComponent<TMP_InputField>().textComponent = text.GetComponent<TextMeshProUGUI>();
          InputField.GetComponent<TMP_InputField>().fontAsset = text.GetComponent<TextMeshProUGUI>().font;
          InputField.GetComponent<TMP_InputField>().placeholder = Placeholder.GetComponent<TextMeshProUGUI>();
    } 

    private static List<GameObject> GUI_tmpinputfield = new List<GameObject>();

    public static GameObject GetRootGameObject(int id)
    {
        return GUI_tmpinputfield[id];
    }
 }
}
