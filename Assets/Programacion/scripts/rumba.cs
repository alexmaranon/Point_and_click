using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class rumba : MonoBehaviour
{
    bool cogerrumba;
    public static bool cogidorumba=false;
    string sceneName;
    float velocidad = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        if (cogidorumba == true&&sceneName=="Entrada")
        {
            gameObject.SetActive(false);
        }
        if (cogidorumba == false && sceneName == "Pajar")
        {
            gameObject.SetActive(false);
        }
    }
    IEnumerator wait()
    {
        if (cogerrumba == false)
        {
            cogerrumba = true;
            yield return new WaitForSeconds(0.1f);
            cogerrumba = false;
        }

    }
    IEnumerator rumbas()
    {
        cogidorumba = true;
        yield return new WaitForSeconds(0.01f);
        CharacterMovement.movimiento = false;
        CharacterMovement.speed = 0f;
        yield return new WaitForSeconds(2);
        CharacterMovement.movimiento = true;
        gameObject.SetActive(false);


    }
    private void OnMouseDown()
    {
        StartCoroutine("wait");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "character"&&cogerrumba==true&&CharacterMovement.volvertiempo==true)
        {
            StartCoroutine("rumbas");
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "limites")
        {
            velocidad = -velocidad;
            transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        }
    }
    void Update()
    {
        if (sceneName == "Pajar")
        {
            transform.position += Vector3.right * Time.deltaTime * velocidad;
        }
    }
}
