using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Yeniden_basla : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    
    void Start()
    {
        
    }
    public void OnPointerDown(PointerEventData data)
    {
        SceneManager.LoadScene("Elvis_Sahne");
       
    }
    public void OnPointerUp(PointerEventData data)
    {
        

    }
    
    void Update()
    {
        
    }
}
