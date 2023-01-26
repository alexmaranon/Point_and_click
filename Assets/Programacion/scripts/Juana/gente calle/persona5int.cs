using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class persona5int : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    IEnumerator pausas()
    {
        callejuana.para5a = true;
        yield return new WaitForSeconds(0.1f);
        callejuana.para5a = false;

    }
    private void OnMouseDown()
    {
        StartCoroutine("pausas");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
