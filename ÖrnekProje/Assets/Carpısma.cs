using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Carpısma : MonoBehaviour
{

  
    public Rigidbody rb3;
    public int skor_1=0;
    public int skor_2=0;
    public TextMeshProUGUI skorYazisi1,skorYazisi2;
    public AudioSource golsesi;
    
    public string lastCollision = "" ;
    public string nextCollision = "" ; 

    void Start()
    {
       rb3 = GetComponent<Rigidbody>();
       
       
    }
    
  
  
    public void OnCollisionEnter(Collision collision)
    {

         lastCollision = nextCollision;
        nextCollision = collision.gameObject.tag;

        if (collision.collider.tag == "solkale")
        {
            skor_1 += 1;
            skorYazisi1.text ="Skor: " + skor_1.ToString();
            Debug.Log("solkale ile çarpışma gerçekleştirildi");
            golsesi.Play(); 
            transform.position = new Vector3(-24.5f ,1.91f ,1.4f);   //topu oyun başlatıldığında bulunduğu ilk konuma tekrar geri getirme          
        } 
         if (collision.collider.tag == "sagkale")
        {
            skor_2 += 1;
            skorYazisi2.text ="Skor: " + skor_2.ToString();
            Debug.Log("sagkale ile çarpışma gerçekleştirildi");
            golsesi.Play();
             transform.position = new Vector3(-24.5f ,1.91f ,1.4f); 
        } 

    
    //karakterlerin çarpmasıyla ters yöne 2 kat hızda gitmesi
    
       
         
       
         if (lastCollision == "Oyuncu1" && nextCollision == "Oyuncu2") {
            Debug.Log("Birinci koşul sağlandı");
            Vector3 tersYon = -collision.relativeVelocity;
            Vector3 vector3 = tersYon * 2;
            rb3.velocity = vector3;
        }
        
        
        else if (lastCollision == "Oyuncu2" && nextCollision == "Oyuncu1") {
            Debug.Log("İkinci koşul sağlandı");
            Vector3 tersYon = -collision.relativeVelocity;
            Vector3 vector3 = tersYon * 2;
            rb3.velocity = vector3;
        }
       
        
       else {
        Debug.Log("Sonuncu koşul sağlandı");
      Vector3 duzYon = collision.relativeVelocity;
           rb3.velocity = duzYon * 1;
       }
      
   }
   
       
}      
    
   
   
       



