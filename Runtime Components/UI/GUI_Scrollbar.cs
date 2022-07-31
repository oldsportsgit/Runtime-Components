using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUI_Scrollbar : MonoBehaviour
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
	     Texture2D backgroundtex = new Texture2D(2, 2);
	     byte[] Background = new byte[] 
          {
	0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A, 0x00, 0x00, 0x00, 0x0D,
	0x49, 0x48, 0x44, 0x52, 0x00, 0x00, 0x00, 0x20, 0x00, 0x00, 0x00, 0x20,
	0x08, 0x06, 0x00, 0x00, 0x00, 0x73, 0x7A, 0x7A, 0xF4, 0x00, 0x00, 0x00,
	0x01, 0x73, 0x52, 0x47, 0x42, 0x00, 0xAE, 0xCE, 0x1C, 0xE9, 0x00, 0x00,
	0x00, 0x04, 0x67, 0x41, 0x4D, 0x41, 0x00, 0x00, 0xB1, 0x8F, 0x0B, 0xFC,
	0x61, 0x05, 0x00, 0x00, 0x00, 0x09, 0x70, 0x48, 0x59, 0x73, 0x00, 0x00,
	0x0E, 0xC3, 0x00, 0x00, 0x0E, 0xC3, 0x01, 0xC7, 0x6F, 0xA8, 0x64, 0x00,
	0x00, 0x01, 0x93, 0x49, 0x44, 0x41, 0x54, 0x58, 0x47, 0xED, 0x97, 0xD1,
	0x6A, 0x83, 0x30, 0x14, 0x86, 0xBD, 0xDA, 0xAB, 0x0C, 0x84, 0x41, 0xB5,
	0x3E, 0xD9, 0x2E, 0x0A, 0x3E, 0x84, 0x58, 0xD9, 0xB3, 0x88, 0x17, 0x22,
	0xBE, 0x80, 0x38, 0x11, 0x27, 0x85, 0xBD, 0xC4, 0x60, 0x30, 0x18, 0x14,
	0xDC, 0xF9, 0x43, 0x4F, 0x38, 0x75, 0x69, 0xA7, 0x25, 0x6E, 0xBB, 0xF0,
	0xE2, 0x23, 0x59, 0xE6, 0xF9, 0xFF, 0x3F, 0xD1, 0x92, 0xC4, 0x71, 0x5D,
	0xF7, 0x0C, 0xDF, 0xF7, 0x9D, 0x20, 0x08, 0x14, 0xE8, 0x03, 0xCF, 0xF3,
	0x74, 0x7F, 0x2A, 0xB2, 0x46, 0xEA, 0x8D, 0xFD, 0xD4, 0x83, 0xE8, 0xC8,
	0x16, 0xD8, 0x0E, 0xC0, 0xBA, 0xF0, 0xC0, 0x18, 0xB7, 0x3A, 0x1D, 0x06,
	0x00, 0xFF, 0x4D, 0xDC, 0xD3, 0x03, 0x11, 0x51, 0x51, 0xE1, 0x91, 0xDA,
	0x61, 0x0E, 0xA7, 0x9A, 0x8A, 0x88, 0xA0, 0xC5, 0xBA, 0x63, 0x1F, 0x9D,
	0x4A, 0xB6, 0xC4, 0x23, 0xF1, 0x11, 0x45, 0xD1, 0x90, 0xA6, 0xE9, 0xD0,
	0x75, 0xDD, 0xD0, 0xF7, 0xFD, 0x2C, 0x50, 0x83, 0x5A, 0x68, 0x40, 0xEB,
	0xA4, 0xF9, 0xCD, 0x4B, 0x75, 0x04, 0x77, 0x94, 0x38, 0xDB, 0xED, 0x76,
	0x43, 0x59, 0x96, 0x46, 0xE1, 0x5B, 0x80, 0x16, 0x34, 0xA1, 0x0D, 0x0F,
	0xE9, 0xC9, 0x33, 0x66, 0xF6, 0x61, 0x18, 0x1A, 0x45, 0x6C, 0x00, 0x6D,
	0xBC, 0x12, 0x42, 0x7F, 0x1F, 0xCE, 0x76, 0xBB, 0x65, 0x1E, 0x28, 0xC0,
	0xB1, 0x6D, 0x5B, 0x63, 0xB1, 0x0D, 0x9A, 0xA6, 0x51, 0xDF, 0xC6, 0x66,
	0xB3, 0x71, 0x09, 0x07, 0x9C, 0xCD, 0x3E, 0x8E, 0x63, 0x63, 0xA1, 0x4D,
	0xF0, 0x4D, 0xC8, 0x55, 0x90, 0x01, 0x0E, 0x45, 0x51, 0x18, 0x8B, 0x6C,
	0x92, 0xE7, 0x39, 0x02, 0xBC, 0xE8, 0x00, 0xDC, 0x21, 0x3E, 0x97, 0x5C,
	0x7E, 0xA6, 0xAA, 0x2A, 0xBC, 0x86, 0x37, 0x9E, 0xB8, 0x0C, 0x60, 0x2C,
	0x58, 0x02, 0x78, 0xB1, 0xEF, 0x1A, 0x60, 0x0D, 0xB0, 0x06, 0x58, 0x03,
	0xAC, 0x01, 0xFE, 0x55, 0x80, 0x5F, 0xD9, 0x8C, 0xEA, 0xBA, 0x86, 0xF9,
	0x3B, 0xFB, 0xCA, 0x00, 0xAF, 0x36, 0x8F, 0x61, 0x97, 0xB8, 0xB6, 0x1D,
	0x3F, 0x25, 0x49, 0x62, 0x2C, 0xB2, 0x09, 0x0E, 0x3D, 0xB4, 0x0D, 0xEF,
	0xF5, 0x76, 0x3C, 0x3E, 0x92, 0xDD, 0x72, 0x02, 0x9E, 0x0A, 0x5E, 0x31,
	0x3C, 0xE0, 0xC5, 0xBE, 0x72, 0x05, 0xD4, 0x2A, 0x2C, 0x7D, 0x28, 0x95,
	0xB3, 0x07, 0xF2, 0x48, 0x0E, 0xFE, 0xE6, 0x58, 0x8E, 0x8E, 0x6C, 0x09,
	0x7D, 0x31, 0xC9, 0xB2, 0xCC, 0x28, 0x3A, 0x05, 0xD4, 0xFE, 0x78, 0x31,
	0xB9, 0x74, 0x65, 0x22, 0xF8, 0x6A, 0xF6, 0x4C, 0xF0, 0x6F, 0x77, 0x2E,
	0xA8, 0xBD, 0x7E, 0x35, 0xA3, 0x07, 0xD4, 0x00, 0xB7, 0x48, 0x05, 0xF0,
	0x4F, 0x8C, 0xD9, 0x00, 0x5A, 0xAC, 0xCB, 0x1E, 0xDC, 0xAA, 0x8E, 0x84,
	0x0B, 0x6C, 0x07, 0x60, 0xBD, 0x73, 0x3F, 0xD7, 0xF9, 0x02, 0xA1, 0x98,
	0xE9, 0x4A, 0xC9, 0x1C, 0x84, 0x77, 0x00, 0x00, 0x00, 0x00, 0x49, 0x45,
	0x4E, 0x44, 0xAE, 0x42, 0x60, 0x82
          };
	     Texture2D tex = new Texture2D(2, 2);
	     byte[] UISprite = new byte[] 
          {
	0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A, 0x00, 0x00, 0x00, 0x0D,
	0x49, 0x48, 0x44, 0x52, 0x00, 0x00, 0x00, 0x20, 0x00, 0x00, 0x00, 0x20,
	0x08, 0x06, 0x00, 0x00, 0x00, 0x73, 0x7A, 0x7A, 0xF4, 0x00, 0x00, 0x00,
	0x09, 0x70, 0x48, 0x59, 0x73, 0x00, 0x00, 0x0E, 0xC4, 0x00, 0x00, 0x0E,
	0xC4, 0x01, 0x95, 0x2B, 0x0E, 0x1B, 0x00, 0x00, 0x02, 0xAB, 0x49, 0x44,
	0x41, 0x54, 0x78, 0x9C, 0xED, 0x57, 0x3D, 0x88, 0x1A, 0x51, 0x10, 0x1E,
	0xDD, 0xF5, 0xB7, 0x89, 0x85, 0x5D, 0xB4, 0x08, 0x9C, 0x88, 0x42, 0x20,
	0x68, 0x67, 0x23, 0x04, 0x02, 0xA6, 0x0A, 0x82, 0x20, 0x82, 0xDD, 0x41,
	0xE0, 0xC0, 0x1F, 0xF0, 0x27, 0x20, 0xA4, 0x3C, 0x08, 0x04, 0xA2, 0x88,
	0x82, 0x20, 0x5C, 0x27, 0x8A, 0x28, 0x68, 0x8A, 0xC0, 0x41, 0x20, 0x90,
	0x52, 0x44, 0x09, 0x1C, 0x04, 0xC4, 0x2E, 0xD8, 0xD8, 0x07, 0xFF, 0x7F,
	0x32, 0xB3, 0xF1, 0x2D, 0xCF, 0xC3, 0xC0, 0x69, 0x94, 0x6B, 0xFC, 0x60,
	0x18, 0xDD, 0xD9, 0x9D, 0xEF, 0x7B, 0xF3, 0xDE, 0xBE, 0x7D, 0x23, 0xDA,
	0xED, 0x76, 0xE0, 0xA1, 0xD5, 0x6A, 0x41, 0xA9, 0x54, 0x4A, 0xBF, 0x57,
	0xAB, 0x95, 0xE4, 0xD7, 0xEB, 0x35, 0x28, 0x14, 0x0A, 0xD8, 0x07, 0xFC,
	0x33, 0x7C, 0xBE, 0xC9, 0x64, 0xB2, 0x75, 0x9F, 0xA8, 0xD1, 0x68, 0x60,
	0x3A, 0x9D, 0x02, 0xF3, 0xF4, 0xE0, 0x72, 0xB9, 0x04, 0x41, 0x10, 0xE0,
	0x98, 0xA0, 0x9C, 0x0C, 0x34, 0x48, 0x12, 0x42, 0x5E, 0x24, 0x22, 0xBD,
	0x5E, 0x0F, 0xA3, 0xD1, 0x48, 0x0A, 0x72, 0xC4, 0x56, 0xB4, 0xB7, 0x68,
	0x6E, 0xB4, 0x17, 0x14, 0xDA, 0x97, 0x13, 0xED, 0x07, 0xDA, 0x77, 0xB4,
	0x22, 0xE6, 0xED, 0xB1, 0x00, 0x91, 0x13, 0x27, 0x41, 0x24, 0x65, 0x7C,
	0x05, 0x36, 0x4A, 0x63, 0x68, 0xD7, 0xB1, 0x58, 0x4C, 0xE7, 0x74, 0x3A,
	0xC1, 0x6A, 0xB5, 0xCA, 0x65, 0x7C, 0x28, 0xB0, 0xDC, 0x42, 0xAF, 0xD7,
	0x73, 0x76, 0x3A, 0x1D, 0x67, 0x3A, 0x9D, 0xBE, 0xC2, 0x4B, 0xEF, 0xD1,
	0xD2, 0x14, 0x23, 0x2E, 0x1A, 0x30, 0x79, 0x91, 0x48, 0x09, 0x1B, 0xAF,
	0xC6, 0x79, 0xFB, 0xEC, 0xF3, 0xF9, 0x3C, 0xC1, 0x60, 0x10, 0xCC, 0x66,
	0x33, 0x1C, 0x0A, 0x12, 0x6C, 0xB3, 0xD9, 0x24, 0x73, 0xBB, 0xDD, 0xBA,
	0x52, 0xA9, 0xF4, 0xA9, 0x5E, 0xAF, 0xBF, 0xC2, 0xD0, 0x1B, 0xE4, 0x9A,
	0x31, 0x4E, 0x69, 0x0D, 0x70, 0xF8, 0x18, 0x08, 0x04, 0x3C, 0x89, 0x44,
	0x02, 0x8E, 0x09, 0x1A, 0x48, 0x2A, 0x95, 0x02, 0x95, 0x4A, 0xE5, 0xA9,
	0x54, 0x2A, 0x1F, 0xF0, 0x52, 0x9C, 0xC5, 0x44, 0xAE, 0xB4, 0xCF, 0xB1,
	0x6C, 0xA1, 0x68, 0x34, 0x2A, 0xFD, 0xA1, 0x15, 0xBB, 0x58, 0x2C, 0x24,
	0xCF, 0xDE, 0x86, 0x7D, 0x41, 0xB9, 0xC9, 0x44, 0x51, 0x94, 0x7C, 0x38,
	0x1C, 0x86, 0x72, 0xB9, 0x1C, 0xC5, 0x85, 0x7E, 0x83, 0xE1, 0x9F, 0x92,
	0x00, 0x2E, 0xF9, 0x65, 0x32, 0x99, 0x14, 0x50, 0xA5, 0x44, 0x3C, 0x9B,
	0xCD, 0xE0, 0x7F, 0xC1, 0xC4, 0x53, 0x3E, 0xB5, 0x5A, 0x2D, 0xCD, 0x39,
	0xAE, 0x2B, 0x21, 0x93, 0xC9, 0x5C, 0xC2, 0xA6, 0x0A, 0x22, 0x77, 0xBF,
	0xC7, 0xE5, 0x72, 0xF1, 0x0B, 0xF1, 0xA8, 0xA0, 0x01, 0x51, 0x5E, 0xE2,
	0x40, 0x01, 0x1E, 0x59, 0x00, 0xB7, 0xC1, 0x3C, 0x33, 0x1A, 0x8D, 0x27,
	0x21, 0x67, 0xA0, 0xDC, 0x06, 0x83, 0x81, 0xF6, 0x9A, 0xA7, 0xEC, 0x1A,
	0x5F, 0x01, 0xF5, 0xBE, 0xBB, 0xDD, 0x21, 0xA0, 0xCD, 0x07, 0x79, 0x9E,
	0xEC, 0x12, 0xF0, 0x28, 0x38, 0x0B, 0x38, 0x0B, 0x38, 0x0B, 0x38, 0x0B,
	0x38, 0x0B, 0xE0, 0x05, 0xCC, 0xE6, 0xF3, 0xB9, 0x9A, 0x3E, 0xC7, 0xA7,
	0xC4, 0x78, 0x3C, 0x26, 0xF7, 0x7B, 0x97, 0x80, 0x5F, 0xC3, 0xE1, 0xF0,
	0xC2, 0x64, 0x32, 0x9D, 0x54, 0x00, 0x72, 0x48, 0x5C, 0xBB, 0x04, 0xDC,
	0xB6, 0x5A, 0xAD, 0xD0, 0xA9, 0x05, 0xB4, 0xDB, 0x6D, 0xFA, 0x1C, 0x7F,
	0x95, 0x05, 0x70, 0x9F, 0xE0, 0x22, 0x1E, 0x14, 0xAE, 0xBC, 0x5E, 0xAF,
	0xB0, 0xEF, 0x09, 0xF8, 0xA1, 0xC0, 0x29, 0x86, 0x6C, 0x36, 0xBB, 0xC4,
	0xFC, 0x37, 0xB2, 0x00, 0x6A, 0x44, 0x36, 0xB8, 0x43, 0x31, 0x85, 0x7C,
	0x3E, 0x1F, 0x8A, 0x44, 0x22, 0x27, 0x11, 0x50, 0x28, 0x14, 0xC8, 0xE5,
	0xF1, 0x98, 0x76, 0x27, 0x0B, 0xB8, 0xD7, 0x2A, 0xC5, 0x6B, 0xB5, 0xDA,
	0x05, 0x2A, 0xF5, 0xF8, 0xFD, 0x7E, 0x38, 0xD6, 0x74, 0x0C, 0x06, 0x03,
	0xA8, 0x56, 0xAB, 0xD0, 0x6C, 0x36, 0x6F, 0xF1, 0xC8, 0xF7, 0x8E, 0x8F,
	0xDD, 0x6F, 0xCD, 0x66, 0x58, 0x91, 0xD7, 0x8D, 0x46, 0x23, 0x86, 0x76,
	0x8D, 0xA7, 0x58, 0x9D, 0xC3, 0xE1, 0x00, 0x8B, 0xC5, 0x72, 0x10, 0x71,
	0xBF, 0xDF, 0x87, 0x6E, 0xB7, 0x0B, 0xB9, 0x5C, 0x8E, 0x96, 0xFE, 0x56,
	0x63, 0xC2, 0x38, 0xFF, 0xD5, 0x9A, 0xD1, 0x8D, 0x5F, 0x70, 0x3A, 0xA8,
	0x35, 0x7B, 0x09, 0x7F, 0x5B, 0xB3, 0x43, 0x40, 0xAD, 0xD9, 0x37, 0xCC,
	0x59, 0x44, 0x2F, 0xB7, 0x66, 0x44, 0x2E, 0xB7, 0x66, 0xAC, 0x63, 0x65,
	0x0D, 0x23, 0x3B, 0x94, 0x6E, 0x7A, 0xB9, 0x38, 0x1C, 0x09, 0xFC, 0x61,
	0x77, 0xAB, 0x35, 0x63, 0x6B, 0x80, 0x79, 0x7A, 0x2B, 0x4E, 0xF1, 0x16,
	0x50, 0x65, 0x59, 0x0F, 0xC2, 0xB7, 0x83, 0x7F, 0x00, 0xF0, 0x1C, 0x47,
	0x04, 0x5F, 0xD5, 0x0F, 0x9A, 0x00, 0x00, 0x00, 0x00, 0x49, 0x45, 0x4E,
	0x44, 0xAE, 0x42, 0x60, 0x82
};
          tex.LoadImage(UISprite);
          backgroundtex.LoadImage(Background);
          GameObject scrollbar = new GameObject("Scrollbar", typeof(Image), typeof(Scrollbar));
          scrollbar.transform.SetParent(Canvas.transform);
          scrollbar.GetComponent<Image>().type = Image.Type.Sliced;
          scrollbar.GetComponent<RectTransform>().sizeDelta = new Vector2 (160, 20);
          scrollbar.GetComponent<Image>().sprite = Sprite.Create(backgroundtex, new Rect(0.0f, 0.0f, backgroundtex.width, backgroundtex.height), new Vector2(16f, 16f), 200.0f, 0, SpriteMeshType.Tight, new Vector4 (10,10,10,10));
          GameObject slidingArea = new GameObject("Sliding Area", typeof(RectTransform));
          slidingArea.transform.SetParent(scrollbar.transform);
          slidingArea.GetComponent<RectTransform>().anchorMin = new Vector2 (0, 0);
          slidingArea.GetComponent<RectTransform>().anchorMax = new Vector2 (1, 1);
          slidingArea.GetComponent<RectTransform>().sizeDelta = new Vector2 (-20, -20);
          GameObject handle = new GameObject("Handle", typeof(Image));
          handle.GetComponent<Image>().type = Image.Type.Sliced;
          handle.GetComponent<Image>().sprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(16f, 16f), 200.0f, 0, SpriteMeshType.Tight, new Vector4 (10,10,10,10));
          handle.transform.SetParent(slidingArea.transform);
          handle.GetComponent<RectTransform>().sizeDelta = new Vector2 (20, 20);
          scrollbar.GetComponent<Scrollbar>().handleRect = handle.GetComponent<RectTransform>();
       }
    }
    public GameObject Canvas;
}
