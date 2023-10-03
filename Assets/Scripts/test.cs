using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class test : MonoBehaviour
{
    public int summery;
    void bla(int num1, int num2)
    {
        summery = num1 + num2;
        Debug.Log(summery);
    }

    void Start()
    {
        bla(2, 45);
        bla(6, 2);
    }
    
}
