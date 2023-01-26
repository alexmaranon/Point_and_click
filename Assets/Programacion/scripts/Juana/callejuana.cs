using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class callejuana : MonoBehaviour
{
    public List<GameObject> persona1 = new List<GameObject> { };
    public List<GameObject> persona2 = new List<GameObject> { };
    public List<GameObject> persona3 = new List<GameObject> { };
    public List<GameObject> persona4 = new List<GameObject> { };
    public List<GameObject> persona5 = new List<GameObject> { };
    public List<GameObject> dete = new List<GameObject> { };
    public List<GameObject> cardenas = new List<GameObject> { };
    public static bool para1;
    public static bool para2;
    public static bool para3;
    public static bool para4;
    public static bool para5;
    public static bool car;
    public static bool para1a;
    public static bool para2a;
    public static bool para3a;
    public static bool para4a;
    public static bool para5a;
    public static bool adioscarde;
    public static bool minijuego1;
    public static bool minijuego2;
    public static bool minijuego3;
    public static bool minijuego4;
    public static bool minijuego5;
    public static bool terminadom1;
    public static bool terminadom2;
    public static bool terminadom3;
    public static bool terminadom4;
    public static bool terminadom5;
    public GameObject cardenasa;
    public GameObject cursore;
    public Camera principal;
    public Camera juanamuere;
    public GameObject juanasita;
    public GameObject juanaquemadita;
    public GameObject cenicita;
    public GameObject tendeder1;
    public GameObject tendeder2;
    public static bool yasequemo;
    public static bool minijuego1hecho;
    public static bool minijuego3hecho;
    public static bool minijuego4hecho;
    public static bool minijuego5hecho;
    public static bool toyarto;

    public GameObject juanasa;

    string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        if (minijuego5hecho == true)
        {
            tendeder1.SetActive(false);
            tendeder2.SetActive(true);
        }
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        if (yasequemo==false)
        {
            if (pajar.juanasequema == true)
            {
               // cursore.SetActive(false);
                principal.gameObject.SetActive(false);
                juanamuere.gameObject.SetActive(true);
                StartCoroutine("sequemo");
            }
        }
        if (yasequemo == true)
        {
            juanaquemadita.SetActive(true);
        }
        
        if (adioscarde == true)
        {
            cardenasa.GetComponent<BoxCollider2D>().enabled = false;

        }
        if (terminadom1 == true && terminadom2 == true && terminadom3 == true && terminadom4 == true && terminadom5 == true&&pajar.lavasasalvar==true)
        {
            juanasa.SetActive(true);
        }
    }
    IEnumerator sequemo()
    {
        yasequemo = true;   
        yield return new WaitForSeconds(4);
        juanasita.SetActive(false);
        juanaquemadita.SetActive(true);
        yield return new WaitForSeconds(4);
        juanaquemadita.SetActive(false);
        cenicita.SetActive(true);
        yield return new WaitForSeconds(4);
        
        SceneManager.LoadScene("Pajar");
    }
    IEnumerator personaje1()
    {
        if (para1 == false&& para1a==true&& iglesia.cardenalhablado == false)
        {
            CharacterMovement.movimiento = false;
            CharacterMovement.speed = 0f;
            para1 = true;
            yield return new WaitForSeconds(1);
            dete[0].SetActive(true);
            yield return new WaitForSeconds(3);
            dete[0].SetActive(false);
            persona1[0].SetActive(true);
            yield return new WaitForSeconds(3);
            persona1[0].SetActive(false);
            CharacterMovement.movimiento = true;
        }
        if (iglesia.cardenalhablado==true&& minijuego1==false && para1a == true)
        {
            CharacterMovement.movimiento = false;
            CharacterMovement.speed = 0f;

            minijuego1 = true; 
            yield return new WaitForSeconds(1);
            dete[5].SetActive(true);
            yield return new WaitForSeconds(4);
            dete[5].SetActive(false);
            persona1[1].SetActive(true);
            yield return new WaitForSeconds(4);
            persona1[1].SetActive(false);
            dete[6].SetActive(true);
            yield return new WaitForSeconds(4);
            dete[6].SetActive(false);
            persona1[2].SetActive(true);
            yield return new WaitForSeconds(4);
            persona1[2].SetActive(false);
            CharacterMovement.movimiento = true;
        }
        if (minijuego1hecho == true&&terminadom1==false && para1a == true)
        {
            CharacterMovement.movimiento = false;
            CharacterMovement.speed = 0f;
            terminadom1 = true;
            yield return new WaitForSeconds(2);
            persona1[3].SetActive(true);
            yield return new WaitForSeconds(4);
            persona1[3].SetActive(false);
            CharacterMovement.movimiento = true;
            if (terminadom1 == true && terminadom2 == true && terminadom3 == true && terminadom4 == true && terminadom5 == true)
            {
                SceneManager.LoadScene("juanasalva");
            }
        }

    }
    IEnumerator personaje2()
    {
        if (para2 == false && para2a == true&&iglesia.cardenalhablado == false)
        {
            CharacterMovement.movimiento = false;
            CharacterMovement.speed = 0f;
            para2 = true;
            yield return new WaitForSeconds(1);
            dete[0].SetActive(true);
            yield return new WaitForSeconds(4);
            dete[0].SetActive(false);
            persona2[0].SetActive(true);
            yield return new WaitForSeconds(4);
            persona2[0].SetActive(false);
            CharacterMovement.movimiento = true;
        }
        if(iglesia.cardenalhablado == true&& minijuego2==false && para2a == true)
        {
            CharacterMovement.movimiento = false;
            CharacterMovement.speed = 0f;

            minijuego2 = true;
            yield return new WaitForSeconds(1);
            dete[5].SetActive(true);
            yield return new WaitForSeconds(4);
            dete[5].SetActive(false);
            persona2[1].SetActive(true);
            yield return new WaitForSeconds(4);
            persona2[1].SetActive(false);
            dete[6].SetActive(true);
            yield return new WaitForSeconds(4);
            dete[6].SetActive(false);
            persona2[2].SetActive(true);
            yield return new WaitForSeconds(4);
            persona2[2].SetActive(false);
            CharacterMovement.movimiento = true;

        }
        if (iglesia.minijuego2hecho==true&&terminadom2==false&& para2a == true)
        {
            CharacterMovement.movimiento = false;
            CharacterMovement.speed = 0f;
            terminadom2 = true;
            yield return new WaitForSeconds(2);
            persona2[3].SetActive(true);
            yield return new WaitForSeconds(4);
            persona2[3].SetActive(false);
            CharacterMovement.movimiento = true;
            if (terminadom1 == true && terminadom2 == true && terminadom3 == true && terminadom4 == true && terminadom5 == true)
            {
                SceneManager.LoadScene("juanasalva");
            }
        }
    }
    IEnumerator personaje3()
    {
        if (para3 == false && para3a == true && iglesia.cardenalhablado == false)
        {
            CharacterMovement.movimiento = false;
            CharacterMovement.speed = 0f;
            para3 = true;
            yield return new WaitForSeconds(1);
            dete[0].SetActive(true);
            yield return new WaitForSeconds(4);
            dete[0].SetActive(false);
            persona3[0].SetActive(true);
            yield return new WaitForSeconds(4);
            persona3[0].SetActive(false);
            CharacterMovement.movimiento = true;
        }
        if (iglesia.cardenalhablado == true&& minijuego3==false && para3a == true)
        {
            CharacterMovement.movimiento = false;
            CharacterMovement.speed = 0f;

            minijuego3 = true;
            yield return new WaitForSeconds(1);
            dete[5].SetActive(true);
            yield return new WaitForSeconds(4);
            dete[5].SetActive(false);
            persona3[1].SetActive(true);
            yield return new WaitForSeconds(4);
            persona3[1].SetActive(false);
            dete[6].SetActive(true);
            yield return new WaitForSeconds(4);
            dete[6].SetActive(false);
            persona3[2].SetActive(true);
            yield return new WaitForSeconds(4);
            persona3[2].SetActive(false);
            CharacterMovement.movimiento = true;

        }
        if (minijuego3hecho == true&&terminadom3==false && para3a == true)
        {
            CharacterMovement.movimiento = false;
            CharacterMovement.speed = 0f;
            terminadom3 = true;
            yield return new WaitForSeconds(2);
            persona3[3].SetActive(true);
            yield return new WaitForSeconds(4);
            persona3[3].SetActive(false);
            CharacterMovement.movimiento = true;
            if (terminadom1 == true && terminadom2 == true && terminadom3 == true && terminadom4 == true && terminadom5 == true)
            {
                SceneManager.LoadScene("juanasalva");
            }
        }
    }
    IEnumerator personaje4()
    {
        if (para4 == false && para4a == true && iglesia.cardenalhablado == false)
        {
            CharacterMovement.movimiento = false;
            CharacterMovement.speed = 0f;
            para4 = true;
            yield return new WaitForSeconds(1);
            dete[0].SetActive(true);
            yield return new WaitForSeconds(4);
            dete[0].SetActive(false);
            persona4[0].SetActive(true);
            yield return new WaitForSeconds(4);
            persona4[0].SetActive(false);
            CharacterMovement.movimiento = true;
        }
        if(iglesia.cardenalhablado == true&& minijuego4==false && para4a == true)
        {
            CharacterMovement.movimiento = false;
            CharacterMovement.speed = 0f;

            minijuego4 = true;
            yield return new WaitForSeconds(1);
            dete[5].SetActive(true);
            yield return new WaitForSeconds(4);
            dete[5].SetActive(false);
            persona4[1].SetActive(true);
            yield return new WaitForSeconds(4);
            persona4[1].SetActive(false);
            dete[6].SetActive(true);
            yield return new WaitForSeconds(4);
            dete[6].SetActive(false);
            persona4[2].SetActive(true);
            yield return new WaitForSeconds(4);
            persona4[2].SetActive(false);
            CharacterMovement.movimiento = true;

        }
        if (minijuego4hecho == true&&terminadom4==false && para4a == true)
        {
            CharacterMovement.movimiento = false;
            CharacterMovement.speed = 0f;
            terminadom4 = true;
            yield return new WaitForSeconds(2);
            persona4[3].SetActive(true);
            yield return new WaitForSeconds(4);
            persona4[3].SetActive(false);
            CharacterMovement.movimiento = true;
            if (terminadom1 == true && terminadom2 == true && terminadom3 == true && terminadom4 == true && terminadom5 == true)
            {
                SceneManager.LoadScene("juanasalva");
            }
        }
    }
    IEnumerator personaje5()
    {
        if (para5 == false && para5a == true && iglesia.cardenalhablado == false)
        {
            CharacterMovement.movimiento = false;
            CharacterMovement.speed = 0f;
            para5 = true;
            yield return new WaitForSeconds(1);
            dete[0].SetActive(true);
            yield return new WaitForSeconds(4);
            dete[0].SetActive(false);
            persona5[0].SetActive(true);
            yield return new WaitForSeconds(4);
            persona5[0].SetActive(false);
            CharacterMovement.movimiento = true;
        }
        if (iglesia.cardenalhablado == true&& minijuego5==false && para5a == true)
        {
            CharacterMovement.movimiento = false;
            CharacterMovement.speed = 0f;

            minijuego5 = true;
            yield return new WaitForSeconds(1);
            dete[5].SetActive(true);
            yield return new WaitForSeconds(4);
            dete[5].SetActive(false);
            persona5[1].SetActive(true);
            yield return new WaitForSeconds(4);
            persona5[1].SetActive(false);
            dete[6].SetActive(true);
            yield return new WaitForSeconds(4);
            dete[6].SetActive(false);
            persona5[2].SetActive(true);
            yield return new WaitForSeconds(4);
            persona5[2].SetActive(false);
            CharacterMovement.movimiento = true;

        }
        if (minijuego5hecho == true&&terminadom5==false && para5a == true)
        {
            CharacterMovement.movimiento = false;
            CharacterMovement.speed = 0f;
            terminadom5 = true;
            yield return new WaitForSeconds(2);
            persona5[3].SetActive(true);
            yield return new WaitForSeconds(4);
            persona5[3].SetActive(false);
            CharacterMovement.movimiento = true;
            if (terminadom1 == true && terminadom2 == true && terminadom3 == true && terminadom4 == true && terminadom5 == true)
            {
                SceneManager.LoadScene("juanasalva");
            }
        }
    }
    IEnumerator tender()
    {
        minijuego5hecho = true;
        CharacterMovement.movimiento = false;
        CharacterMovement.speed = 0f;
        yield return new WaitForSeconds(1);
        persona5[4].SetActive(true);
        yield return new WaitForSeconds(4);
        tendeder1.SetActive(false);
        tendeder2.SetActive(true);
        persona5[4].SetActive(false);
        CharacterMovement.movimiento = true;

    }
    IEnumerator carde()
    {
        if (caliz.cadiz == false)
        {
            if (car == false)
            {
                CharacterMovement.movimiento = false;
                CharacterMovement.speed = 0f;
                car = true;
                yield return new WaitForSeconds(1);
                cardenas[0].SetActive(true);
                yield return new WaitForSeconds(4);
                cardenas[0].SetActive(false);
                dete[1].SetActive(true);
                yield return new WaitForSeconds(4);
                dete[1].SetActive(false);
                cardenas[1].SetActive(true);
                yield return new WaitForSeconds(4);
                cardenas[1].SetActive(false);
                dete[2].SetActive(true);
                yield return new WaitForSeconds(4);
                dete[2].SetActive(false);
                cardenas[2].SetActive(true);
                yield return new WaitForSeconds(4);
                cardenas[2].SetActive(false);
                dete[3].SetActive(true);
                yield return new WaitForSeconds(4);
                dete[3].SetActive(false);
                cardenas[3].SetActive(true);
                yield return new WaitForSeconds(4);
                cardenas[3].SetActive(false);
                toyarto = false;
                CharacterMovement.movimiento = true;
            }
            if (car == true&& toyarto==true)
            {

                yield return new WaitForSeconds(1);
                cardenas[4].SetActive(true);
                yield return new WaitForSeconds(4);
                cardenas[4].SetActive(false);

            }
        }
        if (caliz.cadiz == true&&adioscarde==false)
        {
            adioscarde = true;
            CharacterMovement.movimiento = false;
            CharacterMovement.speed = 0f;
            yield return new WaitForSeconds(1);
            cardenas[5].SetActive(true);
            yield return new WaitForSeconds(4);
            cardenas[5].SetActive(false);
            dete[4].SetActive(true);
            yield return new WaitForSeconds(4);
            dete[4].SetActive(false);
            cardenas[6].SetActive(true);
            yield return new WaitForSeconds(4);
            cardenas[6].SetActive(false);

            cardenasa.GetComponent<BoxCollider2D>().enabled=false;
            CharacterMovement.movimiento = true;

        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "oso")
        {
            StartCoroutine("personaje1");
        }

        if (collision.gameObject.tag == "liebre")
        {
            StartCoroutine("personaje3");
        }
        if (collision.gameObject.tag == "tortuga")
        {
            StartCoroutine("personaje4");
        }
        if (collision.gameObject.tag == "cardenas")
        {
            StartCoroutine("carde");
        }
        if (collision.gameObject.tag == "toro")
        {
            StartCoroutine("personaje2");
        }
        if (collision.gameObject.tag == "rataZ")
        {
            StartCoroutine("personaje5");
        }
        if (collision.gameObject.tag == "tendedero")
        {
            if (tendedero.tendederos == true&& minijuego5==true&& minijuego5hecho == false)
            {
                StartCoroutine("tender");
            }
        }

    }
  
}
