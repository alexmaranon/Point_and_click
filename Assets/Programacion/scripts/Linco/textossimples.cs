using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textossimples : MonoBehaviour
{
    public List <GameObject> gameobjects=new List<GameObject>{};
    public List<GameObject> ciervoss = new List<GameObject> { };
    public List<GameObject> toreto = new List<GameObject> { };
    public List<GameObject> croac = new List<GameObject> { };
    public static int numerito=0;
    int numeciervo = 0;
    public static bool recibemoneda = false;
    public static bool chocartoro = false;
    static bool noloop;
    public GameObject gato;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    IEnumerator wate()
    {
        if (recibemoneda == false)
        {
            gato.GetComponent<BoxCollider2D>().enabled = false;
            CharacterMovement.movimiento = false;
            CharacterMovement.speed = 0f;
            yield return new WaitForSeconds(1);
            gameobjects[0].SetActive(true);
            yield return new WaitForSeconds(4);
            gameobjects[0].SetActive(false);
            gameobjects[1].SetActive(true);
            yield return new WaitForSeconds(4);
            gameobjects[1].SetActive(false);
            gameobjects[6].SetActive(true);
            yield return new WaitForSeconds(4);
            gameobjects[6].SetActive(false);
            gameobjects[2].SetActive(true);
            yield return new WaitForSeconds(4);
            gameobjects[2].SetActive(false);
            gameobjects[7].SetActive(true);
            yield return new WaitForSeconds(4);
            gameobjects[7].SetActive(false);
            gameobjects[3].SetActive(true);
            yield return new WaitForSeconds(4);
            gameobjects[3].SetActive(false);
            gameobjects[8].SetActive(true);
            yield return new WaitForSeconds(4);
            gameobjects[8].SetActive(false);
            gameobjects[4].SetActive(true);
            yield return new WaitForSeconds(4);
            gameobjects[4].SetActive(false);
            CharacterMovement.monedascontar++;
            CharacterMovement.opcion2 = true;
            Debug.Log(CharacterMovement.monedascontar+" aguacate");
            CharacterMovement.movimiento = true;
            recibemoneda = true;
            
            yield return new WaitForSeconds(2);
            gameobjects[5].SetActive(true);
            CharacterMovement.trileros = true;
            
        }
        

    }
    IEnumerator ranah()
    {
        
        if (CharacterMovement.contador > 0&&noloop==false)
        {
            CharacterMovement.movimiento = false;
            CharacterMovement.speed = 0;
            yield return new WaitForSeconds(1);
            noloop = true;
            croac[0].SetActive(true);
            yield return new WaitForSeconds(6);
            croac[0].SetActive(false);
            noloop = false;
            CharacterMovement.speed = 3;
            CharacterMovement.movimiento = true;
        }
        if (CharacterMovement.contador==0 && noloop == false)
        {
            CharacterMovement.movimiento = false;
            CharacterMovement.speed = 0;
            yield return new WaitForSeconds(1);
            noloop = true;
            croac[1].SetActive(true);
            yield return new WaitForSeconds(3);
            croac[1].SetActive(false);
            noloop = false;
           
            CharacterMovement.movimiento = true;
        }

    }
    IEnumerator ciervo()
    {
        if (CharacterMovement.contador > 0 && noloop == false)
        {
            noloop = true;
            yield return new WaitForSeconds(1);
            ciervoss[0].SetActive(true);
            yield return new WaitForSeconds(3);
            ciervoss[0].SetActive(false);
            ciervoss[1].SetActive(true);
            yield return new WaitForSeconds(3);
            ciervoss[1].SetActive(false);
            ciervoss[2].SetActive(true);
            yield return new WaitForSeconds(3);
            ciervoss[2].SetActive(false);
            ciervoss[3].SetActive(true);
            yield return new WaitForSeconds(3);
            ciervoss[3].SetActive(false);
            noloop = false;
        }
        if (CharacterMovement.contador == 0&&noloop==false)
        {
            noloop = true;
            ciervoss[4].SetActive(true);
            yield return new WaitForSeconds(3);
            ciervoss[4].SetActive(false);
            ciervoss[5].SetActive(true);
            yield return new WaitForSeconds(3);
            ciervoss[5].SetActive(false);

            noloop = false;
        }
        /*
            ciervoss[numeciervo].SetActive(true);
        if (numeciervo >= 1)
        {
            ciervoss[numeciervo - 1].SetActive(false);
        }
        if (CharacterMovement.contador == 0&&numeciervo<4)
        {
           
            numeciervo = 4;
            ciervoss[numeciervo].SetActive(true);
            ciervoss[3].SetActive(false);
            ciervoss[2].SetActive(false);
            ciervoss[1].SetActive(false);
            ciervoss[0].SetActive(false);
        }
            yield return new WaitForSeconds(1);
        if (numeciervo < 3 && CharacterMovement.contador > 0)
        {
            numeciervo++;
        }
        if (numeciervo == 3)
        {
            ciervoss[3].SetActive(false);
        }
        if (CharacterMovement.contador == 0)
        {
            numeciervo++; Debug.Log(numeciervo);
        }
        */
    }
    IEnumerator tor()
    {
        if (CharacterMovement.contador > 0)
        {
            chocartoro = true;
            toreto[0].SetActive(true);
        }
        if (CharacterMovement.contador == 0)
        {
            toreto[1].SetActive(true);
        }
        yield return new WaitForSeconds(5);

        if (CharacterMovement.contador > 0)
        {
            toreto[0].SetActive(false);
        }
        if (CharacterMovement.contador == 0)
        {
            toreto[1].SetActive(false);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "monedita")
        {

            if (puzzlebu.romper == true)
            {
                StartCoroutine("wate");
            }
        }
        if (collision.gameObject.tag == "oso")
        {

            if (callejuana.para1a == true)
            {
                StartCoroutine("ranah");
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "ciervos")
        {
            Debug.Log(numerito);
            if (numeciervo < 6)
            {
                StartCoroutine("ciervo");

            }
        }
        if (collision.gameObject.tag == "toro")
        {
            StartCoroutine("tor");
            
            
        }
    }
    
    


}
