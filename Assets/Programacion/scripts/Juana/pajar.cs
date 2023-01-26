using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pajar : MonoBehaviour
{
    public List<GameObject> granjero1 = new List<GameObject> { };
    public List<GameObject> granjero2 = new List<GameObject> { };
    public List<GameObject> detective = new List<GameObject> { };
    public List<GameObject> juanamuerte = new List<GameObject> { };
    public static bool patatas = false;
    public GameObject puerta;
    public GameObject luzgene;
    public GameObject luznogene;
    public GameObject luzapagada;
    public GameObject luz;
    public GameObject luzfullencendida;
    public GameObject pajas;
    public GameObject interfaz;
    public GameObject caballe;
    public GameObject caballete2;
    public Button salvar;
    public Button perseguir;
    public static bool kiec;
    public static bool lavasasalvar;
    public static bool juanasequema;
    public GameObject granjeros1;
    public GameObject granjeros2;
    string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;

        if (lavasasalvar == true&&salvasajuana.hashabladoconjua==false)
        {
            luzfullencendida.SetActive(true);
            luznogene.SetActive(false);
            luzgene.SetActive(false);
            luz.SetActive(true);
            luzapagada.SetActive(false);
            pajas.SetActive(false);
            caballe.SetActive(true);
            puerta.SetActive(true);
        }
        if (lavasasalvar == true && salvasajuana.hashabladoconjua == true)
        {
            luzfullencendida.SetActive(true);
            luznogene.SetActive(false);
            luzgene.SetActive(false);
            luz.SetActive(true);
            luzapagada.SetActive(false);
            pajas.SetActive(false);
            caballe.SetActive(true);
            puerta.SetActive(false);
        }
        if (iglesia.cardenalhablado == false)
        {
            pajas.SetActive(true);
            caballe.SetActive(false);
            if (rumba.cogidorumba == true)
            {
                luznogene.SetActive(false);
                luzfullencendida.SetActive(true);
                luz.SetActive(true);
                puerta.SetActive(true);
                StartCoroutine("tienerumba");

            }
        }
        if (iglesia.cardenalhablado == true)
        {
            granjeros1.SetActive(false);
            granjeros2.SetActive(false);
        }
            if (juanasequema == false&&lavasasalvar==false)
        {
            if (iglesia.cardenalhablado == true)
            {
                luzfullencendida.SetActive(false);
                luznogene.SetActive(false);
                luzgene.SetActive(false);
                luz.SetActive(false);
                luzapagada.SetActive(true);
                pajas.SetActive(false);
                caballe.SetActive(true);
                salvar.gameObject.SetActive(true);
                perseguir.gameObject.SetActive(true);
            }
        }
        if (callejuana.yasequemo == true)
        {
            luzapagada.SetActive(false);
            luznogene.SetActive(false);
            luzgene.SetActive(false);
            luz.SetActive(true);
            luzfullencendida.SetActive(true);
            pajas.SetActive(false);
            caballe.SetActive(false);
            caballete2.SetActive(true);
            StartCoroutine("bobo");
        }
        if (rumba.cogidorumba == false)
        {
            puerta.SetActive(false);
            if (patatas == true)
            {
                luzfullencendida.SetActive(true);
                luznogene.SetActive(false);
                luzgene.SetActive(false);
                luz.SetActive(true);
                luzapagada.SetActive(false);
            }
        }
        StartCoroutine("granjero");
        
    }
    public void salvarla()
    {
        lavasasalvar = true;
        salvar.gameObject.SetActive(false);
        perseguir.gameObject.SetActive(false);
        SceneManager.LoadScene("Pajar");
    }
    public void perseguirle()
    {
        juanasequema = true;
        salvar.gameObject.SetActive(false);
        perseguir.gameObject.SetActive(false);
        SceneManager.LoadScene("callejuana");
    }
    IEnumerator notienesfoto()
    {
        caballete2.GetComponent<BoxCollider2D>().enabled = false;
        CharacterMovement.movimiento = false;
        CharacterMovement.speed = 0f;
        yield return new WaitForSeconds(1);
        juanamuerte[1].SetActive(true);
        yield return new WaitForSeconds(4);
        juanamuerte[1].SetActive(false);
        juanamuerte[2].SetActive(true);
        yield return new WaitForSeconds(4);
        juanamuerte[2].SetActive(false);
        juanamuerte[3].SetActive(true);
        yield return new WaitForSeconds(4);
        juanamuerte[3].SetActive(false);
        juanamuerte[4].SetActive(true);
        yield return new WaitForSeconds(4);
        juanamuerte[4].SetActive(false);
        puerta.SetActive(true);
        CharacterMovement.movimiento = true;
    }
    IEnumerator bobo()
    {
        puerta.SetActive(false);
        CharacterMovement.movimiento = false;
        CharacterMovement.speed = 0f;
        yield return new WaitForSeconds(1);
        juanamuerte[0].SetActive(true);
        yield return new WaitForSeconds(4);
        juanamuerte[0].SetActive(false);
        CharacterMovement.movimiento = true;
    }
    IEnumerator tienerumba()
    {
        if (kiec==false)
        {
            kiec = true;
            yield return new WaitForSeconds(1);
            detective[4].gameObject.SetActive(true);
            CharacterMovement.movimiento = false;
            CharacterMovement.speed = 0f;
            yield return new WaitForSeconds(4);
            detective[4].gameObject.SetActive(false);
            granjero2[4].gameObject.SetActive(true);
            yield return new WaitForSeconds(4);
            granjero2[4].gameObject.SetActive(false);
            granjero1[1].gameObject.SetActive(true);
            yield return new WaitForSeconds(4);
            granjero1[1].gameObject.SetActive(false);
            CharacterMovement.movimiento = true;
        }
        


    }

    IEnumerator granjero()
    {
        if (patatas == false)
        {
            yield return new WaitForSeconds(0);
            CharacterMovement.movimiento = false;
            CharacterMovement.speed = 0f;
            yield return new WaitForSeconds(2);
            granjero1[0].gameObject.SetActive(true);
            yield return new WaitForSeconds(4);
            granjero1[0].gameObject.SetActive(false);
            granjero2[0].gameObject.SetActive(true);
            yield return new WaitForSeconds(4);
            granjero2[0].gameObject.SetActive(false);
            luznogene.SetActive(false);
            luzgene.SetActive(true);
            luz.SetActive(true);
            yield return new WaitForSeconds(2);
            granjero2[1].gameObject.SetActive(true);
            yield return new WaitForSeconds(4);
            granjero2[1].gameObject.SetActive(false);
            granjero1[1].gameObject.SetActive(true);
            yield return new WaitForSeconds(4);
            granjero1[1].gameObject.SetActive(false);
            detective[0].gameObject.SetActive(true);
            yield return new WaitForSeconds(4);
            detective[0].gameObject.SetActive(false);
            granjero2[2].gameObject.SetActive(true);
            yield return new WaitForSeconds(4);
            granjero2[2].gameObject.SetActive(false);
            granjero1[2].gameObject.SetActive(true);
            yield return new WaitForSeconds(4);
            granjero1[2].gameObject.SetActive(false);
            detective[1].gameObject.SetActive(true);
            yield return new WaitForSeconds(4);
            detective[1].gameObject.SetActive(false);
            detective[2].gameObject.SetActive(true);
            yield return new WaitForSeconds(4);
            detective[2].gameObject.SetActive(false);
            granjero2[3].gameObject.SetActive(true);
            yield return new WaitForSeconds(4);
            granjero2[3].gameObject.SetActive(false);
            detective[3].gameObject.SetActive(true);
            yield return new WaitForSeconds(4);
            detective[3].gameObject.SetActive(false);
            interfaz.SetActive(true);
            CharacterMovement.movimiento = true;
            CharacterMovement.volvertiempo = true;
            CharacterMovement.noentraralinco = true;
            patatas = true;
            CharacterMovement.hudactiva = true;
            
            
        }
        
    }
    IEnumerator novolver()
    {
        CharacterMovement.movimiento = false;
        CharacterMovement.speed = 0f;
        yield return new WaitForSeconds(1);
        detective[5].SetActive(true);
        yield return new WaitForSeconds(3);
        detective[5].SetActive(false);
        CharacterMovement.movimiento = true;
    }
    IEnumerator volve()
    {
        CharacterMovement.movimiento = false;
        CharacterMovement.speed = 0f;
        yield return new WaitForSeconds(2);
        CharacterMovement.movimiento = true;
        SceneManager.LoadScene("final");
    }
    IEnumerator tomates()
    {

        CharacterMovement.movimiento = false;
        CharacterMovement.speed = 0f;
        callejuana.minijuego3hecho = true;
        yield return new WaitForSeconds(1);
        detective[6].SetActive(true);
        yield return new WaitForSeconds(4);
        detective[6].SetActive(false);

        CharacterMovement.movimiento = true;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
        
        if (collision.gameObject.tag == "caballeteroto")
        {
            StartCoroutine("notienesfoto");
        }
        if (collision.gameObject.tag == "oso"&&lavasasalvar==true&&salvasajuana.hashabladoconjua==false)
        {
            StartCoroutine("novolver");
        }
        if (collision.gameObject.tag == "oso" && lavasasalvar == true && salvasajuana.hashabladoconjua == true)
        {
            StartCoroutine("volve");
        }
        if (collision.gameObject.tag == "ciervos" && lavasasalvar == true&&callejuana.minijuego3==true&&callejuana.minijuego3hecho==false)
        {
            StartCoroutine("tomates");
        }
    }
    // Update is called once per frame
  
}
