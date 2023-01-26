using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class volver : MonoBehaviour
{
    string sceneName;
    public GameObject personaje;
    public GameObject textos;
    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
    }
    IEnumerator fix()
    {
        //tiempo de espera en un objeto
        yield return new WaitForSeconds(0);
        CharacterMovement.cuadros = true;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "character")
        {
            StartCoroutine("fix");
            if (sceneName == "Lobby")
            {
                CharacterMovement.lobby = true;
                inretaction.guardarposi = new Vector2(personaje.transform.position.x +1f, personaje.transform.position.y);
                SceneManager.LoadScene("Entrada");

            }
            if (sceneName== "Teatro_Lincoln")
            {
                CharacterMovement.teatro = true;
                inretaction.guardarposi2=new Vector2(personaje.transform.position.x+1, personaje.transform.position.y);
                SceneManager.LoadScene("CalleLincoln");

            }
            if (sceneName == "callejuana")
            {
                CharacterMovement.callejuana = true;
                inretaction.guardarposicalle = new Vector2(personaje.transform.position.x + 1, personaje.transform.position.y);
                SceneManager.LoadScene("Pajar");

            }
            if (sceneName == "taberna")
            {
                CharacterMovement.tabern = true;
                inretaction.guardarpositaber = new Vector2(personaje.transform.position.x + 1, personaje.transform.position.y);
                SceneManager.LoadScene("callejuana");

            }
            if (sceneName == "catedral")
            {
                CharacterMovement.cate = true;
                inretaction.guardarposicate = new Vector2(personaje.transform.position.x, personaje.transform.position.y+1f);
                SceneManager.LoadScene("callejuana");

            }
        }
    }
  
}
