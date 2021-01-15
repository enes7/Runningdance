using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class Sahneler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Karakterkontrol ka;
    public bool eksi,eksid,eksit,eksib,eksig,eksik;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnPointerDown(PointerEventData data)
    {
        Elvisac();
        Guresciac();
        Buyucuac();
        Fareac();
        Dozzyac();
        Kadınac();
        Tavukac();
    }
    public void OnPointerUp(PointerEventData data)
    {


    }

    public void Fareac()
    {
        if (ka.kilitlifare == false)
        {
            SceneManager.LoadScene("Fare_Sahne");
            eksi = true;
        }
        
    }
    public void Tavukac()
    {
        if (ka.kilitlitavuk == false)
        {
            SceneManager.LoadScene("Tavuk_Sahne");
            eksit = true;
            
        }

    }
    public void Savasciac()
    {
        if (ka.kilitlitavuk == false)
        {
            SceneManager.LoadScene("Savasci_Sahne");
            eksit = true;

        }

    }
    public void Elvisac()
    {
        
        SceneManager.LoadScene("Elvis_Sahne");
    }
    public void Buyucuac()
    {
        if (ka.kilitlibuyucu == false)
        {
            SceneManager.LoadScene("Buyucu_Sahne");
            eksib = true;
        }
        
    }
    public void Guresciac()
    {
        if (ka.kilitliguresci == false)
        {
            SceneManager.LoadScene("Guresci_Sahne");
            eksig = true;
        }
        
    }
    public void Dozzyac()
    {
        if (ka.kilitlidozzy == false)
        {
            SceneManager.LoadScene("Dozzy_Sahne");
            eksid = true;
        }
        
    }
    public void Kadınac()
    {
        if (ka.kilitlikadin == false)
        {
            SceneManager.LoadScene("Kadın_Sahne");
            eksik = true;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
