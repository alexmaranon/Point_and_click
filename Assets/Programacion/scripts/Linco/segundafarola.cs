using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class segundafarola : MonoBehaviour
{
    public static bool clicar2;
    // Start is called before the first frame update

    IEnumerator cliccc()
    {
        clicar2 = true;
        yield return new WaitForSeconds(0.1f);
        clicar2 = false;
    }
    private void OnMouseDown()
    {
        StartCoroutine("cliccc");
    }
}
