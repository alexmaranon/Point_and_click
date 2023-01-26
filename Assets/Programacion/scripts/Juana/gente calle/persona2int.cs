using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class persona2int : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    IEnumerator pausas()
    {
        callejuana.para2a = true;
        yield return new WaitForSeconds(0.1f);
        callejuana.para2a = false;

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
