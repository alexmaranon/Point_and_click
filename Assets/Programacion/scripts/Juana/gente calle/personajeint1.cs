using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personajeint1 : MonoBehaviour
{
    // Start is called before the first frame update

    IEnumerator pausas()
    {
        callejuana.para1a = true;
        yield return new WaitForSeconds(0.1f);
        callejuana.para1a = false;

    }
    private void OnMouseDown()
    {
        StartCoroutine("pausas");
    }
    // Update is called once per frame
  
}
