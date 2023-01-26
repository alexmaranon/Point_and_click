using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class volvemos : MonoBehaviour
{
    string sceneName;
    public GameObject personaje;
    public GameObject textos;
    bool activa;
    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
    }
    IEnumerator entra()
    {
        CharacterMovement.lobby = true;
        CharacterMovement.adiosalospiojos = true;
        inretaction.guardarposi = new Vector2(personaje.transform.position.x + 1f, personaje.transform.position.y);
        CharacterMovement.movimiento = false;
        CharacterMovement.speed = 0f;
        yield return new WaitForSeconds(2);
        CharacterMovement.movimiento = true;
        CharacterMovement.adiosalospiojos = false;
        SceneManager.LoadScene("limbo");
    }
    IEnumerator catedral()
    {
        CharacterMovement.callejuana = true;
        CharacterMovement.adiosalospiojos = true;
        inretaction.guardarposicalle = new Vector2(personaje.transform.position.x+1f , personaje.transform.position.y);
        CharacterMovement.movimiento = false;
        CharacterMovement.speed = 0f;
        yield return new WaitForSeconds(2);
        CharacterMovement.adiosalospiojos = false;
        CharacterMovement.movimiento = true;
        SceneManager.LoadScene("catedral");
    }
    IEnumerator fixeds()
    {
        activa = true;
        yield return new WaitForSeconds(0.1f);
        activa = false;
    }
    private void OnMouseDown()
    {
        StartCoroutine("fixeds");
        CharacterMovement.interact = false;

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "character")
        {
         
            if (sceneName == "Lobby" && activa == true && CharacterMovement.volvertiempo == true)
            {
                StartCoroutine("entra");
            }
            if (sceneName == "callejuana" && activa == true)
            {
                StartCoroutine("catedral");
            }
        }
        
    }
}
