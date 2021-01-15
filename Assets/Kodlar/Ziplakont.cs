using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Ziplakont : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool ziplamak, harekett,ziplaa;
    public GameObject krkt;
    void Start()
    {
        
    }
    public void OnPointerDown(PointerEventData data)
    {

        if (krkt.transform.position.y < 1 )
        {
            ziplamak = true;
            if (krkt.transform.position.y >0.5f)
            {
                ziplamak = false;
            }
            
        }
            //Ziplakapat();
            harekett = true;
        //Invoke("Ziplakapat", 1.0f);
    }
    
    public void OnPointerUp(PointerEventData data)
    {
        ziplamak = false;
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "tavan")
        {
            ziplaa = true;
        }
        else
        {
            ziplaa = false;
        }
        
    }
    public void Ziplakapat()
    {

        
        /*if(ziplaa == true)
        {
            ziplamak = true;
        }
        if (ziplaa == false)
        {
            ziplamak = false;
        }*/

    }
}
    
