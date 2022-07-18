using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Reflection;
using System;

public class GUI_InputField_TMP : MonoBehaviour
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
          GameObject InputField = new GameObject();
          InputField.name = "InputField (TMP)";
          InputField.transform.SetParent(Canvas.transform);
          InputField.AddComponent<Image>();
          InputField.GetComponent<Image>().type = Type;
          InputField.GetComponent<RectTransform>().sizeDelta = size;
          InputField.AddComponent<TMP_InputField>(); 
          GameObject Text_area = new GameObject();
          Text_area.name = "Text Area";
          Text_area.transform.SetParent(InputField.transform);
          Text_area.AddComponent<RectMask2D>();
          Text_area.GetComponent<RectMask2D>().rectTransform.anchorMax = new Vector2(1,1);
          Text_area.GetComponent<RectMask2D>().rectTransform.anchorMin = new Vector2(0,0);
          Text_area.GetComponent<RectMask2D>().rectTransform.offsetMax = new Vector2(10,-7);
          Text_area.GetComponent<RectMask2D>().rectTransform.offsetMin = new Vector2(10,-6);
          Text_area.GetComponent<RectMask2D>().rectTransform.anchoredPosition = new Vector2(10, 7);
          GameObject Placeholder = new GameObject();
          Placeholder.name = "Placeholder";
          Placeholder.transform.SetParent(Text_area.transform);
          Placeholder.AddComponent<TextMeshProUGUI>(); 
          Placeholder.AddComponent<LayoutElement>(); 
          Placeholder.GetComponent<RectTransform>().anchorMax = new Vector2(1,1);
          Placeholder.GetComponent<RectTransform>().anchorMin = new Vector2(0,0);
          Placeholder.GetComponent<TextMeshProUGUI>().text = "Enter text..."; 
          GameObject text = new GameObject();
          text.name = "Text";
          text.transform.SetParent(Text_area.transform);
          text.AddComponent<TextMeshProUGUI>(); 
          text.GetComponent<RectTransform>().anchorMax = new Vector2(1,1);
          text.GetComponent<RectTransform>().anchorMin = new Vector2(0,0);
          text.GetComponent<RectTransform>().offsetMax = new Vector2(0,0);
          text.GetComponent<RectTransform>().offsetMin = new Vector2(0,0);
       }
    } 
    public GameObject Canvas;
    public Image.Type Type;
    public Vector2 size = new Vector2 (160, 30);
}
