using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trilero : MonoBehaviour
{
    public static bool perdio=false;
    public static bool binoculares;
    public static bool otro=false;
    public static bool clik = false;
    public List<GameObject> dete = new List<GameObject> { };
    public GameObject primeraper;
    public GameObject primerapers;
    public GameObject segundaper;
    public GameObject segundapers;
    public GameObject acabo;
    public static bool noperder;
    // Start is called before the first frame update
    void Start()
    {
        if (binoculares == true)
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
    IEnumerator primera()
    {
        primeraper.SetActive(true);
        callejondialogo.primeraapuesta = true;
        CharacterMovement.movimiento = false;
        CharacterMovement.speed = 0f;
        CharacterMovement.monedascontar--;
        if (CharacterMovement.monedascontar == 0)
        {
            CharacterMovement.trileros = false;
            Debug.Log("No se inicia");
        }
        perdio = true;
        yield return new WaitForSeconds(2);
        otro = true;
        primeraper.SetActive(false);
        primerapers.SetActive(true);
        yield return new WaitForSeconds(3);
        primerapers.SetActive(false);

        CharacterMovement.movimiento = true;
        Debug.Log(CharacterMovement.monedascontar);
    }
    IEnumerator segunda()
    {
        primeraper.SetActive(true);
        CharacterMovement.movimiento = false;
        CharacterMovement.speed = 0f;
        CharacterMovement.trileros = false;
        yield return new WaitForSeconds(4);
        primeraper.SetActive(false);
        segundaper.SetActive(true);
        yield return new WaitForSeconds(4);
        segundaper.SetActive(false);
        dete[0].SetActive(true);
        yield return new WaitForSeconds(4);
        dete[0].SetActive(false);
        dete[1].SetActive(true);
        yield return new WaitForSeconds(4);
        dete[1].SetActive(false);
        segundapers.SetActive(true);
        yield return new WaitForSeconds(4);
        segundapers.SetActive(false);
        binoculares = true;
        Debug.Log("tienes los binoculares");
        CharacterMovement.movimiento = true;
        noperder = true;
    }
    IEnumerator pulsar()
    {
        clik = true;
        yield return new WaitForSeconds(1);
        clik = false;

    }
    private void OnMouseDown()
    {
        StartCoroutine("pulsar");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "character")
        {
            if (clik == true && CharacterMovement.trileros == true&&callejondialogo.apostar==true)
            {
                if (perdio == false)
                {
                    StartCoroutine("primera");
                }
                if (otro == true && CharacterMovement.trileros == true)
                {
                    StartCoroutine("segunda");
                }
            }
            if (noperder == true)
            {
                acabo.SetActive(true);
            }
        }
    }
   
}
