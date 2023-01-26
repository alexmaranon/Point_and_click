using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class terceravolver : MonoBehaviour
{
    string sceneName;
    public GameObject personaje;
    public GameObject textos;
    public static bool animajuana;
    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
    }

    IEnumerator pulso()
    {
        CharacterMovement.tercero = true;

        yield return new WaitForSeconds(0.4f);
        CharacterMovement.tercero = false;

    }
    IEnumerator fixing()
    {
        //tiempo de espera en un objeto
        yield return new WaitForSeconds(0);
        CharacterMovement.cuadros = true;
    }
    IEnumerator palco()
    {
        CharacterMovement.movimiento = false;
        CharacterMovement.speed = 0f;
        CharacterMovement.adiosalospiojos = true;

        CharacterMovement.cuadros = true;
        //tiempo de espera en un objeto
        yield return new WaitForSeconds(2);
        CharacterMovement.movimiento = true;
        CharacterMovement.adiosalospiojos = false;

        CharacterMovement.cuadros = false;
        CharacterMovement.tercero = false;
        SceneManager.LoadScene("palco");
    }
    IEnumerator juana()
    {
        CharacterMovement.cuadros = true;
        CharacterMovement.movimiento = false;
        CharacterMovement.speed = 0f;
        CharacterMovement.adiosalospiojos = true;

        //tiempo de espera en un objeto
        yield return new WaitForSeconds(6);
        CharacterMovement.adiosalospiojos = false;

        CharacterMovement.cuadros = false;
        CharacterMovement.tercero = false;
        CharacterMovement.movimiento = true;

        SceneManager.LoadScene("Pajar");
    }
    private void OnMouseDown()
    {
        StartCoroutine("pulso");
        CharacterMovement.interact = false;

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "character")
        {
            StartCoroutine("fixing");

            if (CharacterMovement.tercero == true)
            {
                if (sceneName == "Teatro_Lincoln"&&teatros.entrarpalco== true&& textopalco.termino==false)
                {
                    CharacterMovement.teatro = true;
                    inretaction.guardarposi2 = new Vector2(personaje.transform.position.x + 0.1f, personaje.transform.position.y);
                    StartCoroutine("palco");

                }
                if (sceneName == "Lobby" &&textopalco.termino==true)
                {
                    animajuana = true;
                    CharacterMovement.teatro = true;
                    inretaction.guardarposi = new Vector2(personaje.transform.position.x + 0.1f, personaje.transform.position.y);
                    StartCoroutine("juana");

                }
            }
                
        }
    }
}
