using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SesAyar : MonoBehaviour
{

   public Slider sesSlider;

   void Start()
   {
    SesiCagir();
   }
  public void SetAudio(float value)
    {
        AudioListener.volume = value;
        SesKayit();
    }
   public void SesKayit()
   {
    PlayerPrefs.SetFloat("volume",AudioListener.volume);
   }

 //kullanıcının bir önceki belirlediği ses düzeyi kayıtlı olarak kalmaktadır.
    private void SesiCagir()
    {
      if(PlayerPrefs.HasKey("volume"))
    {
       AudioListener.volume = PlayerPrefs.GetFloat("volume");
       sesSlider.value =PlayerPrefs.GetFloat("volume");
    } 

    else 
    {
        PlayerPrefs.SetFloat("volume", 0.5f);
    }
   
   
}
   }