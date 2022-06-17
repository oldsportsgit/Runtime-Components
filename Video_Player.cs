using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
//you could use the UnityWebRequest to download a videoclip and put it in "clip"

public class Video_Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player = new GameObject();
        Player.name = "Video Player";
        Player.AddComponent<VideoPlayer>(); 
        Player.GetComponent<VideoPlayer>().targetTexture = rt;
        Player.GetComponent<VideoPlayer>().clip = Clip;
    }
    public GameObject Player;
    public VideoClip Clip;
    public RenderTexture rt;
}
