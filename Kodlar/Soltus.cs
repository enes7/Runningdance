using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Soltus : MonoBehaviour , IPointerDownHandler,IPointerUpHandler
{
    public bool sol;
    void Start()
    {
        
    }
    public void OnPointerDown(PointerEventData data)
    {
        sol = true;
    }
    public void OnPointerUp(PointerEventData data)
    {
        sol = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
