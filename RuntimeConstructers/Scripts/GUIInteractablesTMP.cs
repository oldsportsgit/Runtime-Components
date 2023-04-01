using UnityEngine.UI;
using UnityEngine;
using TMPro;
using System;

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
        public static Button ButtonTMP(string Name, GameObject Canvas, Vector2 Position, string text)
        {
            Button button = new GameObject(Name, typeof(Image), typeof(Button)).GetComponent<Button>();
            GameObject GUI_text = new GameObject("Text (TMP)", typeof(TextMeshProUGUI));
            button.transform.SetParent(Canvas.transform);
            button.GetComponent<RectTransform>().sizeDelta = new Vector2(160, 30);
            button.GetComponent<Image>().sprite = GetUISprite;
            button.GetComponent<Image>().type = Image.Type.Sliced;
            GUI_text.transform.SetParent(button.transform);
            TextMeshProUGUI textMeshProUGUI = GUI_text.GetComponent<TextMeshProUGUI>();
            textMeshProUGUI.text = text;
            textMeshProUGUI.alignment = TextAlignmentOptions.Center;
            textMeshProUGUI.color = new Vector4(0.20f, 0.20f, 0.20f, 1);
            textMeshProUGUI.fontSize = 24;
            RectTransform rect = GUI_text.GetComponent<RectTransform>();
            rect.anchorMin = new Vector2(0, 0);
            rect.anchorMax = new Vector2(1, 1);
            rect.offsetMax = new Vector2(0, 0);
            rect.offsetMin = new Vector2(0, 0);
            button.GetComponent<RectTransform>().anchoredPosition = Position;
            AddLayerForEach(button.gameObject);
            return button;
        }

        /// <summary>
        /// Creates a TextMeshProUGUI Object.
        /// </summary>
        public static TextMeshProUGUI textTMP(string name, GameObject Canvas, Vector2 position, string text)
        {
            TextMeshProUGUI TMPtext = new GameObject(name, typeof(TextMeshProUGUI)).GetComponent<TextMeshProUGUI>();
            TMPtext.transform.SetParent(Canvas.transform);
            TMPtext.text = text;
            TMPtext.GetComponent<RectTransform>().anchoredPosition = position;
            TMPtext.gameObject.layer = 5;
            return TMPtext;
        }

        /// <summary>
        /// Creates a TextMeshPro InputField.
        /// </summary>
        public static TMP_InputField InputFieldTMP(string name, GameObject Canvas, Vector2 position)
        {
            TMP_InputField InputField = new GameObject(name, typeof(Image), typeof(TMP_InputField)).GetComponent<TMP_InputField>();
            GameObject Text_area = new GameObject("Text Area", typeof(RectMask2D));
            GameObject Placeholder = new GameObject("Placeholder", typeof(TextMeshProUGUI), typeof(LayoutElement));
            GameObject text = new GameObject("Text", typeof(TextMeshProUGUI));
            InputField.transform.SetParent(Canvas.transform);
            InputField.GetComponent<Image>().type = Image.Type.Sliced;
            InputField.GetComponent<Image>().sprite = GetInputFieldBackground;
            InputField.GetComponent<RectTransform>().sizeDelta = new Vector2(160, 30);
            Text_area.transform.SetParent(InputField.transform);
            RectTransform Text_areaRect = Text_area.GetComponent<RectTransform>();
            Text_areaRect.anchorMax = new Vector2(1, 1);
            Text_areaRect.anchorMin = new Vector2(0, 0);
            Text_areaRect.anchoredPosition = new Vector2(0, -0.50f);
            Text_areaRect.sizeDelta = new Vector2(-20, -13);
            Placeholder.transform.SetParent(Text_area.transform);
            Placeholder.GetComponent<LayoutElement>().ignoreLayout = true;
            RectTransform PlaceholderRect = Placeholder.GetComponent<RectTransform>();
            PlaceholderRect.anchorMax = new Vector2(1, 1);
            PlaceholderRect.anchorMin = new Vector2(0, 0);
            PlaceholderRect.offsetMax = new Vector2(0, 0);
            PlaceholderRect.offsetMin = new Vector2(0, 0);
            PlaceholderRect.anchoredPosition = Vector2.zero;
            PlaceholderRect.sizeDelta = Vector2.zero;
            TextMeshProUGUI PlaceholderText = Placeholder.GetComponent<TextMeshProUGUI>();
            PlaceholderText.text = "Enter text...";
            PlaceholderText.enableWordWrapping = false;
            PlaceholderText.fontSize = 14;
            PlaceholderText.fontStyle = FontStyles.Italic;
            PlaceholderText.color = new Vector4(0.20f, 0.20f, 0.20f, 0.5f);
            text.transform.SetParent(Text_area.transform);
            RectTransform textRect = text.GetComponent<RectTransform>();
            textRect.anchorMax = new Vector2(1, 1);
            textRect.anchorMin = new Vector2(0, 0);
            textRect.offsetMax = new Vector2(0, 0);
            textRect.offsetMin = new Vector2(0, 0);
            textRect.sizeDelta = Vector2.zero;
            textRect.anchoredPosition = Vector2.zero;
            text.GetComponent<TextMeshProUGUI>().fontSize = 14;
            text.GetComponent<TextMeshProUGUI>().color = new Vector4(0.20f, 0.20f, 0.20f, 1);
            TMP_InputField IFTMP = InputField.GetComponent<TMP_InputField>();
            IFTMP.textViewport = Text_area.GetComponent<RectTransform>();
            IFTMP.textComponent = text.GetComponent<TextMeshProUGUI>();
            IFTMP.fontAsset = text.GetComponent<TextMeshProUGUI>().font;
            IFTMP.placeholder = Placeholder.GetComponent<TextMeshProUGUI>();
            InputField.GetComponent<RectTransform>().anchoredPosition = position;
            AddLayerForEach(InputField.gameObject);
            return InputField;
        }

        /// <summary>
        /// Creates a TextMeshPro DropDown.
        /// </summary>
        public static TMP_Dropdown DropDownTMP(string name, GameObject Canvas, Vector2 position)
        {
            TMP_Dropdown Dropdown = new GameObject(name, typeof(UnityEngine.UI.Image), typeof(TMP_Dropdown)).GetComponent<TMP_Dropdown>();
            GameObject Label = new GameObject("Label", typeof(TextMeshProUGUI));
            GameObject Arrow = new GameObject("Arrow", typeof(Image));
            GameObject Template = new GameObject("Template", typeof(Image), typeof(ScrollRect));
            GameObject Viewport = new GameObject("Viewport", typeof(Mask), typeof(Image));
            GameObject Content = new GameObject("Content", typeof(RectTransform));
            GameObject Item = new GameObject("Item", typeof(Toggle));
            GameObject ItemBackground = new GameObject("Item Background", typeof(Image));
            GameObject ItemCheckmark = new GameObject("Item Checkmark", typeof(Image));
            GameObject ItemLabel = new GameObject("Item Label", typeof(TextMeshProUGUI));
            GameObject scrollbar = new GameObject("Scrollbar", typeof(Image), typeof(Scrollbar));
            GameObject slidingArea = new GameObject("Sliding Area", typeof(RectTransform));
            GameObject Handle = new GameObject("Handle", typeof(Image));
            Dropdown.transform.SetParent(Canvas.transform);
            Dropdown.GetComponent<RectTransform>().sizeDelta = new Vector2(160, 30);
            Dropdown.GetComponent<Image>().sprite = GetUISprite;
            Dropdown.GetComponent<RectTransform>().sizeDelta = new Vector2(160, 30);
            Dropdown.GetComponent<Image>().type = Image.Type.Sliced;
            Dropdown.GetComponent<TMP_Dropdown>().options.Add(new TMP_Dropdown.OptionData("Option A"));
            Dropdown.GetComponent<TMP_Dropdown>().options.Add(new TMP_Dropdown.OptionData("Option B"));
            Dropdown.GetComponent<TMP_Dropdown>().options.Add(new TMP_Dropdown.OptionData("Option C"));
            Label.transform.SetParent(Dropdown.transform);
            TextMeshProUGUI LabelText = Label.GetComponent<TextMeshProUGUI>();
            LabelText.fontSize = 14;
            LabelText.color = new Vector4(0.20f, 0.20f, 0.20f, 1);
            LabelText.alignment = TextAlignmentOptions.Left;
            RectTransform LabelRT = Label.GetComponent<RectTransform>();
            LabelRT.anchorMax = new Vector2(1, 1);
            LabelRT.anchorMin = new Vector2(0, 0);
            LabelRT.sizeDelta = new Vector2(-35, -13);
            LabelRT.anchoredPosition = new Vector2(-7.50f, -0.50f);
            Arrow.transform.SetParent(Dropdown.transform);
            RectTransform ArrowRT = Arrow.GetComponent<RectTransform>();
            ArrowRT.anchorMax = new Vector2(1, 0.5f);
            ArrowRT.anchorMin = new Vector2(1, 0.5f);
            ArrowRT.sizeDelta = new Vector2(20, 20);
            ArrowRT.anchoredPosition = new Vector2(-15, 0);
            Arrow.GetComponent<Image>().sprite = GetDropdownArrow;
            Template.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 150);
            Template.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 2);
            Template.transform.SetParent(Dropdown.transform);
            Template.SetActive(false);
            Template.GetComponent<Image>().sprite = Dropdown.GetComponent<Image>().sprite;
            Template.GetComponent<Image>().type = Image.Type.Sliced;
            RectTransform TPRT = Template.GetComponent<RectTransform>();
            TPRT.anchorMax = new Vector2(1, 0);
            TPRT.anchorMin = new Vector2(0, 0);
            TPRT.pivot = new Vector2(0.5f, 1);
            TPRT.sizeDelta = new Vector2(0, 150);
            TPRT.anchoredPosition = new Vector2(0, 2);
            ScrollRect TPTMP = Template.GetComponent<ScrollRect>();
            TPTMP.movementType = ScrollRect.MovementType.Clamped;
            TPTMP.horizontal = false;
            TPTMP.verticalScrollbarVisibility = ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport;
            TPTMP.verticalScrollbarSpacing = -3;
            Viewport.GetComponent<RectTransform>().sizeDelta = new Vector2(-18, -0);
            Viewport.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
            Viewport.transform.SetParent(Template.transform);
            Viewport.GetComponent<Image>().sprite = GetUIMask;
            Viewport.GetComponent<Image>().type = Image.Type.Sliced;
            Viewport.GetComponent<Mask>().showMaskGraphic = false;
            RectTransform VPTMP = Viewport.GetComponent<RectTransform>();
            VPTMP.pivot = new Vector2(0, 1);
            VPTMP.anchorMax = new Vector2(1, 1);
            VPTMP.anchorMin = new Vector2(0, 0);
            VPTMP.sizeDelta = new Vector2(-18, 0);
            VPTMP.anchoredPosition = Vector2.zero;
            scrollbar.transform.SetParent(Template.transform);
            scrollbar.GetComponent<Image>().sprite = GetBackground;
            RectTransform sbrt = scrollbar.GetComponent<RectTransform>();
            sbrt.pivot = new Vector2(1, 1);
            sbrt.anchorMax = new Vector2(1, 1);
            sbrt.anchorMin = new Vector2(1, 0);
            sbrt.sizeDelta = new Vector2(20, 0);
            sbrt.anchoredPosition = Vector2.zero;
            slidingArea.transform.SetParent(scrollbar.transform);
            RectTransform slareart = slidingArea.GetComponent<RectTransform>();
            slareart.anchorMax = new Vector2(1, 1);
            slareart.anchorMin = new Vector2(0, 0);
            slareart.sizeDelta = new Vector2(-20, -20);
            slareart.anchoredPosition = Vector2.zero;
            Handle.transform.SetParent(slidingArea.transform);
            Handle.GetComponent<Image>().sprite = scrollbar.GetComponent<Image>().sprite;
            Handle.GetComponent<Image>().type = Image.Type.Sliced;
            Handle.GetComponent<RectTransform>().sizeDelta = new Vector2(20, 20);
            Handle.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
            Scrollbar scrollbarbar = scrollbar.GetComponent<Scrollbar>();
            scrollbar.GetComponent<Image>().type = Image.Type.Sliced;
            scrollbarbar.targetGraphic = Handle.GetComponent<Image>();
            scrollbarbar.handleRect = Handle.GetComponent<RectTransform>();
            scrollbarbar.direction = Scrollbar.Direction.BottomToTop;
            Content.transform.SetParent(Viewport.transform);
            RectTransform ContentRect = Content.GetComponent<RectTransform>();
            ContentRect.pivot = new Vector2(0.5f, 1);
            ContentRect.anchorMax = new Vector2(1, 1);
            ContentRect.anchorMin = new Vector2(0, 1);
            ContentRect.sizeDelta = new Vector2(0, 28);
            ContentRect.anchoredPosition = Vector2.zero;
            Item.GetComponent<Toggle>().isOn = true;
            Item.transform.SetParent(Content.transform);
            RectTransform ItemRect = Item.GetComponent<RectTransform>();
            ItemRect.anchorMax = new Vector2(1, 0.5f);
            ItemRect.anchorMin = new Vector2(0, 0.5f);
            ItemRect.sizeDelta = new Vector2(0, 20);
            ItemRect.anchoredPosition = Vector2.zero;
            Item.GetComponent<Toggle>().targetGraphic = ItemBackground.GetComponent<Image>();
            ItemBackground.transform.SetParent(Item.transform);
            RectTransform ItemBackgroundRect = ItemBackground.GetComponent<RectTransform>();
            ItemBackgroundRect.anchorMax = new Vector2(1, 1);
            ItemBackgroundRect.anchorMin = new Vector2(0, 0);
            ItemBackgroundRect.sizeDelta = Vector2.zero;
            ItemBackgroundRect.anchoredPosition = Vector2.zero;
            Item.GetComponent<Toggle>().graphic = ItemCheckmark.GetComponent<Image>();
            ItemCheckmark.transform.SetParent(Item.transform);
            ItemCheckmark.GetComponent<Image>().sprite = GetCheckmark;
            RectTransform ICRect = ItemCheckmark.GetComponent<RectTransform>();
            ICRect.anchorMax = new Vector2(0, 0.5f);
            ICRect.anchorMin = new Vector2(0, 0.5f);
            ICRect.sizeDelta = new Vector2(20, 20);
            ICRect.anchoredPosition = new Vector2(10, 0);
            ItemLabel.transform.SetParent(Item.transform);
            TextMeshProUGUI ItemLabelTMPU = ItemLabel.GetComponent<TextMeshProUGUI>();
            ItemLabelTMPU.alignment = TextAlignmentOptions.Left;
            ItemLabelTMPU.text = "Option A";
            ItemLabelTMPU.fontSize = 14;
            ItemLabelTMPU.color = new Vector4(0.20f, 0.20f, 0.20f, 1);
            RectTransform ItemLabelRect = ItemLabel.GetComponent<RectTransform>();
            ItemLabelRect.anchorMax = new Vector2(1, 1);
            ItemLabelRect.anchorMin = new Vector2(0, 0);
            ItemLabelRect.sizeDelta = new Vector2(-30, -3);
            ItemLabelRect.anchoredPosition = new Vector2(5, -0.50f);
            TMP_Dropdown DDTMP = Dropdown.GetComponent<TMP_Dropdown>();
            DDTMP.targetGraphic = Dropdown.GetComponent<Image>();
            DDTMP.template = Template.GetComponent<RectTransform>();
            DDTMP.captionText = Label.GetComponent<TextMeshProUGUI>();
            DDTMP.itemText = ItemLabel.GetComponent<TextMeshProUGUI>();
            ScrollRect TemplateScrollRect = Template.GetComponent<ScrollRect>();
            TemplateScrollRect.content = Content.GetComponent<RectTransform>();
            TemplateScrollRect.viewport = Viewport.GetComponent<RectTransform>();
            TemplateScrollRect.verticalScrollbar = scrollbar.GetComponent<Scrollbar>();
            Dropdown.GetComponent<RectTransform>().anchoredPosition = position;
            AddLayerForEach(Dropdown.gameObject);
            return Dropdown;
        }
    }
}
