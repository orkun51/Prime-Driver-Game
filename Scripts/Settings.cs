using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Settings : MonoBehaviour
{
       
   public void Start() 
   {       
        QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("Quality"));
   }
   List<int> widths = new List<int>() {580 , 960, 1280,1920};
    List<int> heights = new List<int>() {320 , 540, 800,1080};

    public void SetScreenSize(int index)
    {
        bool fullscreen = Screen.fullScreen;
        int width = widths[index];
        int height = heights[index];
        Screen.SetResolution(width,height, fullscreen);
    }
    public void SetfullScreen( bool _fullscreen)
    {
        Screen.fullScreen = _fullscreen;
    }

    public void  Quality(int Qual)
    {
        PlayerPrefs.SetInt("Quality", Qual);
        QualitySettings.SetQualityLevel(Qual);
    }
}
