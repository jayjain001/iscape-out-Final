using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http.Headers;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class audio : MonoBehaviour
{
    public AudioMixer audiomix;
    public Dropdown resolutiondrop;
    Resolution[] resolutions;
    public void Start()
    {
        resolutions = Screen.resolutions;
        resolutiondrop.ClearOptions();
        List<string> option = new List<string>();
        int currentres = 0;
        for(int i = 0; i < resolutions.Length; i++)
        {
           string options = resolutions[i].width + "x" + resolutions[i].height;
            option.Add(options);
            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentres = i;
            }
        }
        resolutiondrop.AddOptions(option);
        resolutiondrop.value = currentres;  
        resolutiondrop.RefreshShownValue();
    }
    public void volumecontrol(float volume)
    {
        audiomix.SetFloat("master",volume); 
    }
    public void quality (int quality)
    {
        QualitySettings.SetQualityLevel(quality);   
    }
    public void full(bool isfullscreen)
    {
        Screen.fullScreen = isfullscreen;   
    }
    public void setres(int resolutionindex)
    {
       Resolution resolution = resolutions[resolutionindex];    
        Screen.SetResolution(resolution.width, resolution.height,Screen.fullScreen);  
    }
    
}
