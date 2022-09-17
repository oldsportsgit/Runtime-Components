using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RuntimeComponents.UI
{
 public class GUI_slider : MonoBehaviour
 {
    // Start is called before the first frame update
    public static void Slider(GameObject Canvas)
    {
          Sprite[] Sprites = Resources.FindObjectsOfTypeAll(typeof(Sprite)) as Sprite[];
          Sprite background = null;
          Sprite UIsprite = null;
          Sprite Knobsp = null;
          for (int i = 0; i < Sprites.Length; i++)
		  {
                if (Sprites[i].name == "Background")
                {
                    background = Sprites[i];
                }
                if (Sprites[i].name == "UISprite")
                {
                    UIsprite = Sprites[i];
                }
                if (Sprites[i].name == "Knob")
                {
                    Knobsp = Sprites[i];
                }
            }
          GameObject Slider = new GameObject("Slider", typeof(Slider));
          GUI_Sliders.Add(Slider);
          Slider.transform.SetParent(Canvas.transform);
          Slider.GetComponent<RectTransform>().sizeDelta = new Vector2 (160, 20);
          GameObject Background = new GameObject("Background", typeof(Image));
          Background.transform.SetParent(Slider.transform);
          Background.GetComponent<Image>().sprite = background;
          Background.GetComponent<RectTransform>().anchorMin = new Vector2 (0f, 0.25f);
          Background.GetComponent<RectTransform>().anchorMax = new Vector2 (1f, 0.75f);
          Background.GetComponent<RectTransform>().sizeDelta = new Vector2 (0, 0);
          Background.GetComponent<Image>().type = Image.Type.Sliced;
          GameObject Fill_Area = new GameObject("Fill Area", typeof(RectTransform));
          Fill_Area.transform.SetParent(Slider.transform);
          Fill_Area.GetComponent<RectTransform>().anchorMin = new Vector2 (0f, 0.25f);
          Fill_Area.GetComponent<RectTransform>().anchorMax = new Vector2 (1f, 0.75f);
          Fill_Area.GetComponent<RectTransform>().sizeDelta = new Vector2 (-20f, 0);
          Fill_Area.GetComponent<RectTransform>().position = new Vector3(-5,0,0);
          GameObject Fill = new GameObject("Fill", typeof(Image));
          Fill.GetComponent<Image>().type = Image.Type.Sliced;
          Fill.GetComponent<Image>().sprite = UIsprite;
          Slider.GetComponent<Slider>().fillRect = Fill.GetComponent<RectTransform>();
          Fill.transform.SetParent(Fill_Area.transform);
          Fill.GetComponent<RectTransform>().position = new Vector3(-5,0,0);
          Fill.GetComponent<RectTransform>().sizeDelta = new Vector2 (10, 0);
          GameObject Handle_Slide_Area = new GameObject("Handle Slide Area", typeof(RectTransform));
          Handle_Slide_Area.transform.SetParent(Slider.transform);
          Handle_Slide_Area.GetComponent<RectTransform>().anchorMin = new Vector2 (0f, 0f);
          Handle_Slide_Area.GetComponent<RectTransform>().anchorMax = new Vector2 (1f, 1f);
          Handle_Slide_Area.GetComponent<RectTransform>().sizeDelta = new Vector2 (-20,0);
          Handle_Slide_Area.GetComponent<RectTransform>().position = new Vector3(0,0,0);
          GameObject Handle = new GameObject("Handle", typeof(Image));
          Handle.transform.SetParent(Handle_Slide_Area.transform);
          Handle.GetComponent<Image>().sprite = Knobsp;
          Handle.GetComponent<RectTransform>().localPosition = new Vector3(0,0,0); 
          Handle.GetComponent<RectTransform>().sizeDelta = new Vector2 (20,0);
          Slider.GetComponent<Slider>().handleRect = Handle.GetComponent<RectTransform>();
          Slider.GetComponent<Slider>().targetGraphic = Handle.GetComponent<Image>();
    }

    public static GameObject GetRootGameObject(int id)
    {
       return GUI_Sliders[id];
    }
    private static List<GameObject> GUI_Sliders = new List<GameObject>();
 }
}
