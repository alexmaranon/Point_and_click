using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iglesia : MonoBehaviour
{
    public List<GameObject> dete1 = new List<GameObject> { };
    public List<GameObject> cardenal1 = new List<GameObject> { };
    public static bool cardenalhablado;
    public GameObject monedass;
    public GameObject fotaca;
    public static bool minijuego2hecho;
    public static bool yatienesfoto;
    void Start()
    {
        if (pajar.juanasequema == true&&yatienesfoto==false)
        {
            fotaca.SetActive(true);
        }
        
        if (minijuego2hecho == true)
        {
            monedass.SetActive(false);
        }   
    }
    IEnumerator moneda()
    {
        minijuego2hecho = true;
        CharacterMovement.movimiento = false;
        CharacterMovement.speed = 0f;
        yield return new WaitForSeconds(1);
        dete1[4].SetActive(true);
        yield return new WaitForSeconds(3);
        dete1[4].SetActive(false);
        monedass.SetActive(false);
        CharacterMovement.movimiento = true;

    }
    IEnumerator fota()
    {
        yatienesfoto = true;
        CharacterMovement.movimiento = false;
        CharacterMovement.speed = 0f;
        yield return new WaitForSeconds(2);
        fotaca.SetActive(false);
        CharacterMovement.movimiento = true;
    }
    IEnumerator personaje1()
    {
        if (cardenalhablado==false)
        {
            CharacterMovement.movimiento = false;
            CharacterMovement.speed = 0f;
            cardenalhablado = true;
            yield return new WaitForSeconds(1);
            cardenal1[0].SetActive(true);
            yield return new WaitForSeconds(4);
            cardenal1[0].SetActive(false);
            dete1[0].SetActive(true);
            yield return new WaitForSeconds(4);
            dete1[0].SetActive(false);
            cardenal1[1].SetActive(true);
            yield return new WaitForSeconds(4);
            cardenal1[1].SetActive(false);
            dete1[1].SetActive(true);
            yield return new WaitForSeconds(4);
            dete1[1].SetActive(false);
            cardenal1[2].SetActive(true);
            yield return new WaitForSeconds(4);
            cardenal1[2].SetActive(false);
            dete1[2].SetActive(true);
            yield return new WaitForSeconds(4);
            dete1[2].SetActive(false);
            cardenal1[3].SetActive(true);
            yield return new WaitForSeconds(3);
            cardenal1[3].SetActive(false);
            dete1[3].SetActive(true);
            yield return new WaitForSeconds(3);
            dete1[3].SetActive(false);
            CharacterMovement.movimiento = true;
            CharacterMovement.volvertiempo = false;
            yield return new WaitForSeconds(1);
            cardenal1[4].SetActive(true);
        }


    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "oso"&&callejuana.para1a == true)
        {
            StartCoroutine("personaje1");
        }
        if (collision.gameObject.tag == "toro" && callejuana.para4a == true&&callejuana.minijuego2==true)
        {
            StartCoroutine("moneda");
        }
        if (collision.gameObject.tag == "ciervos" &&pajar.juanasequema==true&&callejuana.para3a==true)
        {
            StartCoroutine("fota");
        }
    }
}
