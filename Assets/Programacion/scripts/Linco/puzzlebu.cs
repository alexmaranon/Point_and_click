using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class puzzlebu : MonoBehaviour
{
    public bool moneda=false;
    public bool farola = false;
    public static bool moneda1 = false;
    public static bool romper=false;
    public static bool teatromoneda = false;
    public static bool callemoneda = false;
    string sceneName;
    
    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        if (teatromoneda == true && sceneName== "Teatro_Lincoln")
        {
            gameObject.SetActive(false);
        }

    }
   
    IEnumerator oros()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        CharacterMovement.movimiento = false;
        CharacterMovement.speed = 0f;
        yield return new WaitForSeconds(1);
        CharacterMovement.movimiento = true;
        gameObject.SetActive(false);
        Debug.Log("bocatalomo");
    }
    IEnumerator espera()
    {
        romper = true;
        yield return new WaitForSeconds(2);
        romper = false;
       
    }
    private void OnMouseDown()
    {
        StartCoroutine("espera");
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "character")
        {
            if (romper == true)
            {
                if (sceneName == "Teatro_Lincoln")
                {
                    StartCoroutine("oros");
                    teatromoneda = true;
                }

            }     
        }
    }


}
