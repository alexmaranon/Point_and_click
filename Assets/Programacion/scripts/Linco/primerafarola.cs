using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class primerafarola : MonoBehaviour
{
    public static bool clicar;
    // Start is called before the first frame update

    IEnumerator cliccc()
    {
        clicar = true;
        yield return new WaitForSeconds(0.1f);
        clicar = false;
    }
    private void OnMouseDown()
    {
        StartCoroutine("cliccc");
    }
    // Update is called once per frame

}
