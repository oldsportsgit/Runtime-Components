using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RuntimeComponents.UI
{
 public class GUI_toggler : MonoBehaviour
 {
    // Start is called before the first frame update
    public static void Toggle(GameObject Canvas, Color ColorOfText)
    {
		  Sprite[] Sprites = Resources.FindObjectsOfTypeAll(typeof(Sprite)) as Sprite[];
          Sprite uisprite = null;
          Sprite checksp = null;
          for (int i = 0; i < Sprites.Length; i++)
		  {
                if (Sprites[i].name == "UISprite")
                {
                    uisprite = Sprites[i];
                }
                if (Sprites[i].name == "Checkmark")
                {
                    checksp = Sprites[i];
                }
          }
          Font[] fonts = Resources.FindObjectsOfTypeAll(typeof(Font)) as Font[];
          Font font = null;
          for (int i = 0; i < fonts.Length; i++)
		  {
                if (fonts[i].name == "Arial")
                {
                   font = fonts[i];
                }
          }
          GameObject Toggle = new GameObject("Toggle", typeof(Toggle));
          GUI_togglers.Add(Toggle);
          Toggle.transform.SetParent(Canvas.transform);
          Toggle.GetComponent<Toggle>().isOn = true;
          Toggle.GetComponent<RectTransform>().sizeDelta = new Vector2 (160, 20);
          GameObject Background = new GameObject("Background", typeof(Image));
          Background.transform.SetParent(Toggle.transform);
          Background.GetComponent<RectTransform>().position = new Vector3(10,-10,0);
          Background.GetComponent<Image>().type = Image.Type.Sliced;
          Background.GetComponent<RectTransform>().sizeDelta = new Vector2 (20, 20);
          Background.GetComponent<Image>().sprite = uisprite;
          Toggle.GetComponent<Toggle>().targetGraphic = Background.GetComponent<Image>();
          Background.GetComponent<RectTransform>().anchorMin = new Vector2 (0, 1);
          Background.GetComponent<RectTransform>().anchorMax = new Vector2 (0, 1);
          GameObject Label = new GameObject("Label", typeof(Text));
          Label.transform.SetParent(Toggle.transform);
          Label.GetComponent<Text>().text = "Toggle";
          Label.GetComponent<Text>().font = font;
          Label.GetComponent<Text>().color = ColorOfText;
          Label.GetComponent<RectTransform>().anchorMin = new Vector2 (0, 0);
          Label.GetComponent<RectTransform>().anchorMax = new Vector2 (1, 1);
          Label.GetComponent<RectTransform>().sizeDelta = new Vector2 (5f, +1f);
          GameObject Checkmark = new GameObject("Checkmark", typeof(Image));
          Checkmark.transform.SetParent(Background.transform);
          Checkmark.GetComponent<Image>().sprite = checksp;
          Checkmark.GetComponent<RectTransform>().offsetMin = new Vector2(-20,-20);
          Checkmark.GetComponent<RectTransform>().offsetMax = new Vector2(0,0);
          Toggle.GetComponent<Toggle>().graphic = Checkmark.GetComponent<Image>();     
          Checkmark.GetComponent<RectTransform>().position = new Vector3(-70,0,0f);  
    }

    public static GameObject GetRootGameObject(int id)
    {
       return GUI_togglers[id];
    }
    private static List<GameObject> GUI_togglers = new List<GameObject>();
 }
}
 