using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class callejondialogo : MonoBehaviour
{
    public List<GameObject> trileros = new List<GameObject> { };
    public GameObject tortu1;
    public GameObject liebr1;
    public GameObject tortu2;
    public GameObject liebr2;
    public GameObject detect;
    int conta = 0;
    public static bool yano=true;
    public static bool apostar = false;
    public static bool primeraapuesta = false;
    bool entra=true;
    bool salir=false;
    void Start()
    {
        
    }
    IEnumerator trilero()
    {
        yano = false;
        CharacterMovement.movimiento = false;
        CharacterMovement.speed = 0f;

        trileros[0].SetActive(true);

        yield return new WaitForSeconds(4);
        trileros[0].SetActive(false);
        detect.SetActive(true);
        yield return new WaitForSeconds(4);
        detect.SetActive(false);

        trileros[1].SetActive(true);
        yield return new WaitForSeconds(4);
        
        trileros[1].SetActive(false);
        trileros[2].SetActive(true);
        apostar = true;
        yield return new WaitForSeconds(4);
        CharacterMovement.movimiento = true;
        trileros[2].SetActive(false);
        

    }
    IEnumerator tortu()
    {
        if (salir == true)
        {
            salir = false;
            liebr2.SetActive(true);
            yield return new WaitForSeconds(2);
            liebr2.SetActive(false);
            tortu2.SetActive(true);
            yield return new WaitForSeconds(2);
            tortu2.SetActive(false);
            salir = true;
        }
        if (entra == true)
        {
            entra = false;
            liebr1.SetActive(true);
            yield return new WaitForSeconds(3);
            liebr1.SetActive(false);
            tortu1.SetActive(true);
            yield return new WaitForSeconds(3);
            tortu1.SetActive(false);
            salir = true;
        }
        


    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "trilero")
        {
            
            if (conta < 3 &&yano==true)
            {
                Debug.Log(conta);
                StartCoroutine("trilero");
            }
            
            
        }
        if (collision.gameObject.tag == "tortuga")
        {
                StartCoroutine("tortu");
        }
    }
  
}
