using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorHabla : MonoBehaviour
{
    GameObject cursor;
    public static bool cinematica;
    private void Start()
    {
        cursor = GameObject.FindWithTag("cursor");
        if(pajar.juanasequema == false)
        {
            cinematica = true;
            cursor.GetComponent<cursor>().hablando = false;
        }
        if (cinematica == false)
        {
            cursor.GetComponent<cursor>().hablando = false;
        }
        
    }
    private void OnMouseOver()
    {
        cursor.GetComponent<cursor>().hablando = true;
    }
    private void OnMouseExit()
    {
        cursor.GetComponent<cursor>().hablando = false;
        cursor.GetComponent<cursor>().rend.sprite = cursor.GetComponent<cursor>().normalcursor;
    }
}
