using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class FireManager : MonoBehaviour
{
    private float nextTime = 0;
    public GameObject prefabs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetButton("Fire1"))
        {
            Debug.Log("Fire1");
        }
        if (Input.GetButton("Fire2"))
        {
            Debug.Log("Fire2");
        }
        if (Input.GetButton("Fire3"))
        {
            Debug.Log("Fire3");
        }*/
        /*if(Input.GetMouseButtonDown(0))
        {
            Debug.Log(0);
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(1);
        }
        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log(2);
        }*/
        if(Input.GetKey(KeyCode.W))
        {
            Debug.Log("Ngon");
        }
    }
}
