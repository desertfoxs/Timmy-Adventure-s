using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class settingMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioMixer audio;
  public void Volumen(float volumen)
    {
        audio.SetFloat("volumen",volumen);
        Debug.Log(volumen);

    }
}
