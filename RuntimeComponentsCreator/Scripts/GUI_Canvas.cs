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
          GUI_canvas.Add(Canvas);
    }
    private static List<GameObject> GUI_canvas = new List<GameObject>();

    public static GameObject GetRootGameObject(int id)
    {
        return GUI_canvas[id];
    }
 }
}
