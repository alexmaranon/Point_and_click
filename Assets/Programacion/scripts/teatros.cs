using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teatros : MonoBehaviour
{
    public List<GameObject> binocular = new List<GameObject> { };
    public List<GameObject> llaveperdida = new List<GameObject> { };
    public List<GameObject> detec = new List<GameObject> { };
    public List<GameObject> pareja = new List<GameObject> { };
    public List<GameObject> randoms = new List<GameObject> { };
    public static bool osibino;
    public static bool llave;
    public static bool llavetexto;
    public static bool osazo;
    public static bool patazo;
    public static bool entrarpalco;

    // Start is called before the first frame update

    IEnumerator textotea()
    {
        yield return new WaitForSeconds(1);
        randoms[0].SetActive(true); 
        yield return new WaitForSeconds(4);
        randoms[0].SetActive(false);
        pareja[0].SetActive(true);
        yield return new WaitForSeconds(4);
        pareja[0].SetActive(false);
        pareja[1].SetActive(true);
        yield return new WaitForSeconds(4);
        pareja[1].SetActive(false);
        pareja[2].SetActive(true);
        yield return new WaitForSeconds(4);
        pareja[2].SetActive(false);
        pareja[3].SetActive(true);
        yield return new WaitForSeconds(4);
        pareja[3].SetActive(false);
        randoms[1].SetActive(true);
        yield return new WaitForSeconds(4);
        randoms[1].SetActive(false);
    }
    void Start()
    {
        StartCoroutine("textotea");
    }


    IEnumerator osos()
    {
        if (osibino == false&&trilero.binoculares==false)
        {
            CharacterMovement.movimiento = false;
            CharacterMovement.speed = 0f;
            yield return new WaitForSeconds(1);
            binocular[0].SetActive(true);
            yield return new WaitForSeconds(4);
            binocular[0].SetActive(false);
            detec[2].SetActive(true);
            yield return new WaitForSeconds(4);
            detec[2].SetActive(false);
            binocular[1].SetActive(true);
            yield return new WaitForSeconds(4);
            binocular[1].SetActive(false);
            osibino = true;
            CharacterMovement.movimiento = true;
        }
        if (trilero.binoculares == true&&osazo==false)
        {
            osazo = true;
            CharacterMovement.movimiento = false;
            CharacterMovement.speed = 0f;
            yield return new WaitForSeconds(1);
            binocular[2].SetActive(true);
            yield return new WaitForSeconds(4);
            binocular[2].SetActive(false);
            binocular[3].SetActive(true);
            yield return new WaitForSeconds(5);
            binocular[3].SetActive(false);
            CharacterMovement.movimiento = true;
            llave = true;
        }
    }
    IEnumerator llaves()
    {
        if (llavetexto == false&&llave==false)
        {
            CharacterMovement.movimiento = false;
            CharacterMovement.speed = 0f;
            yield return new WaitForSeconds(1);
            llaveperdida[0].SetActive(true);
            yield return new WaitForSeconds(4);
            llaveperdida[0].SetActive(false);
            llaveperdida[1].SetActive(true);
            yield return new WaitForSeconds(4);
            llaveperdida[1].SetActive(false);
            detec[0].SetActive(true);
            yield return new WaitForSeconds(4);
            detec[0].SetActive(false);
            llaveperdida[2].SetActive(true);
            yield return new WaitForSeconds(4);
            llaveperdida[2].SetActive(false);
            detec[1].SetActive(true);
            yield return new WaitForSeconds(4);
            detec[1].SetActive(false);
            llavetexto = true;

            CharacterMovement.movimiento = true;
        }
        if (llave == true&&patazo==false)
        {
            patazo = true;
            CharacterMovement.movimiento = false;
            CharacterMovement.speed = 0f;
            yield return new WaitForSeconds(1);
            llaveperdida[3].SetActive(true);
            yield return new WaitForSeconds(4);
            llaveperdida[3].SetActive(false);
            CharacterMovement.movimiento = true;
            entrarpalco = true;
        }
    }



    private void OnTriggerStay2D(Collider2D collision)
    {
            if (collision.gameObject.tag == "llaves")
            {
                StartCoroutine("llaves");
            }
        if (collision.gameObject.tag == "oso")
        {
            StartCoroutine("osos");

        }
    }
       
}
