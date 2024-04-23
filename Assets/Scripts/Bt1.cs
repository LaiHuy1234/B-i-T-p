using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bt1 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("A"))
        {
            print("A");
        }
        if (Input.GetKey("B"))
        {
            print("B");
        }
        if (Input.GetKey("C"))
        {
            print("C");
        }
    }
}
