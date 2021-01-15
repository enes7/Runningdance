using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject pausemenu,pausebut;
    public Karakterkontrol ka;
    public bool durak=false;
    void Start()
    {
        
    }
    public void OnPointerDown(PointerEventData data)
    {
        Durdur();
        Devamettir();
        ANAMENU();
    }
    public void OnPointerUp(PointerEventData data)
    {


    }

    public void Durdur()
    {
        
        durak = true;
        ka.karakteranim.SetBool("duraklat", true);
        pausemenu.gameObject.SetActive(true);
        pausebut.gameObject.SetActive(false);
    }
    public void Devamettir()
    {
        Invoke("DP", 2.0f);
        
        ka.karakteranim.SetBool("duraklat", false);
        pausemenu.gameObject.SetActive(false);
        pausebut.gameObject.SetActive(true);
    }
    public void DP()
    {
        durak = false;
    }

    public void ANAMENU()
    {
        SceneManager.LoadScene("Elvis_Sahne");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
