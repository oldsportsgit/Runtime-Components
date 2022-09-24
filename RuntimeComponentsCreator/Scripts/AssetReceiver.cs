using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Audio;
using TMPro;

namespace RuntimeComponents.AssetBundle
{
 public class AssetReceiver : MonoBehaviour
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

    public static RenderTexture GetRenderTextureByName(string name)
    {
        RenderTexture[] RenderTextures = Resources.FindObjectsOfTypeAll(typeof(RenderTexture)) as RenderTexture[];
        RenderTexture RenderTexturevar = null;
        for (int i = 0; i < RenderTextures.Length; i++)
        {
            if (RenderTextures[i].name == name)
            {
                RenderTexturevar = RenderTextures[i];
            }
        }
        return RenderTexturevar;
    }

    public static AudioMixer GetaudioMixerByName(string name)
    {
        AudioMixer[] AudioMixers = Resources.FindObjectsOfTypeAll(typeof(AudioMixer)) as AudioMixer[];
        AudioMixer AudioMixervar = null;
        for (int i = 0; i < AudioMixers.Length; i++)
        {
            if (AudioMixers[i].name == name)
            {
               AudioMixervar = AudioMixers[i];
            }
        }
        return AudioMixervar;
    }

    public static AudioMixerSnapshot GetaudioMixerSnapshotByName(string name)
    {
        AudioMixerSnapshot[] AudioMixerSnapshots = Resources.FindObjectsOfTypeAll(typeof(AudioMixerSnapshot)) as AudioMixerSnapshot[];
        AudioMixerSnapshot AudioMixerSnapshotvar = null;
        for (int i = 0; i < AudioMixerSnapshots.Length; i++)
        {
            if (AudioMixerSnapshots[i].name == name)
            {
               AudioMixerSnapshotvar = AudioMixerSnapshots[i];
            }
        }
        return AudioMixerSnapshotvar;
    }

    public static AudioMixerGroup GetaudioMixerGroupByName(string name)
    {
        AudioMixerGroup[] AudioMixerGroups = Resources.FindObjectsOfTypeAll(typeof(AudioMixerGroup)) as AudioMixerGroup[];
        AudioMixerGroup AudioMixerGroupvar = null;
        for (int i = 0; i < AudioMixerGroups.Length; i++)
        {
            if (AudioMixerGroups[i].name == name)
            {
                AudioMixerGroupvar = AudioMixerGroups[i];
            }
        }
        return AudioMixerGroupvar;
    }

    public static LightProbes GetLightProbesByName(string name)
    {
        LightProbes[] lightProbes = Resources.FindObjectsOfTypeAll(typeof(LightProbes)) as LightProbes[];
        LightProbes LightProbesvar = null;
        for (int i = 0; i < lightProbes.Length; i++)
        {
            if (lightProbes[i].name == name)
            {
                LightProbesvar = lightProbes[i];
            }
        }
        return LightProbesvar;
    }

    public static Texture2D GetTexture2DByName(string name)
    {
        Texture2D[] Texture2Ds = Resources.FindObjectsOfTypeAll(typeof(Texture2D)) as Texture2D[];
        Texture2D Texture2Dvar = null;
        for (int i = 0; i < Texture2Ds.Length; i++)
        {
            if (Texture2Ds[i].name == name)
            {
                Texture2Dvar = Texture2Ds[i];
            }
        }
        return Texture2Dvar;
    }
 }
}