using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Oyuna_basla : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject baslangic;
    void Start()
    {

    }
    public void OnPointerDown(PointerEventData data)
    {
        baslangic.gameObject.SetActive(false);

    }
    public void OnPointerUp(PointerEventData data)
    {


    }

    void Update()
    {

    }
}
