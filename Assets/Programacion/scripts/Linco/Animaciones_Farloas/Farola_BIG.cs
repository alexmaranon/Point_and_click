using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farola_BIG : MonoBehaviour
{

    public bool dentro;
    public GameObject buho;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnMouseDown()
    {
        if (dentro == true)
        {
            Debug.Log("aa");
            buho.GetComponent<Animator>().SetBool("Jump_big", true);
            StartCoroutine("Delay");
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "character")
        {
            Debug.Log("hh");
            dentro = true;
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(5);
        buho.GetComponent<Animator>().SetBool("Jump_big", false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
