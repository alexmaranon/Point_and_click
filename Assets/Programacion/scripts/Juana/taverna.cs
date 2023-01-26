using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class taverna : MonoBehaviour
{
    public List<GameObject> cerdo = new List<GameObject> { };
    public List<GameObject> deveto = new List<GameObject> { };
    public List<GameObject> detect1 = new List<GameObject> { };
    public List<GameObject> detect2 = new List<GameObject> { };
    public List<GameObject> perso2 = new List<GameObject> { };
    public List<GameObject> guarda = new List<GameObject> { };
    public List<GameObject> opcion1 = new List<GameObject> { };
    public List<GameObject> opcion2 = new List<GameObject> { };
    public static bool guardano;
    public static bool cerdopare;
    public Button primeraopcion;
    public Button segundaopcion;
    public Button aceptar;
    public Button rechazar;
    public static bool primera=false;
    public static bool segunda = false;
    public static bool aceptasprimera = false;
    public static bool rechazasprimera = false;
    public static bool aceptassegunda = false;
    public static bool rechazassegunda = false;
    public static bool terminastees = false;
    public static bool haboalrcerdo;
    public static bool jarra;
    public GameObject pane;
    public GameObject espadas;
    IEnumerator entrar()
    {
        yield return new WaitForSeconds(0);

        CharacterMovement.movimiento = false;
        CharacterMovement.speed = 0f;

        yield return new WaitForSeconds(1);
            cerdo[0].SetActive(true);
            perso2[0].SetActive(true);
        yield return new WaitForSeconds(3);
        perso2[0].SetActive(false);
        cerdo[0].SetActive(false);


        CharacterMovement.movimiento = true;
    }
    IEnumerator saludo()
    {
        if (guardano == false)
        {
            guardano = true;
            yield return new WaitForSeconds(0);

            CharacterMovement.movimiento = false;
            CharacterMovement.speed = 0f;

            yield return new WaitForSeconds(1);
            guarda[0].SetActive(true);
            yield return new WaitForSeconds(3);
            guarda[0].SetActive(false);
            CharacterMovement.movimiento = true;
        }

    }
    IEnumerator oink()
    {
        if (cerdopare == false)
        {
            cerdopare = true;
            yield return new WaitForSeconds(0);

            CharacterMovement.movimiento = false;
            CharacterMovement.speed = 0f;

            yield return new WaitForSeconds(1);
            cerdo[1].SetActive(true);
            yield return new WaitForSeconds(3);
            cerdo[1].SetActive(false);
            deveto[0].SetActive(true);
            yield return new WaitForSeconds(3);
            deveto[0].SetActive(false);
            cerdo[2].SetActive(true);
            yield return new WaitForSeconds(3);
            cerdo[2].SetActive(false);

            CharacterMovement.movimiento = true;
        }
        
    }
    IEnumerator guardapulso1()
    {
        if (aceptasprimera == false && aceptassegunda == false && rechazasprimera == false && rechazassegunda == false)
        {
            if (primera == false && segunda == false)
            {
                yield return new WaitForSeconds(0);

                CharacterMovement.movimiento = false;
                CharacterMovement.speed = 0f;

                yield return new WaitForSeconds(1);
                guarda[1].SetActive(true);
                yield return new WaitForSeconds(3);
                guarda[1].SetActive(false);
                primeraopcion.gameObject.SetActive(true);
                segundaopcion.gameObject.SetActive(true);
            }

            if (primera == true)
            {
                CharacterMovement.movimiento = false;
                CharacterMovement.speed = 0f;
                yield return new WaitForSeconds(1);
                detect1[0].SetActive(true);
                yield return new WaitForSeconds(3);
                detect1[0].SetActive(false);
                opcion1[0].SetActive(true);
                yield return new WaitForSeconds(3);
                opcion1[0].SetActive(false);
                detect1[1].SetActive(true);
                yield return new WaitForSeconds(3);
                detect1[1].SetActive(false);
                opcion1[1].SetActive(true);
                yield return new WaitForSeconds(3);
                opcion1[1].SetActive(false);
                detect1[2].SetActive(true);
                yield return new WaitForSeconds(3);
                detect1[2].SetActive(false);
                opcion1[2].SetActive(true);

                yield return new WaitForSeconds(3);
                opcion1[2].SetActive(false);

                aceptar.gameObject.SetActive(true);
                rechazar.gameObject.SetActive(true);
            }
            if (segunda == true)
            {
                CharacterMovement.movimiento = false;
                CharacterMovement.speed = 0f;
                yield return new WaitForSeconds(1);
                detect2[0].SetActive(true);
                yield return new WaitForSeconds(3);
                detect2[0].SetActive(false);
                opcion2[0].SetActive(true);
                yield return new WaitForSeconds(3);
                opcion2[0].SetActive(false);
                aceptar.gameObject.SetActive(true);
                rechazar.gameObject.SetActive(true);
            }
        }
        if (terminastees == false)
        {
            if (aceptasprimera == true)
            {
                jarra = true;
                terminastees = true;
                CharacterMovement.movimiento = false;
                CharacterMovement.speed = 0f;
                yield return new WaitForSeconds(1);
                detect1[3].SetActive(true);
                yield return new WaitForSeconds(3);
                detect1[3].SetActive(false);
                yield return new WaitForSeconds(2);
                guarda[2].SetActive(true);
                yield return new WaitForSeconds(3);
                guarda[2].SetActive(false);
                CharacterMovement.movimiento = true;
                yield return new WaitForSeconds(2);
                guarda[3].SetActive(true);
                yield return new WaitForSeconds(3);
                guarda[3].SetActive(false);
                cerdo[3].SetActive(true);
                yield return new WaitForSeconds(3);
                cerdo[3].SetActive(false);
                
               
            }
            if (aceptassegunda == true)
            {
                jarra = true;
                terminastees = true;
                CharacterMovement.movimiento = false;
                CharacterMovement.speed = 0f;

                yield return new WaitForSeconds(1);
                detect2[1].SetActive(true);
                yield return new WaitForSeconds(3);
                detect2[1].SetActive(false);
                yield return new WaitForSeconds(3);
                guarda[2].SetActive(true);
                yield return new WaitForSeconds(3);
                guarda[2].SetActive(false);
                CharacterMovement.movimiento = true;
                yield return new WaitForSeconds(2);
                guarda[3].SetActive(true);
                yield return new WaitForSeconds(3);
                guarda[3].SetActive(false);
                cerdo[3].SetActive(true);
                yield return new WaitForSeconds(3);
                cerdo[3].SetActive(false);

            }
            if (rechazasprimera == true)
            {
                jarra = true;
                terminastees = true;
                CharacterMovement.movimiento = false;
                CharacterMovement.speed = 0f;
                yield return new WaitForSeconds(1);
                detect1[4].SetActive(true);
                yield return new WaitForSeconds(3);
                detect1[4].SetActive(false);
                yield return new WaitForSeconds(2);
                guarda[2].SetActive(true);
                yield return new WaitForSeconds(3);
                guarda[2].SetActive(false);
                CharacterMovement.movimiento = true;
                yield return new WaitForSeconds(2);
                guarda[3].SetActive(true);
                yield return new WaitForSeconds(3);
                guarda[3].SetActive(false);
                cerdo[3].SetActive(true);
                yield return new WaitForSeconds(3);
                cerdo[3].SetActive(false);
            }
            if (rechazassegunda == true)
            {
                jarra = true;
                terminastees = true;
                CharacterMovement.movimiento = false;
                CharacterMovement.speed = 0f;
                yield return new WaitForSeconds(1);
                detect2[2].SetActive(true);
                yield return new WaitForSeconds(3);
                detect2[2].SetActive(false);
                yield return new WaitForSeconds(2);
                guarda[2].SetActive(true);
                yield return new WaitForSeconds(3);
                guarda[2].SetActive(false);
                CharacterMovement.movimiento = true;
                yield return new WaitForSeconds(2);
                guarda[3].SetActive(true);
                yield return new WaitForSeconds(3);
                guarda[3].SetActive(false);
                cerdo[3].SetActive(true);
                yield return new WaitForSeconds(3);
                cerdo[3].SetActive(false);

            }
        }
        

    }
    // Start is called before the first frame update
    void Start()
    {
        if (callejuana.minijuego1hecho == true)
        {
            pane.SetActive(false);
        }
        StartCoroutine("entrar");
        if (callejuana.minijuego4hecho == true)
        {
            espadas.SetActive(false);
        }
   
    }
    public void aceptas()
    {
        aceptar.gameObject.SetActive(false);
        rechazar.gameObject.SetActive(false);
        if (primera == true)
        {
             
            aceptasprimera=true;
        }
        if (segunda == true)
        {
            aceptassegunda = true;
        }
        CharacterMovement.movimiento = true;

    }
    public void rechazas()
    {
        aceptar.gameObject.SetActive(false);
        rechazar.gameObject.SetActive(false);
        if (segunda == true)
        {
            rechazassegunda = true;

        }
        if (primera == true)
        {
            rechazasprimera = true;

        }
        CharacterMovement.movimiento = true;

    }
    public void eleccion1()
    {
        primera = true;
        primeraopcion.gameObject.SetActive(false);
        segundaopcion.gameObject.SetActive(false);
        CharacterMovement.movimiento = true;
    }
    public void eleccion2()
    {
        segunda = true;
        primeraopcion.gameObject.SetActive(false);
        segundaopcion.gameObject.SetActive(false);
        CharacterMovement.movimiento = true;
    }
    IEnumerator panes()
    {
        callejuana.minijuego1hecho=true;
        CharacterMovement.movimiento = false;
        CharacterMovement.speed = 0f;
        yield return new WaitForSeconds(1);
        deveto[1].SetActive(true);
        yield return new WaitForSeconds(3);
        deveto[1].SetActive(false);
        pane.SetActive(false);
        CharacterMovement.movimiento = true;

    }
    IEnumerator espada()
    {
        callejuana.minijuego4hecho = true;
        CharacterMovement.movimiento = false;
        CharacterMovement.speed = 0f;
        yield return new WaitForSeconds(1);
        deveto[2].SetActive(true);
        yield return new WaitForSeconds(3);
        deveto[2].SetActive(false);
        espadas.SetActive(false);
        CharacterMovement.movimiento = true;

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "oso"&&callejuana.car==true&& callejuana.para1a == true)
        {
            StartCoroutine("oink");
            haboalrcerdo = true;
        }
        if (collision.gameObject.tag == "oso" && callejuana.car == true )
        {
            StartCoroutine("saludo");

        }
        if (collision.gameObject.tag == "ciervos" && callejuana.car == true && callejuana.para2a == true&& haboalrcerdo==true)
        {
            StartCoroutine("guardapulso1");
            
        }
        if (collision.gameObject.tag == "toro" && callejuana.para5a == true && callejuana.minijuego1 == true)
        {
            StartCoroutine("panes");
        }
        if (collision.gameObject.tag == "liebre" && callejuana.para3a == true && callejuana.minijuego4 == true)
        {
            StartCoroutine("espada");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
