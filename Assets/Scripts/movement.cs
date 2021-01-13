using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public bool isPlayer1;
    public float speed = 5f;


    void Start()
    {
     
 
    }


    void Update()
    {
        if (isPlayer1)
            transform.Translate(0f, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0f);  //(0f, 5f, 8f)
        else
            transform.Translate(0f, Input.GetAxis("Vertical2") * speed * Time.deltaTime, 0f);



    }
}
