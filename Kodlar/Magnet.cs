using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    private Transform player;
    public Karakterkontrol ka;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("karakter").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ka.ismagnet == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, 3);
        }
        if (ka.ismagnet == false)
        {

        }
    }
}
