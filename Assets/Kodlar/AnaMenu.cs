using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AnaMenu : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject dolapmenusu,baslangicmenusu;
    public void OnPointerDown(PointerEventData data)
    {
        baslangicmenusu.gameObject.SetActive(true);
        dolapmenusu.gameObject.SetActive(false);


    }
    public void OnPointerUp(PointerEventData data)
    {


    }
}

