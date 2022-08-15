using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RuntimeComponents.UI
{
 public class GUI_Canvas : MonoBehaviour
 {
    public static void CreateCanvas(string name)
    {
          GameObject Canvas = new GameObject(name, typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
          Canvas.GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceOverlay;
    }
 }
}
