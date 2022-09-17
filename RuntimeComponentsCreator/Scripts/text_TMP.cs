using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace RuntimeComponents.ThreeD
{
 public class text_TMP : MonoBehaviour
 {
    public static void Text(Vector3 position, Vector3 rotation, Color color,  Vector3 scale, TextAlignmentOptions tao, string text)
    {
       GameObject threeD_text = new GameObject("Text (TMP)", typeof(TextMeshPro));
       textTMP.Add(threeD_text);
       threeD_text.GetComponent<TextMeshPro>().text = text;
       threeD_text.GetComponent<TextMeshPro>().color = color;
       threeD_text.GetComponent<TextMeshPro>().alignment = tao;
       threeD_text.GetComponent<Transform>().position = position;
       threeD_text.GetComponent<Transform>().eulerAngles = rotation;
       threeD_text.GetComponent<Transform>().localScale = scale;
    }
    private static List<GameObject> textTMP = new List<GameObject>();

    public static GameObject GetRootGameObject(int id)
    {
       return textTMP[id];
    }
 }
}
