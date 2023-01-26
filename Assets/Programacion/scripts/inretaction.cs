using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class inretaction : MonoBehaviour
{
    //hacer una lista de vectores
    public static Vector2 guardarposi;
    public static Vector2 guardarposientrada;
    public static Vector2 guardarposi1;
    public static Vector2 guardarposi2;
    public static Vector2 guardarposi3;
    public static Vector2 guardarposi4;
    public static Vector2 guardarposipajar;
    public static Vector2 guardarposicalle;
    public static Vector2 guardarpositaber;
    public static Vector2 guardarposicate;
    string sceneName;
    public GameObject Personaje;
    public GameObject textos;

    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
    }
    IEnumerator CallePrincipal_Lincoln()
    {
        CharacterMovement.adiosalospiojos = true;
        yield return new WaitForSeconds(5.5f);

        
        CharacterMovement.cuadros = false;
        CharacterMovement.adiosalospiojos = false;
        CharacterMovement.interact = false;
        SceneManager.LoadScene("CalleLincoln");
    }
    IEnumerator entrada()
    {
        CharacterMovement.adiosalospiojos = true; 
        //tiempo de espera en un objeto
        yield return new WaitForSeconds(0);
  

        CharacterMovement.cuadros = false;
        CharacterMovement.interact = false;
        CharacterMovement.adiosalospiojos = false;
        SceneManager.LoadScene("Lobby");
    }
    IEnumerator Teatro_Lincoln()
    {
        Debug.Log("waho");
        CharacterMovement.adiosalospiojos = true;
        //tiempo de espera en un objeto
        yield return new WaitForSeconds(2);
    


        CharacterMovement.cuadros = false;
        CharacterMovement.interact = false;
        CharacterMovement.adiosalospiojos = false;
        SceneManager.LoadScene("Teatro_Lincoln");

    }
    IEnumerator callejon()
    {
        Debug.Log("waho");
        CharacterMovement.adiosalospiojos = true;
        //tiempo de espera en un objeto
        yield return new WaitForSeconds(2);
    

        CharacterMovement.cuadros = false;
        CharacterMovement.interact = false;
        CharacterMovement.adiosalospiojos = false;
        SceneManager.LoadScene("callejon");
    }
    IEnumerator palco()
    {
        CharacterMovement.adiosalospiojos = true;
        //tiempo de espera en un objeto
        yield return new WaitForSeconds(2);
       

        CharacterMovement.cuadros = false;
        CharacterMovement.adiosalospiojos = false;
        CharacterMovement.interact = false;
        SceneManager.LoadScene("Teatro_Lincoln");
    }
    IEnumerator pajar()
    {
        CharacterMovement.adiosalospiojos = true;
        //tiempo de espera en un objeto
        yield return new WaitForSeconds(2);

        CharacterMovement.adiosalospiojos = false;
        CharacterMovement.cuadros = false;
        CharacterMovement.interact = false;
        SceneManager.LoadScene("callejuana");
    }
    IEnumerator callejua()
    {
        CharacterMovement.adiosalospiojos = true;
        //tiempo de espera en un objeto
        yield return new WaitForSeconds(2);

        CharacterMovement.adiosalospiojos = false;
        CharacterMovement.cuadros = false;
        CharacterMovement.interact = false;
        SceneManager.LoadScene("taberna");
    }
    IEnumerator fix()
    {
        //tiempo de espera en un objeto
        yield return new WaitForSeconds(0);
        CharacterMovement.cuadros = true;
    }
    
    private void OnMouseDown()
    {
        if (sceneName == "Lobby"&&CharacterMovement.noentraralinco == true)
        {
            CharacterMovement.interact = true;
            CharacterMovement.tercero = false;
        }
        if (sceneName != "Lobby")
        {
            CharacterMovement.interact = true;
            CharacterMovement.tercero = false;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "character")
        {
            StartCoroutine("fix");


            if (sceneName == "Entrada")
            {
                CharacterMovement.entrada = true;
                guardarposientrada = new Vector2(Personaje.transform.position.x - 1f, Personaje.transform.position.y);
                StartCoroutine("entrada");
            }
            if (CharacterMovement.interact == true)
            {
                
                if (sceneName == "Lobby" && CharacterMovement.noentraralinco==true)
                {
                    CharacterMovement.lobby = true;
                    guardarposi = new Vector2(Personaje.transform.position.x + 0.1f, Personaje.transform.position.y);
                    StartCoroutine("CallePrincipal_Lincoln");
                }
                if (sceneName == "CalleLincoln")
                {
                 
                    CharacterMovement.calle = true;
                    guardarposi1 = new Vector2(Personaje.transform.position.x +0.1f, Personaje.transform.position.y);
                    StartCoroutine("Teatro_Lincoln");
                }
                if (sceneName == "Teatro_Lincoln")
                {
                    CharacterMovement.teatro = true;
                    guardarposi2 = new Vector2(Personaje.transform.position.x + 0.1f, Personaje.transform.position.y);
                    StartCoroutine("callejon");
                }
                if (sceneName == "callejon")
                {
                    CharacterMovement.callejuela = true;
                    guardarposi3 = new Vector2(Personaje.transform.position.x + 0.1f, Personaje.transform.position.y+0.1f);
                    StartCoroutine("Teatro_Lincoln");
                    
                }
                if (sceneName == "palco")
                {
                    CharacterMovement.palco = true;
                    guardarposi3 = new Vector2(Personaje.transform.position.x + 0.1f, Personaje.transform.position.y);
                    StartCoroutine("Teatro_Lincoln");

                }
                if (sceneName == "Pajar")
                {
                    CharacterMovement.pajar = true;
                    guardarposipajar = new Vector2(Personaje.transform.position.x + 0.1f, Personaje.transform.position.y);
                    StartCoroutine("pajar");

                }
                if (sceneName == "callejuana")
                {
                    CharacterMovement.callejuana = true;
                    guardarposicalle = new Vector2(Personaje.transform.position.x + 0.1f, Personaje.transform.position.y);
                    StartCoroutine("callejua");

                }
            }

        }
    }

}
