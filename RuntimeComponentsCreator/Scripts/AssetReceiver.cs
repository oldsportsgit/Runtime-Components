using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using TMPro;

public class AssetReceiver 
{
    public static Material GetMaterialByName(string name)
    {
       Material[] Materials = Resources.FindObjectsOfTypeAll(typeof(Material)) as Material[];
       Material matvar = null;
       for (int i = 0; i < Materials.Length; i++)
       {
            if (Materials[i].name == name)
            {
                matvar = Materials[i];
            }
       }
       return matvar;
    }

    public static AudioClip GetAudioClipByName(string name)
    {
        AudioClip[] AudioClips = Resources.FindObjectsOfTypeAll(typeof(AudioClip)) as AudioClip[];
        AudioClip AudioClipvar = null;
        for (int i = 0; i < AudioClips.Length; i++)
        {
            if (AudioClips[i].name == name)
            {
                AudioClipvar = AudioClips[i];
            }
        }
        return AudioClipvar;
    }

    public static RuntimeAnimatorController GetRuntimeAnimatorControllerByName(string name)
    {
        RuntimeAnimatorController[] RuntimeAnimatorControllers = Resources.FindObjectsOfTypeAll(typeof(RuntimeAnimatorController)) as RuntimeAnimatorController[];
        RuntimeAnimatorController RuntimeAnimatorControllervar = null;
        for (int i = 0; i < RuntimeAnimatorControllers.Length; i++)
        {
            if (RuntimeAnimatorControllers[i].name == name)
            {
                RuntimeAnimatorControllervar = RuntimeAnimatorControllers[i];
            }
        }
        return RuntimeAnimatorControllervar;
    }

    public static AnimationClip GetAnimationClipByName(string name)
    {
        AnimationClip[] AnimationClips = Resources.FindObjectsOfTypeAll(typeof(AnimationClip)) as AnimationClip[];
        AnimationClip AnimationClipvar = null;
        for (int i = 0; i < AnimationClips.Length; i++)
        {
            if (AnimationClips[i].name == name)
            {
                AnimationClipvar = AnimationClips[i];
            }
        }
        return AnimationClipvar;
    }

    public static Mesh GetMeshByName(string name)
    {
        Mesh[] Meshes = Resources.FindObjectsOfTypeAll(typeof(Mesh)) as Mesh[];
        Mesh Meshvar = null;
        for (int i = 0; i < Meshes.Length; i++)
        {
            if (Meshes[i].name == name)
            {
                Meshvar = Meshes[i];
            }
        }
        return Meshvar;
    }

    public static Font GetFontByName(string name)
    {
        Font[] Fonts = Resources.FindObjectsOfTypeAll(typeof(Font)) as Font[];
        Font Fontvar = null;
        for (int i = 0; i < Fonts.Length; i++)
        {
            if (Fonts[i].name == name)
            {
                Fontvar = Fonts[i];
            }
        }
        return Fontvar;
    }

    public static TMP_FontAsset GetTMPFontAssetByName(string name)
    {
        TMP_FontAsset[] TMP_FontAssets = Resources.FindObjectsOfTypeAll(typeof(TMP_FontAsset)) as TMP_FontAsset[];
        TMP_FontAsset TMP_FontAssetvar = null;
        for (int i = 0; i < TMP_FontAssets.Length; i++)
        {
            if (TMP_FontAssets[i].name == name)
            {
                TMP_FontAssetvar = TMP_FontAssets[i];
            }
        }
        return TMP_FontAssetvar;
    }

    public static Sprite GetSpriteByName(string name)
    {
        Sprite[] Sprites = Resources.FindObjectsOfTypeAll(typeof(Sprite)) as Sprite[];
        Sprite Spritevar = null;
        for (int i = 0; i < Sprites.Length; i++)
        {
            if (Sprites[i].name == name)
            {
                Spritevar = Sprites[i];
            }
        }
        return Spritevar;
    }

    public static VideoClip GetVideoClipByName(string name)
    {
        VideoClip[] VideoClips = Resources.FindObjectsOfTypeAll(typeof(VideoClip)) as VideoClip[];
        VideoClip VideoClipvar = null;
        for (int i = 0; i < VideoClips.Length; i++)
        {
            if (VideoClips[i].name == name)
            {
                VideoClipvar = VideoClips[i];
            }
        }
        return VideoClipvar;
    }
}
