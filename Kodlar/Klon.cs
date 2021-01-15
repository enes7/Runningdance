using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Klon : MonoBehaviour
{
    public float sagkisim= -570.076f;
    public Karakterkontrol ka;
    public float solkisim= -570.767f;
    public float ortakisim= 17.73f;
    public GameObject gitar, danss,engel;
    public Transform karakter;
    int altin;
    //public Karakterkontrol karakterkont;
    public RaycastHit hit1;
    void Start()
    {
        
        InvokeRepeating("Klonla", 0, 3.0f);
        InvokeRepeating("Klonla2", 0, 10.0f);
        InvokeRepeating("Klonla3", 0, 5.0f);
        if (ka.altinsayisi < 20)
        {
            InvokeRepeating("Klonla1", 0, 2.5f);
        }
        if (ka.altinsayisi >= 20)
        {
            InvokeRepeating("Klonla1", 0, 2.0f);
        }
        if (ka.altinsayisi >= 40)
        {
            InvokeRepeating("Klonla1", 0, 1.3f);
        }
        if (ka.altinsayisi >= 60)
        {
            InvokeRepeating("Klonla1", 0, 1.0f);
        }
    }
    private void Update()
    {
        
        
    }
    public void Klonla()
    {
        int sayi = Random.Range(0, 100);
        
        if(sayi > 0 && sayi < 100)
        {
            Olustur(gitar, 0.3f);
        }
        
        
    }
    public void Klonla1()
    {
        
        if (ka.engelkaldir == false)
        {
            int sayi = Random.Range(0, 100);

            Olustur(engel, 0.3f);

            if (sayi > 20)
            {

            }
        }
        
    }
    
    public void Klonla2()
    {
        int sayi2 = Random.Range(0, 100);
        if (sayi2 > 60)
        {
            Olustur(danss, 0.3f);
        }
    }
    /*public void Klonla3()
    {
        int sayi2 = Random.Range(0, 100);
        if (sayi2 > 60)
        {
            Olustur(rampa, 0.1f);
        }
    }*/

    public void Olustur(GameObject nesne,float ust)
    {
        GameObject yeniklon = Instantiate(nesne);
        int sayi = Random.Range(0, 100);

        if (sayi<70)
        {
            yeniklon.transform.position = new Vector3(sagkisim, ust, karakter.position.z + 5);
            
            
        }
        if (sayi > 70)
        {
            yeniklon.transform.position = new Vector3(solkisim, ust, karakter.position.z + 8);
        }
        if (sayi < 30)
        {
            yeniklon.transform.position = new Vector3(ortakisim, ust, karakter.position.z + 10);
        }
    }
    /*public void EngelSil()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit1, 5))
        {
            if (hit1.transform.tag == "engel")
            {
               
                if (karakterkont.engelkaldir==true)
                {

                    Destroy(hit1.transform.gameObject);

                }
            }

        }
    }*/
}
