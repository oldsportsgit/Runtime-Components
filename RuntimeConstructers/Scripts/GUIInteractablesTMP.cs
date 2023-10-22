using UnityEngine.UI;
using UnityEngine;
using TMPro;
using System;
using System.Collections.Generic;

namespace RuntimeConstructers
{
    /// <summary>
    /// Class for creating basic TextMeshPro UI Objects.
    /// </summary>
    public class GUIInteractablesTMP : GUIInteractables
    {
        /// <summary>
        /// Creates a TextMeshPro Button.
        /// </summary>
        public static Button ButtonTMP(GameObject Canvas, Vector2 Position, string text, float fontSize = 24, string ButtonName = "Button")
        {
            Button button = new GameObject(ButtonName, typeof(Image), typeof(Button)).GetComponent<Button>();
            TextMeshProUGUI GUI_text = new GameObject("Text (TMP)", typeof(TextMeshProUGUI)).GetComponent<TextMeshProUGUI>();
            button.transform.SetParent(Canvas.transform);
            button.image.rectTransform.sizeDelta = new Vector2(160, 30);
            button.image.sprite = GetUISprite;
            button.image.type = Image.Type.Sliced;
            GUI_text.transform.SetParent(button.transform);
            GUI_text.text = text;
            GUI_text.alignment = TextAlignmentOptions.Center;
            GUI_text.color = new Color32(50, 50, 50, 255);
            GUI_text.fontSize = fontSize;
            GUI_text.rectTransform.anchorMin = Vector2.zero;
            GUI_text.rectTransform.anchorMax = Vector2.one;
            GUI_text.rectTransform.offsetMax = Vector2.zero;
            GUI_text.rectTransform.offsetMin = Vector2.zero;
            button.image.rectTransform.anchoredPosition = Position;
            AddLayerForEach(button.gameObject);
            return button;
        }

        /// <summary>
        /// Creates a TextMeshProUGUI Object.
        /// </summary>
        public static TextMeshProUGUI textTMP(GameObject Canvas, Vector2 position, string text, string TextName = "Text (TMP)")
        {
            TextMeshProUGUI TMPtext = new GameObject(TextName, typeof(TextMeshProUGUI)).GetComponent<TextMeshProUGUI>();
            TMPtext.transform.SetParent(Canvas.transform);
            TMPtext.text = text;
            TMPtext.rectTransform.anchoredPosition = position;
            TMPtext.gameObject.layer = 5;
            return TMPtext;
        }

        /// <summary>
        /// Creates a TextMeshPro InputField.
        /// </summary>
        public static TMP_InputField InputFieldTMP(GameObject Canvas, Vector2 position, string InputFieldName = "InputField (TMP)")
        {
            TMP_InputField InputField = new GameObject(InputFieldName, typeof(Image), typeof(TMP_InputField)).GetComponent<TMP_InputField>();
            RectMask2D Text_area = new GameObject("Text Area", typeof(RectMask2D)).GetComponent<RectMask2D>();
            TextMeshProUGUI Placeholder = new GameObject("Placeholder", typeof(TextMeshProUGUI), typeof(LayoutElement)).GetComponent<TextMeshProUGUI>();
            TextMeshProUGUI text = new GameObject("Text", typeof(TextMeshProUGUI)).GetComponent<TextMeshProUGUI>();
            InputField.transform.SetParent(Canvas.transform);
            InputField.image.type = Image.Type.Sliced;
            InputField.image.sprite = GetInputFieldBackground;
            InputField.image.rectTransform.sizeDelta = new Vector2(160, 30);
            Text_area.transform.SetParent(InputField.transform);
            Text_area.rectTransform.anchorMax = Vector2.one;
            Text_area.rectTransform.anchorMin = Vector2.zero;
            Text_area.rectTransform.anchoredPosition = new Vector2(0, -0.50f);
            Text_area.rectTransform.sizeDelta = new Vector2(-20, -13);
            Text_area.padding = new Vector4(-8,-8,-8,-8);
            Placeholder.transform.SetParent(Text_area.transform);
            Placeholder.GetComponent<LayoutElement>().ignoreLayout = true;
            Placeholder.rectTransform.anchorMax = Vector2.one;
            Placeholder.rectTransform.anchorMin = Vector2.zero;
            Placeholder.rectTransform.offsetMax = Vector2.zero;
            Placeholder.rectTransform.offsetMin = Vector2.zero;
            Placeholder.rectTransform.anchoredPosition = Vector2.zero;
            Placeholder.rectTransform.sizeDelta = Vector2.zero;
            Placeholder.text = "Enter text...";
            Placeholder.enableWordWrapping = false;
            Placeholder.fontSize = 14;
            Placeholder.fontStyle = FontStyles.Italic;
            Placeholder.color = new Color32(50, 50, 50, 128);
            text.transform.SetParent(Text_area.transform);
            text.rectTransform.anchorMax = Vector2.one;
            text.rectTransform.anchorMin = Vector2.zero;
            text.rectTransform.offsetMax = Vector2.zero;
            text.rectTransform.offsetMin = Vector2.zero;
            text.rectTransform.sizeDelta = Vector2.zero;
            text.rectTransform.anchoredPosition = Vector2.zero;
            text.fontSize = 14;
            text.color = new Color32(50, 50, 50, 255);
            InputField.textViewport = Text_area.rectTransform;
            InputField.textComponent = text;
            InputField.fontAsset = text.font;
            InputField.placeholder = Placeholder;
            InputField.image.rectTransform.anchoredPosition = position;
            AddLayerForEach(InputField.gameObject);
            return InputField;
        }

