using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Giysidolap : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject dolapmenu;
    public void OnPointerDown(PointerEventData data)
    {
        dolapmenu.gameObject.SetActive(true);
        


    }
    public void OnPointerUp(PointerEventData data)
    {
       

    }
}
