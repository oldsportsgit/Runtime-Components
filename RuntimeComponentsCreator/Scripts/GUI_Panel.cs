using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RuntimeComponents.UI
{
 public class GUI_Panel : MonoBehaviour
 {
    // Start is called before the first frame update
    public static void Panel(GameObject Canvas, Color colorOfTheImage)
    {
          Sprite[] Sprites = Resources.FindObjectsOfTypeAll(typeof(Sprite)) as Sprite[];
          Sprite sprite = null;
          for (int i = 0; i < Sprites.Length; i++)
		  {
                if (Sprites[i].name == "Background")
                {
                    sprite = Sprites[i];
                }
          }
          GameObject Panel = new GameObject("Panel", typeof(Image));
          GUI_panel.Add(Panel);
          Panel.transform.SetParent(Canvas.transform);
          Panel.GetComponent<Image>().sprite = sprite;
          Panel.GetComponent<Image>().type = Image.Type.Sliced;
          Panel.GetComponent<Image>().color = colorOfTheImage;
          Panel.GetComponent<RectTransform>().anchorMax = new Vector2(1,1);
          Panel.GetComponent<RectTransform>().anchorMin = new Vector2(0,0);
          Panel.GetComponent<RectTransform>().sizeDelta = new Vector2 (0,0);
          Panel.GetComponent<RectTransform>().offsetMax = new Vector2(0,0);
          Panel.GetComponent<RectTransform>().offsetMin = new Vector2(0,0);
    }

    public static GameObject GetRootGameObject(int id)
    {
       return GUI_panel[id];
    }
    private static List<GameObject> GUI_panel = new List<GameObject>();
 }
}
