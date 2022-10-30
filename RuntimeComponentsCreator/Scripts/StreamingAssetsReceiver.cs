using System;
using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

//similar to the assetreceiver
public class StreamingAssetsReceiver : MonoBehaviour
{
    public void Start()
    {
        files = Directory.GetFiles(Application.streamingAssetsPath);
        for (int i = 0; i < files.Length; i++)
        {
            if (Path.GetExtension(files[i]) == ".wav")
            {
                coroutine.Add(Audio(Path.GetFileName(files[i])));
                StartCoroutine(coroutine[0]);
            }
            if (Path.GetExtension(files[i]) == ".png")
            {
                coroutine.Add(GetTexture2D(Path.GetFileName(files[i])));
                StartCoroutine(coroutine[1]);
            }
        }
    }
    private List<IEnumerator> coroutine = new List<IEnumerator>();
    private IEnumerator Audio(string filename)
    {
        string filePath = Path.Combine(Application.streamingAssetsPath, filename);
        UnityWebRequest request = UnityWebRequestMultimedia.GetAudioClip( filePath, AudioType.WAV );
        yield return request.SendWebRequest();
        if( request.result == UnityWebRequest.Result.ProtocolError ) 
        {
            Debug.LogWarning( request.error + "\n" + filePath );
        } 
        else 
        {
            myClips.Add(DownloadHandlerAudioClip.GetContent( request ));
            myClips[myClips.Count - 1].name = Path.GetFileNameWithoutExtension(filename);
        }
    }

    IEnumerator GetTexture2D(string filename)
    {
        string filePath = Path.Combine(Application.streamingAssetsPath, filename);
        using (UnityWebRequest uwr = UnityWebRequestTexture.GetTexture(filePath))
        {
            yield return uwr.SendWebRequest();

            if (uwr.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(uwr.error);
            }
            else
            {
                stuff.Add(DownloadHandlerTexture.GetContent(uwr));
                stuff[stuff.Count - 1].name = Path.GetFileNameWithoutExtension(filename);
            }
        }
    }

    public string[] files;
    public AudioSource audioSource;
    public List<AudioClip> myClips;
    public List<Texture2D> stuff;
    public string url;
    public Texture2D tex;
}
