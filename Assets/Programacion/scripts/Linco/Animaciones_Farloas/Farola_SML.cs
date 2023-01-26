using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farola_SML : MonoBehaviour
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
            Debug.Log("todo");
            buho.GetComponent<Animator>().SetBool("Jump_sml", true);
            StartCoroutine("Delay");
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "character")
        {
            Debug.Log("stay");
            dentro = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "character")
        {
            Debug.Log("exit");
            dentro = false;
        }
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(5);
        buho.GetComponent<Animator>().SetBool("Jump_sml", false);
    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
