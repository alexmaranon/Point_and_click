using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class textopalco : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject brillibrilli;
    public GameObject faceout;
    public GameObject global;
    public GameObject enemigo;
    public static bool termino;
    string sceneName;
    Animator anim;
    IEnumerator accion()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        if (termino == false)
        {
            yield return new WaitForSeconds(0.01f);
            CharacterMovement.movimiento = false;
            CharacterMovement.speed = 0f;
            CharacterMovement.speed = 0;
            brillibrilli.SetActive(false);
            yield return new WaitForSeconds(5);
            text1.SetActive(true);
            yield return new WaitForSeconds(5);
            text1.SetActive(false);
            text2.SetActive(true);
            yield return new WaitForSeconds(5);
            text2.SetActive(false);
            enemigo.SetActive(true);
            yield return new WaitForSeconds(1);
            enemigo.SetActive(false);
            text3.SetActive(true);
            yield return new WaitForSeconds(5);
            text3.SetActive(false);
            yield return new WaitForSeconds(2);
            brillibrilli.SetActive(true);
            termino = true;
            CharacterMovement.noentraralinco=false;
            yield return new WaitForSeconds(5.3f);
            brillibrilli.SetActive(false);
            anim.SetBool("ph", true);
            yield return new WaitForSeconds(3);
            global.gameObject.SetActive(false);
            faceout.gameObject.SetActive(true);
            yield return new WaitForSeconds(2.7f);
            SceneManager.LoadScene("Lobby");
            CharacterMovement.movimiento = true;
        }
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="character"&&termino == true)
        {
            SceneManager.LoadScene("Lobby");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        StartCoroutine("accion");
    }

   
}
