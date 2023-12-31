using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudiosList : MonoBehaviour
{
    public AudioClip errorAudio;
    [System.Serializable]
    public struct Idioma
    {
        public string language;
        public AudioClip[] Audios;
    }
    public Idioma[] idiomas;
    
    public AudioClip getAudioClip(int code)
    {
        if (idiomas[ConfigManager.instance.getLanguageCode()].Audios.Length >= code && code >= 0)
        {
            if (idiomas[ConfigManager.instance.getLanguageCode()].Audios[code] != null)
                return idiomas[ConfigManager.instance.getLanguageCode()].Audios[code];
        }
        return errorAudio;
    }
    public int idiomasCount()
    {
        return idiomas[0].Audios.Length;
    }
}
