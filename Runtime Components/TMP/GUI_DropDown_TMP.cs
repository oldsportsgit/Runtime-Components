using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GUI_DropDown_TMP : MonoBehaviour
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
          Dropdown = new GameObject();
          Dropdown.name = "Text (TMP)";
          Dropdown.transform.SetParent(Canvas.transform);
          Dropdown.AddComponent<TMP_Dropdown>(); 
       }
    }
    public GameObject Dropdown;
    public GameObject Canvas;
}
