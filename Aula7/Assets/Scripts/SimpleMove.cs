using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    public float Speed;
    public string SomeString = "Este é um teste";
    internal bool SomeSetting = true;
    public GameObject SomeObject;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(2f * Time.deltaTime, 0f, 0f);   
    }
}
