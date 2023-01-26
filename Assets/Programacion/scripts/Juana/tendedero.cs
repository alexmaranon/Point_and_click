using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tendedero : MonoBehaviour
{
    public static bool tendederos;
    IEnumerator pausas()
    {
        tendederos = true;
        yield return new WaitForSeconds(0.1f);
        tendederos = false;

    }
    private void OnMouseDown()
    {
        StartCoroutine("pausas");
    }
}
