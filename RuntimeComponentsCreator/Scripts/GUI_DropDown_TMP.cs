using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace RuntimeComponents.UI
{
 public class GUI_DropDown_TMP : MonoBehaviour
 {
    public void Start()
    {
          Sprite[] Sprites = Resources.FindObjectsOfTypeAll(typeof(Sprite)) as Sprite[];
          Sprite uisprite = null;
          Sprite dropdownarrowsprite = null;
          Sprite backgroundsp = null;
          Sprite uimasksp = null;
          Sprite checkmarksp = null;
          for (int i = 0; i < Sprites.Length; i++)
          {
                if (Sprites[i].name == "UISprite")
                {
                    uisprite = Sprites[i];
                }
                if (Sprites[i].name == "DropdownArrow")
                {
                    dropdownarrowsprite = Sprites[i];
                }
                if (Sprites[i].name == "Background")
                {
                    backgroundsp = Sprites[i];
                }
                if (Sprites[i].name == "UIMask")
                {
                    uimasksp = Sprites[i];
                }
                if (Sprites[i].name == "Checkmark")
                {
                    checkmarksp = Sprites[i];
                }
          }
          GameObject Dropdown = new GameObject("Dropdown", typeof(Image), typeof(TMP_Dropdown));
          Dropdown.transform.SetParent(Canvas.transform);
          Dropdown.GetComponent<Image>().sprite = uisprite;
          Dropdown.GetComponent<RectTransform>().sizeDelta = new Vector2 (160, 30);
          Dropdown.GetComponent<Image>().type = Image.Type.Sliced;
          fd[0].text = "Option A";
          fd[1].text = "Option B";
          fd[2].text = "Option C";
          Dropdown.GetComponent<TMP_Dropdown>().options.AddRange(fd);
          GameObject Label = new GameObject("Label", typeof(TextMeshProUGUI));
          Label.transform.SetParent(Dropdown.transform);
          Label.GetComponent<TextMeshProUGUI>().fontSize = 14;
          Label.GetComponent<TextMeshProUGUI>().color = Color.black;
          Label.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Left;
          Label.GetComponent<RectTransform>().anchorMax = new Vector2(1,1);
          Label.GetComponent<RectTransform>().anchorMin = new Vector2(0,0);
          Label.GetComponent<RectTransform>().sizeDelta = new Vector2 (-35, -14);
		  Label.GetComponent<RectTransform>().anchoredPosition = new Vector2(-7.5f,+0);
		  GameObject Arrow = new GameObject("Arrow", typeof(Image));
          Arrow.transform.SetParent(Dropdown.transform);
          Arrow.GetComponent<RectTransform>().anchorMax = new Vector2(1,0.5f);
          Arrow.GetComponent<RectTransform>().anchorMin = new Vector2(1,0.5f);
          Arrow.GetComponent<RectTransform>().sizeDelta = new Vector2 (20, 20);
          Arrow.GetComponent<RectTransform>().anchoredPosition = new Vector2(-15,0);
          Arrow.GetComponent<Image>().sprite = dropdownarrowsprite;
          GameObject Template = new GameObject("Template", typeof(Image), typeof(ScrollRect));
		  Template.GetComponent<RectTransform>().sizeDelta = new Vector2 (-0, +150);
		  Template.GetComponent<RectTransform>().anchoredPosition = new Vector2(0,+2);
          Template.transform.SetParent(Dropdown.transform);
          Template.SetActive(false);
          Template.GetComponent<Image>().sprite = Dropdown.GetComponent<Image>().sprite;
          Template.GetComponent<Image>().type = Image.Type.Sliced;
          Template.GetComponent<RectTransform>().anchorMax = new Vector2(1,0);
          Template.GetComponent<RectTransform>().anchorMin = new Vector2(0,0);
          Template.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 1);
          Template.GetComponent<ScrollRect>().movementType = ScrollRect.MovementType.Clamped;
          Template.GetComponent<ScrollRect>().horizontal = false;
          Template.GetComponent<ScrollRect>().verticalScrollbarVisibility = ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport;
          Template.GetComponent<ScrollRect>().verticalScrollbarSpacing = -3;
          GameObject Viewport = new GameObject("Viewport", typeof(Mask), typeof(Image));
		  Viewport.GetComponent<RectTransform>().sizeDelta = new Vector2 (-18,-0);
		  Viewport.GetComponent<RectTransform>().anchoredPosition = new Vector2(0,-88);
          Viewport.transform.SetParent(Template.transform);
          Viewport.GetComponent<Image>().sprite = uimasksp;
          Viewport.GetComponent<Image>().type = Image.Type.Sliced;
          Viewport.GetComponent<Mask>().showMaskGraphic = false;
		  Viewport.GetComponent<RectTransform>().pivot = new Vector2(0,1);
		  Viewport.GetComponent<RectTransform>().anchorMax = new Vector2(1, 1);
		  Viewport.GetComponent<RectTransform>().anchorMin = new Vector2(0, 0);
          GameObject scrollbar = new GameObject("Scrollbar", typeof(Image), typeof(Scrollbar));
		  scrollbar.GetComponent<RectTransform>().sizeDelta = new Vector2 (+20,0);
		  scrollbar.GetComponent<RectTransform>().anchoredPosition = new Vector2(0,-88);
          scrollbar.transform.SetParent(Template.transform);
          scrollbar.GetComponent<Image>().sprite = backgroundsp;
          scrollbar.GetComponent<Image>().type = Image.Type.Sliced;
		  scrollbar.GetComponent<RectTransform>().pivot = new Vector2(1,1);
	      scrollbar.GetComponent<RectTransform>().anchorMax = new Vector2(1, 1);
		  scrollbar.GetComponent<RectTransform>().anchorMin = new Vector2(1, 0);
		  GameObject slidingArea = new GameObject("Sliding Area", typeof(RectTransform));
		  //slidingArea.GetComponent<RectTransform>().sizeDelta = new Vector2 (-90,-28);
		  //slidingArea.GetComponent<RectTransform>().anchoredPosition = new Vector2(-120,+158);
          slidingArea.transform.SetParent(scrollbar.transform);
		  slidingArea.GetComponent<RectTransform>().anchorMax = new Vector2(1, 1);
		  slidingArea.GetComponent<RectTransform>().anchorMin = new Vector2(0, 0);
		  GameObject Handle = new GameObject("Handle", typeof(Image));
          Handle.transform.SetParent(slidingArea.transform);
          Handle.GetComponent<Image>().sprite = backgroundsp;
          Handle.GetComponent<Image>().type = Image.Type.Sliced;
		  scrollbar.GetComponent<Scrollbar>().targetGraphic = Handle.GetComponent<Image>();
		  scrollbar.GetComponent<Scrollbar>().handleRect = Handle.GetComponent<RectTransform>();
		  scrollbar.GetComponent<Scrollbar>().direction = Scrollbar.Direction.BottomToTop;
          GameObject Content = new GameObject("Content", typeof(RectTransform));
		  Content.GetComponent<RectTransform>().sizeDelta = new Vector2 (+0,+28);
		  Content.GetComponent<RectTransform>().anchoredPosition = new Vector2(-9,-88);
          Content.transform.SetParent(Viewport.transform);
		  Content.GetComponent<RectTransform>().pivot = new Vector2(0.5f,1);
		  Content.GetComponent<RectTransform>().anchorMax = new Vector2(1, 1);
		  Content.GetComponent<RectTransform>().anchorMin = new Vector2(0, 1);
          GameObject Item = new GameObject("Item", typeof(Toggle));
		  Item.GetComponent<RectTransform>().sizeDelta = new Vector2 (+0,+20);
		  Item.GetComponent<RectTransform>().anchoredPosition = new Vector2(-9,-27);
          Item.GetComponent<Toggle>().isOn = true;
          Item.transform.SetParent(Content.transform);
		  Item.GetComponent<RectTransform>().anchorMax = new Vector2(1, 0.5f);
		  Item.GetComponent<RectTransform>().anchorMin = new Vector2(0, 0.5f);
          GameObject ItemBackground = new GameObject("Item Background", typeof(Image));
		  //ItemBackground.GetComponent<RectTransform>().sizeDelta = new Vector2 (+0,-0);
		  //ItemBackground.GetComponent<RectTransform>().anchoredPosition = new Vector2(-0,+0);
          Item.GetComponent<Toggle>().targetGraphic = ItemBackground.GetComponent<Image>();
		  ItemBackground.GetComponent<RectTransform>().anchorMax = new Vector2(1, 1);
		  ItemBackground.GetComponent<RectTransform>().anchorMin = new Vector2(0, 0);
		  ItemBackground.transform.SetParent(Item.transform);
          GameObject ItemCheckmark = new GameObject("Item Checkmark", typeof(Image));
          Item.GetComponent<Toggle>().graphic = ItemCheckmark.GetComponent<Image>();
		  ItemCheckmark.GetComponent<RectTransform>().anchorMax = new Vector2(0, 0.5f);
		  ItemCheckmark.GetComponent<RectTransform>().anchorMin = new Vector2(0, 0.5f);
		  ItemCheckmark.transform.SetParent(Item.transform);
          ItemCheckmark.GetComponent<Image>().sprite = checkmarksp;
          GameObject ItemLabel = new GameObject("Item Label", typeof(TextMeshProUGUI));
		  //ItemLabel.GetComponent<RectTransform>().sizeDelta = new Vector2 (+104,+132);
		  //ItemLabel.GetComponent<RectTransform>().anchoredPosition = new Vector2(+2,-55);
		  ItemLabel.GetComponent<RectTransform>().anchorMax = new Vector2(1, 1);
		  ItemLabel.GetComponent<RectTransform>().anchorMin = new Vector2(0, 0);
		  ItemLabel.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Left;
          ItemLabel.GetComponent<TextMeshProUGUI>().text = "Option A";
          ItemLabel.GetComponent<TextMeshProUGUI>().fontSize = 14;
          ItemLabel.GetComponent<TextMeshProUGUI>().color = Color.black;
          ItemLabel.transform.SetParent(Item.transform);
          Dropdown.GetComponent<TMP_Dropdown>().targetGraphic = Dropdown.GetComponent<Image>();
          Dropdown.GetComponent<TMP_Dropdown>().template = Template.GetComponent<RectTransform>();
          Dropdown.GetComponent<TMP_Dropdown>().captionText = Label.GetComponent<TextMeshProUGUI>();
          Dropdown.GetComponent<TMP_Dropdown>().itemText = ItemLabel.GetComponent<TextMeshProUGUI>();
          Template.GetComponent<ScrollRect>().content = Content.GetComponent<RectTransform>();
          Template.GetComponent<ScrollRect>().viewport = Viewport.GetComponent<RectTransform>();
          Template.GetComponent<ScrollRect>().verticalScrollbar = scrollbar.GetComponent<Scrollbar>();
    }
    public GameObject Canvas;
    public TMP_Dropdown.OptionData[] fd = new TMP_Dropdown.OptionData[3];
 } 
}
