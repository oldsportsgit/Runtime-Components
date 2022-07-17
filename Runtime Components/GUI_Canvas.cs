using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUI_Canvas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
          GameObject Canvas = new GameObject("Canvas", typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
          Canvas.GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceOverlay;
    }
}