        /// <summary>
        /// Creates a TextMeshPro DropDown.
        /// </summary>
        public static TMP_Dropdown DropDownTMP(GameObject Canvas, Vector2 position, string DropDownName = "Dropdown")
        {
            TMP_Dropdown Dropdown = new GameObject(DropDownName, typeof(UnityEngine.UI.Image), typeof(TMP_Dropdown)).GetComponent<TMP_Dropdown>();
            TextMeshProUGUI Label = new GameObject("Label", typeof(TextMeshProUGUI)).GetComponent<TextMeshProUGUI>();
            Image Arrow = new GameObject("Arrow", typeof(Image)).GetComponent<Image>();
            Image Template = new GameObject("Template", typeof(Image), typeof(ScrollRect)).GetComponent<Image>();
            Image Viewport = new GameObject("Viewport", typeof(Mask), typeof(Image)).GetComponent<Image>();
            RectTransform Content = new GameObject("Content", typeof(RectTransform)).GetComponent<RectTransform>();
            Toggle Item = new GameObject("Item", typeof(Toggle)).GetComponent<Toggle>();
            Image ItemBackground = new GameObject("Item Background", typeof(Image)).GetComponent<Image>();
            Image ItemCheckmark = new GameObject("Item Checkmark", typeof(Image)).GetComponent<Image>();
            TextMeshProUGUI ItemLabel = new GameObject("Item Label", typeof(TextMeshProUGUI)).GetComponent<TextMeshProUGUI>();
            Scrollbar scrollbar = new GameObject("Scrollbar", typeof(Image), typeof(Scrollbar)).GetComponent<Scrollbar>();
            RectTransform slidingArea = new GameObject("Sliding Area", typeof(RectTransform)).GetComponent<RectTransform>();
            Image Handle = new GameObject("Handle", typeof(Image)).GetComponent<Image>();
            Dropdown.transform.SetParent(Canvas.transform);
            Dropdown.targetGraphic = Dropdown.GetComponent<Image>();
            Dropdown.image.sprite = GetUISprite;
            Dropdown.image.type = Image.Type.Sliced;
            Dropdown.image.rectTransform.sizeDelta = new Vector2(160, 30);
            Dropdown.AddOptions(new List<string> { "Option A", "Option B", "Option C" });
            Label.transform.SetParent(Dropdown.transform);
            Label.fontSize = 14;
            Label.color = new Color32(50, 50, 50, 255);
            Label.alignment = TextAlignmentOptions.Left;
            Label.rectTransform.anchorMax = Vector2.one;
            Label.rectTransform.anchorMin = Vector2.zero;
            Label.rectTransform.sizeDelta = new Vector2(-35, -13);
            Label.rectTransform.anchoredPosition = new Vector2(-7.50f, -0.50f);
            Arrow.transform.SetParent(Dropdown.transform);
            Arrow.rectTransform.anchorMax = new Vector2(1, 0.5f);
            Arrow.rectTransform.anchorMin = new Vector2(1, 0.5f);
            Arrow.rectTransform.sizeDelta = new Vector2(20, 20);
            Arrow.rectTransform.anchoredPosition = new Vector2(-15, 0);
            Arrow.sprite = GetDropdownArrow;
            Template.rectTransform.sizeDelta = new Vector2(0, 150);
            Template.rectTransform.anchoredPosition = new Vector2(0, 2);
            Template.transform.SetParent(Dropdown.transform);
            Template.gameObject.SetActive(false);
            Template.sprite = Dropdown.image.sprite;
            Template.type = Image.Type.Sliced;
            Template.rectTransform.anchorMax = Vector2.right;
            Template.rectTransform.anchorMin = Vector2.zero;
            Template.rectTransform.pivot = new Vector2(0.5f, 1);
            Template.rectTransform.sizeDelta = new Vector2(0, 150);
            Template.rectTransform.anchoredPosition = new Vector2(0, 2);
            ScrollRect TPTMP = Template.GetComponent<ScrollRect>();
            TPTMP.movementType = ScrollRect.MovementType.Clamped;
            TPTMP.horizontal = false;
            TPTMP.verticalScrollbarVisibility = ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport;
            TPTMP.verticalScrollbarSpacing = -3;
            Viewport.rectTransform.sizeDelta = new Vector2(-18, -0);
            Viewport.rectTransform.anchoredPosition = Vector2.zero;
            Viewport.transform.SetParent(Template.transform);
            Viewport.sprite = GetUIMask;
            Viewport.type = Image.Type.Sliced;
            Viewport.GetComponent<Mask>().showMaskGraphic = false;
            Viewport.rectTransform.pivot = Vector2.up;
            Viewport.rectTransform.anchorMax = Vector2.one;
            Viewport.rectTransform.anchorMin = Vector2.zero;
            Viewport.rectTransform.sizeDelta = new Vector2(-18, 0);
            Viewport.rectTransform.anchoredPosition = Vector2.zero;
            scrollbar.transform.SetParent(Template.transform);
            scrollbar.image.sprite = GetBackground;
            scrollbar.image.rectTransform.pivot = Vector2.one;
            scrollbar.image.rectTransform.anchorMax = Vector2.one;
            scrollbar.image.rectTransform.anchorMin = Vector2.right;
            scrollbar.image.rectTransform.sizeDelta = new Vector2(20, 0);
            scrollbar.image.rectTransform.anchoredPosition = Vector2.zero;
            slidingArea.transform.SetParent(scrollbar.transform);
            slidingArea.anchorMax = Vector2.one;
            slidingArea.anchorMin = Vector2.zero;
            slidingArea.sizeDelta = new Vector2(-20, -20);
            slidingArea.anchoredPosition = Vector2.zero;
            Handle.transform.SetParent(slidingArea.transform);
            Handle.sprite = scrollbar.image.sprite;
            Handle.type = Image.Type.Sliced;
            Handle.rectTransform.sizeDelta = new Vector2(20, 20);
            Handle.rectTransform.anchoredPosition = Vector2.zero;
            scrollbar.image.type = Image.Type.Sliced;
            scrollbar.targetGraphic = Handle;
            scrollbar.handleRect = Handle.rectTransform;
            scrollbar.direction = Scrollbar.Direction.BottomToTop;
            Content.transform.SetParent(Viewport.transform);
            Content.pivot = new Vector2(0.5f, 1);
            Content.anchorMax = Vector2.one;
            Content.anchorMin = Vector2.up;
            Content.sizeDelta = new Vector2(0, 28);
            Content.anchoredPosition = Vector2.zero;
            Item.isOn = true;
            Item.transform.SetParent(Content.transform);
            RectTransform ItemRect = Item.GetComponent<RectTransform>();
            ItemRect.anchorMax = new Vector2(1, 0.5f);
            ItemRect.anchorMin = new Vector2(0, 0.5f);
            ItemRect.sizeDelta = new Vector2(0, 20);
            ItemRect.anchoredPosition = Vector2.zero;
            Item.targetGraphic = ItemBackground;
            ItemBackground.transform.SetParent(Item.transform);
            ItemBackground.rectTransform.anchorMax = Vector2.one;
            ItemBackground.rectTransform.anchorMin = Vector2.zero;
            ItemBackground.rectTransform.sizeDelta = Vector2.zero;
            ItemBackground.rectTransform.anchoredPosition = Vector2.zero;
            Item.graphic = ItemCheckmark;
            ItemCheckmark.transform.SetParent(Item.transform);
            ItemCheckmark.sprite = GetCheckmark;
            ItemCheckmark.rectTransform.anchorMax = new Vector2(0, 0.5f);
            ItemCheckmark.rectTransform.anchorMin = new Vector2(0, 0.5f);
            ItemCheckmark.rectTransform.sizeDelta = new Vector2(20, 20);
            ItemCheckmark.rectTransform.anchoredPosition = new Vector2(10, 0);
            ItemLabel.transform.SetParent(Item.transform);
            ItemLabel.alignment = TextAlignmentOptions.Left;
            ItemLabel.text = Dropdown.options[0].text;
            ItemLabel.fontSize = 14;
            ItemLabel.color = new Color32(50, 50, 50, 255);
            ItemLabel.rectTransform.anchorMax = Vector2.one;
            ItemLabel.rectTransform.anchorMin = Vector2.zero;
            ItemLabel.rectTransform.sizeDelta = new Vector2(-30, -3);
            ItemLabel.rectTransform.anchoredPosition = new Vector2(5, -0.50f);
            Dropdown.template = Template.rectTransform;
            Dropdown.captionText = Label;
            Dropdown.itemText = ItemLabel;
            TPTMP.content = Content;
            TPTMP.viewport = Viewport.rectTransform;
            TPTMP.verticalScrollbar = scrollbar;
            Dropdown.image.rectTransform.anchoredPosition = position;
            AddLayerForEach(Dropdown.gameObject);
            return Dropdown;
        }
    }
}
