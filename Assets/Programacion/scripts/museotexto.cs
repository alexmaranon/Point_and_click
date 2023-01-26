using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class museotexto : MonoBehaviour
{
    public static bool vez1=true;
    public GameObject primer;
    public GameObject luzgene;
    public GameObject luznogene;
    public GameObject cuadrolinco;
    public List<GameObject> vueltalinc = new List<GameObject> { };
    public static bool begin = true;
    IEnumerator vuelta()
    {
        yield return new WaitForSeconds(0.1f);
        CharacterMovement.movimiento = false;
        CharacterMovement.speed = 0f;
        yield return new WaitForSeconds(1);
        vueltalinc[0].SetActive(true);
        yield return new WaitForSeconds(3);
        vueltalinc[0].SetActive(false);
        vueltalinc[1].SetActive(true);
        yield return new WaitForSeconds(3);
        vueltalinc[1].SetActive(false);
        vueltalinc[2].SetActive(true);
        yield return new WaitForSeconds(3);
        vueltalinc[2].SetActive(false);
        vez1 = false;
        CharacterMovement.movimiento = true;
        //CharacterMovement.speed = 3;
    }
    IEnumerator empieza()
    {
        yield return new WaitForSeconds(0.1f);
        CharacterMovement.movimiento = false;
        CharacterMovement.speed = 0f;
        yield return new WaitForSeconds(3.7f);
        luznogene.SetActive(false);
        luzgene.SetActive(true);
        primer.SetActive(true);
        yield return new WaitForSeconds(3);
        primer.SetActive(false);
        begin = false;
        CharacterMovement.movimiento = true;
        //  CharacterMovement.speed = 3;
    }
    void Start()
    {
        if (textopalco.termino == true)
        {
            cuadrolinco.SetActive(true);
        }
        
        if (begin == false)
        {
            luznogene.SetActive(false);
            luzgene.SetActive(true);
        }
        if (begin == true)
        {
            StartCoroutine("empieza");
        }
        if (textopalco.termino == true&&vez1==true)
        {
            StartCoroutine("vuelta");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
