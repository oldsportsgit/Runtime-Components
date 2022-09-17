using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RuntimeComponents.UI
{
 public class GUI_ScrollView : MonoBehaviour
 {
    //public static void ScrollView(GameObject Canvas)
	public void Start()
    {
	      GameObject Canvas = GameObject.Find("Canvas");
          Sprite[] Sprites = Resources.FindObjectsOfTypeAll(typeof(Sprite)) as Sprite[];
          Sprite backgroundsp = null;
          Sprite uimasksp = null;
          Sprite uispritesp = null;
          for (int i = 0; i < Sprites.Length; i++)
		  {
                if (Sprites[i].name == "Background")
                {
                    backgroundsp = Sprites[i];
                }
                if (Sprites[i].name == "UIMask")
                {
                    uimasksp = Sprites[i];
                }
                if (Sprites[i].name == "UISprite")
                {
                    uispritesp = Sprites[i];
                }
          }
          GameObject scrollView = new GameObject("Scroll View", typeof(Image), typeof(ScrollRect));
          GUI_scrollviews.Add(scrollView);
          scrollView.transform.SetParent(Canvas.transform);
          scrollView.GetComponent<Image>().type = Image.Type.Sliced;
          scrollView.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.4f);
          scrollView.GetComponent<RectTransform>().sizeDelta = new Vector2 (200, 200);
          scrollView.GetComponent<Image>().sprite = backgroundsp;
          GameObject Viewport = new GameObject("Viewport", typeof(Image), typeof(Mask));
          Viewport.GetComponent<RectTransform>().pivot = new Vector2(0,1);
          Viewport.transform.SetParent(scrollView.transform);
          Viewport.GetComponent<Image>().sprite = uimasksp;
          Viewport.GetComponent<Image>().type = Image.Type.Sliced;
          Viewport.GetComponent<Mask>().showMaskGraphic = false;
          GameObject Content = new GameObject("Content", typeof(RectTransform)); 
          Content.GetComponent<RectTransform>().sizeDelta = new Vector2(+100,+300);
          Content.GetComponent<RectTransform>().anchorMin = new Vector2(0,1);
          Content.GetComponent<RectTransform>().anchorMax = new Vector2(1,1);
          Content.GetComponent<RectTransform>().pivot = new Vector2(0,1);
          Content.transform.SetParent(Viewport.transform);
          GameObject ScrollbarH = new GameObject("Scrollbar Horizontal", typeof(Image), typeof(Scrollbar));
          ScrollbarH.transform.SetParent(scrollView.transform);
          GameObject slidingArea = new GameObject("Sliding Area", typeof(RectTransform));
          slidingArea.transform.SetParent(ScrollbarH.transform);
          GameObject handle = new GameObject("Handle", typeof(Image));
          handle.GetComponent<Image>().type = Image.Type.Sliced;
          handle.GetComponent<Image>().sprite = uispritesp;
          handle.transform.SetParent(slidingArea.transform);
          handle.GetComponent<RectTransform>().sizeDelta = new Vector2 (20, 20);
          GameObject ScrollbarV = new GameObject("Scrollbar Vertical", typeof(Image), typeof(Scrollbar));
          ScrollbarV.transform.SetParent(scrollView.transform);
          ScrollbarV.GetComponent<RectTransform>().sizeDelta = new Vector2(20,0);
          ScrollbarV.GetComponent<RectTransform>().anchorMin = new Vector2(1,0);
          ScrollbarV.GetComponent<RectTransform>().anchorMax = new Vector2(1,0);
          ScrollbarV.GetComponent<RectTransform>().pivot = new Vector2(1,1);
          GameObject slidingAreaV = new GameObject("Sliding Area", typeof(RectTransform));
		  slidingAreaV.GetComponent<RectTransform>().anchoredPosition = new Vector2(+35,30);
          slidingAreaV.GetComponent<RectTransform>().sizeDelta = new Vector2 (+250, +90);
          slidingAreaV.transform.SetParent(ScrollbarV.transform);
          GameObject handle1 = new GameObject("Handle", typeof(Image));
          handle1.GetComponent<Image>().type = Image.Type.Sliced;
          handle1.GetComponent<Image>().sprite = uispritesp;
          handle1.transform.SetParent(slidingAreaV.transform);
          slidingAreaV.GetComponent<RectTransform>().anchorMin = new Vector2 (0, 0);
          slidingAreaV.GetComponent<RectTransform>().anchorMax = new Vector2 (1, 1);
          scrollView.GetComponent<ScrollRect>().content = Content.GetComponent<RectTransform>();
          scrollView.GetComponent<ScrollRect>().viewport = Viewport.GetComponent<RectTransform>();
          scrollView.GetComponent<ScrollRect>().horizontalScrollbar = ScrollbarH.GetComponent<Scrollbar>();
          scrollView.GetComponent<ScrollRect>().verticalScrollbar = ScrollbarV.GetComponent<Scrollbar>();
          scrollView.GetComponent<ScrollRect>().horizontalScrollbarVisibility = ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport;
          scrollView.GetComponent<ScrollRect>().verticalScrollbarVisibility = ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport;
          scrollView.GetComponent<ScrollRect>().horizontalScrollbarSpacing = -3;
          scrollView.GetComponent<ScrollRect>().verticalScrollbarSpacing = -3;
          ScrollbarH.GetComponent<Scrollbar>().handleRect = handle.GetComponent<RectTransform>();
          ScrollbarV.GetComponent<Scrollbar>().handleRect = handle1.GetComponent<RectTransform>();
          ScrollbarH.GetComponent<Image>().sprite = scrollView.GetComponent<Image>().sprite;
          ScrollbarV.GetComponent<Image>().sprite = scrollView.GetComponent<Image>().sprite;
          ScrollbarV.GetComponent<Image>().type = Image.Type.Sliced;
          ScrollbarV.GetComponent<Scrollbar>().targetGraphic = handle1.GetComponent<Image>();
          ScrollbarV.GetComponent<Scrollbar>().direction = Scrollbar.Direction.BottomToTop;
    }

    public static GameObject GetRootGameObject(int id)
    {
       return GUI_scrollviews[id];
    }

    private static List<GameObject> GUI_scrollviews = new List<GameObject>();
 }
}
