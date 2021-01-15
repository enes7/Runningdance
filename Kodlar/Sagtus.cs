using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Sagtus : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool sag;
    void Start()
    {
        
    }

    public void OnPointerDown(PointerEventData data)
    {
        sag = true;
    }
    public void OnPointerUp(PointerEventData data)
    {
        sag= false;
    }
    void Update()
    {
        
    }
}
