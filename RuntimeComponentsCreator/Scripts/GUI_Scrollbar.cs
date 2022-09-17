using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RuntimeComponents.UI
{
 public class GUI_Scrollbar : MonoBehaviour
 {
    // Start is called before the first frame update
    public static void Slider(GameObject Canvas, Vector2 size, Vector2 position)
    {
          Sprite[] Sprites = Resources.FindObjectsOfTypeAll(typeof(Sprite)) as Sprite[];
          Sprite background = null;
          Sprite UIsprite = null;
          for (int i = 0; i < Sprites.Length; i++)
		  {
                if (Sprites[i].name == "UISprite")
                {
                    UIsprite = Sprites[i];
                }
                if (Sprites[i].name == "Background")
                {
                    background = Sprites[i];
                }
            }
          GameObject scrollbar = new GameObject("Scrollbar", typeof(Image), typeof(Scrollbar));
          GUI_scroolbars.Add(scrollbar);
          scrollbar.transform.SetParent(Canvas.transform);
          scrollbar.GetComponent<Image>().type = Image.Type.Sliced;
          scrollbar.GetComponent<RectTransform>().sizeDelta = size;
          scrollbar.GetComponent<RectTransform>().anchoredPosition = position;
          scrollbar.GetComponent<Image>().sprite = background;
          GameObject slidingArea = new GameObject("Sliding Area", typeof(RectTransform));
          slidingArea.transform.SetParent(scrollbar.transform);
          slidingArea.GetComponent<RectTransform>().anchorMin = new Vector2 (0, 0);
          slidingArea.GetComponent<RectTransform>().anchorMax = new Vector2 (1, 1);
          slidingArea.GetComponent<RectTransform>().sizeDelta = new Vector2 (-20, -20);
          GameObject handle = new GameObject("Handle", typeof(Image));
          handle.GetComponent<Image>().type = Image.Type.Sliced;
          handle.GetComponent<Image>().sprite = UIsprite;
          handle.transform.SetParent(slidingArea.transform);
          handle.GetComponent<RectTransform>().sizeDelta = new Vector2 (20, 20);
          scrollbar.GetComponent<Scrollbar>().handleRect = handle.GetComponent<RectTransform>();
    }

    public static GameObject GetRootGameObject(int id)
    {
       return GUI_scroolbars[id];
    }
    private static List<GameObject> GUI_scroolbars = new List<GameObject>();
 }
}
