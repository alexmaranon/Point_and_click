using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caliz : MonoBehaviour
{
    public GameObject jarras;
    bool clickar;
    public static bool cadiz;
    public GameObject texto;
    // Start is called before the first frame update
    void Start()
    {
        
        if (cadiz==true)
        {
            jarras.SetActive(true);
            gameObject.SetActive(false);

            
            gameObject.GetComponent<BoxCollider2D>().enabled = false;

        }
    }
    IEnumerator wait()
    {
        if (clickar == false)
        {
            clickar = true;
            yield return new WaitForSeconds(1f);
            clickar = false;
        }

    }
    IEnumerator parar()
    {

        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        CharacterMovement.movimiento = false;
       

        yield return new WaitForSeconds(2);

        CharacterMovement.movimiento = true;
        jarras.SetActive(true);
        gameObject.SetActive(false);
        cadiz = true;

    }
    IEnumerator cambiar()
    {
        CharacterMovement.movimiento = false;
        CharacterMovement.speed = 0f;
        yield return new WaitForSeconds(1);
        texto.SetActive(true);
        yield return new WaitForSeconds(4);
        CharacterMovement.movimiento = true;
        
        texto.SetActive(false);

    }
    private void OnMouseDown()
    {
        StartCoroutine("wait");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "character" && taverna.jarra == false)
        {
            if (clickar == true)
            {
                StartCoroutine("cambiar");

            }


        }
        if (collision.gameObject.tag == "character" && taverna.jarra == true && CharacterMovement.volvertiempo == true)
        {
            if (clickar == true)
            {
                StartCoroutine("parar");

            }
        }
    }
}
