using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class entradatexto : MonoBehaviour
{
    public static bool escena1vez;
    public GameObject sombrero;
    public List<GameObject> escenamuerto = new List<GameObject> { };
    IEnumerator morto()
    {
        if (escena1vez == false)
        {
            yield return new WaitForSeconds(0.1f);
            CharacterMovement.movimiento = false;
            CharacterMovement.speed = 0f;
            yield return new WaitForSeconds(3);
            escenamuerto[0].SetActive(true);
            yield return new WaitForSeconds(4);
            escenamuerto[0].SetActive(false);
            escenamuerto[1].SetActive(true);
            yield return new WaitForSeconds(4);
            escenamuerto[1].SetActive(false);
            escenamuerto[2].SetActive(true);
            yield return new WaitForSeconds(4);
            escenamuerto[2].SetActive(false);
            escenamuerto[3].SetActive(true);
            yield return new WaitForSeconds(4);
            escenamuerto[3].SetActive(false);
            escenamuerto[4].SetActive(true);
            yield return new WaitForSeconds(6);
            escenamuerto[4].SetActive(false);
            escenamuerto[5].SetActive(true);
            yield return new WaitForSeconds(4);
            escenamuerto[5].SetActive(false);
            escenamuerto[6].SetActive(true);
            CharacterMovement.movimiento = true;
            escena1vez = true;
        }
        

    }
    void Start()
    {
        if (textopalco.termino== true)
        {
            sombrero.SetActive(true);
        }
        StartCoroutine("morto");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
