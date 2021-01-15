using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Kirmizisecim : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject kirmizi, beyaz, yesil,sari,ktik,ytik,stik;
    public bool kirmizlik=false,yesillik=false,sarilik=false;

    
    public void OnPointerDown(PointerEventData data)
    {
        
        if (gameObject.tag == "kirmizik")
        {
            kirmizi.gameObject.SetActive(true);
            yesil.gameObject.SetActive(false);
            sari.gameObject.SetActive(false);
            ktik.gameObject.SetActive(true);
            ytik.gameObject.SetActive(false);
            stik.gameObject.SetActive(false);
            kirmizlik = true;
            yesillik = false;
            sarilik = false;
            beyaz.gameObject.SetActive(false);
        }
        if (gameObject.tag == "yesilk")
        {
            yesil.gameObject.SetActive(true);
            kirmizi.gameObject.SetActive(false);
            sari.gameObject.SetActive(false);
            ytik.gameObject.SetActive(true);
            ktik.gameObject.SetActive(false);
            stik.gameObject.SetActive(false);
            yesillik = true;
            kirmizlik = false;
            sarilik = false;
            beyaz.gameObject.SetActive(false);
        }
        if (gameObject.tag == "sarik")
        {
            sari.gameObject.SetActive(true);
            yesil.gameObject.SetActive(false);
            kirmizi.gameObject.SetActive(false);
            stik.gameObject.SetActive(true);
            ktik.gameObject.SetActive(false);
            ytik.gameObject.SetActive(false);
            sarilik = true;
            yesillik = false;
            kirmizlik = false;
            beyaz.gameObject.SetActive(false);
        }

    }
    /*public void Tikler()
    {
        if (kirmizlik == true)
        {
            kirmizi.gameObject.SetActive(true);
            yesil.gameObject.SetActive(false);
            sari.gameObject.SetActive(false);
        }
        
        if (yesillik == true)
        {
            yesil.gameObject.SetActive(true);
            kirmizi.gameObject.SetActive(false);
            sari.gameObject.SetActive(false);
        }
        if (sarilik == true)
        {
            sari.gameObject.SetActive(true);
            yesil.gameObject.SetActive(false);
            kirmizi.gameObject.SetActive(false);
        }
    }*/
    public void Update()
    {
        //Tikler();
    }
    public void OnPointerUp(PointerEventData data)
    {


    }
}
