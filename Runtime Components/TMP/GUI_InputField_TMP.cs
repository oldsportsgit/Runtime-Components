using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

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
          InputField = new GameObject();
          InputField.name = "InputField (TMP)";
          InputField.transform.SetParent(Canvas.transform);
          InputField.AddComponent<Image>();
          InputField.AddComponent<TMP_InputField>(); 
          Text_area = new GameObject();
          Text_area.name = "Text Area";
          Text_area.transform.SetParent(InputField.transform);
          Text_area.AddComponent<RectMask2D>();
          Placeholder = new GameObject();
          Placeholder.name = "Placeholder";
          Placeholder.transform.SetParent(Text_area.transform);
          Placeholder.AddComponent<TextMeshProUGUI>(); 
          Placeholder.AddComponent<LayoutElement>(); 
          text = new GameObject();
          text.name = "Text";
          text.transform.SetParent(Text_area.transform);
          text.AddComponent<TextMeshProUGUI>(); 
       }
    }
    public GameObject InputField;
    public GameObject Text_area; 
    public GameObject Placeholder; 
    public GameObject text; 
    public GameObject Canvas;
    public Image.Type type;
    public Sprite back;
}
