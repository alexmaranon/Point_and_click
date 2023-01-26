using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterMovement : MonoBehaviour
{
    public static Vector2 target;
    [SerializeField] public static float speed;
    public static bool interact = false;
    public static bool tercero = false;
    public static bool cuadros = false;
    public GameObject cuadro1;
    public GameObject cuadro2;
    float scale=0.01f;
    string sceneName;
    public GameObject hud;
    public static bool noentraralinco=true;
    public static bool entrada;
    public static bool lobby;
    public static bool calle;
    public static bool teatro;
    public static bool callejuela;
    public static bool palco;
    public static bool pajar;
    public static bool callejuana;
    public static bool tabern;
    public static bool hudactiva;
    public static bool cate;
    public static bool adiosalospiojos;
    public static float contador=2f;
    public static float monedascontar = 0f;
    public GameObject toro;
    public static bool trileros=false;
    public bool saltos=false;
    public static bool opcion2 = false;
    public static bool volvertiempo = false;
    Animator anim;
    bool caminaar;
    public static bool movimiento = true;
    // Start is called before the first frame update
    public AudioSource walk;
    void Start()
    {
        cuadros = false;
        interact = false;
        adiosalospiojos = false;
        if (hudactiva == true)
        {
            hud.SetActive(true);
        }
        walk = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();

        speed = 0f;
        //speed = 2f;
      /*  if (sceneName == "Teatro_Lincoln")
        {
            speed = 3;
        }
      */

        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;

        //Guardar posicion
        if (sceneName == "Entrada" && entrada == true)
        {
            gameObject.transform.position = inretaction.guardarposientrada;
        }
        if (sceneName == "Lobby"&&lobby==true)
        {
            gameObject.transform.position = inretaction.guardarposi;
        }
        if (sceneName == "CalleLincoln" && calle==true)
        {
            gameObject.transform.position = inretaction.guardarposi1;
        }
        if (sceneName == "Teatro_Lincoln"&&teatro==true)
        {
            gameObject.transform.position = inretaction.guardarposi2;
        }
        if (sceneName == "callejon"&&callejuela==true)
        {
            gameObject.transform.position = inretaction.guardarposi3;
        }
        if (sceneName == "palco" && palco == true)
        {
            gameObject.transform.position = inretaction.guardarposi4;
        }
        if (sceneName == "Pajar" && pajar == true)
        {
            gameObject.transform.position = inretaction.guardarposipajar;
        }
        if (sceneName == "callejuana" && callejuana == true)
        {
            gameObject.transform.position = inretaction.guardarposicalle;
        }
        if (sceneName == "taberna" && tabern == true)
        {
            gameObject.transform.position = inretaction.guardarpositaber;
        }
        
        if (sceneName == "catedral" && cate == true)
        {
            gameObject.transform.position = inretaction.guardarposicate; 
        }
        StartCoroutine("fixx");

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "farola")
        {
            if (farolas.farola == true)
            {
                contador--;
                Debug.Log(contador);

            }
            if (contador == 0)
            {
                toro.GetComponent<BoxCollider2D>().enabled = false;
                toro.GetComponent<BoxCollider2D>().isTrigger = false;
               
            }
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "monedita")
        {
            if (puzzlebu.romper == true && sceneName == "Teatro_Lincoln")
            {
                monedascontar++;
                
                Debug.Log(monedascontar);
            }
           
            if (monedascontar > 0)
            {
                trileros = true;

                Debug.Log(monedascontar);
            }

        }
    }
    IEnumerator fixx()
    {
        yield return new WaitForSeconds(0);
        anim.SetBool("move", false);

    }
    IEnumerator saltotiempo()
    {
        yield return new WaitForSeconds(5.5f);
        SceneManager.LoadScene("Lobby");
        
    }
    IEnumerator final()
    {
        yield return new WaitForSeconds(5.5f);
        SceneManager.LoadScene("final");

    }
    IEnumerator farola1()
    {
        anim.SetBool("Jump_sml", true);
        yield return new WaitForSeconds(4.5f);
        anim.SetBool("Jump_sml", false);
    }
    IEnumerator farola2()
    {
        anim.SetBool("Jump_big", true);
        yield return new WaitForSeconds(4.5f);
        anim.SetBool("Jump_big", false);
    }
    void Update()
    {
        if (terceravolver.animajuana == true)
        {
            terceravolver.animajuana = false;
            anim.SetBool("cuadros", true);
            
        }
        if (sceneName == "CalleLincoln" && primerafarola.clicar==true&&farolas.estasfarola == true)
        {
            StartCoroutine("farola1");
        }
        if (sceneName == "CalleLincoln" && segundafarola.clicar2 == true && farolas.estasfarola == true)
        {
            StartCoroutine("farola2");
        }
        if (Input.GetKeyDown(KeyCode.B)&&volvertiempo==true&&speed!=0&&iglesia.cardenalhablado==false)
        {
            anim.SetBool("ph", true);
            speed = 0;
            StartCoroutine("saltotiempo");
        }
        if (Input.GetKeyDown(KeyCode.B) && iglesia.yatienesfoto==true)
        {
            anim.SetBool("ph", true);
            speed = 0;
            StartCoroutine("final");
        }
        if (movimiento == true)
        {
            if (Input.GetMouseButtonDown(0) && cuadros == false && interact == false
           || Input.GetMouseButtonDown(0) && cuadros == false && interact == true
           || Input.GetMouseButtonDown(0) && cuadros == true && interact == false)
            {
                saltos = true;
                if (sceneName == "Teatro_Lincoln" || sceneName == "palco" || sceneName == "catedral")
                {
                    Vector2 mousePosteatro = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    target = new Vector2(mousePosteatro.x, mousePosteatro.y);
                    speed = 2f;


                }
                
                else
                {
                    Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    target = new Vector2(mousePos.x, transform.position.y);
                    if (caminaar == false)
                    {
                        walk.Play();
                        caminaar = true;
                    }
                    speed = 3f;
                }
                    

                   
               

                
                cuadros = false;
                interact = false;

            }
            if(Input.GetMouseButtonDown(0) && adiosalospiojos == false)
            {
                saltos = true;
                if (sceneName == "Teatro_Lincoln" || sceneName == "palco" || sceneName == "catedral")
                {
                    Vector2 mousePosteatro = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    target = new Vector2(mousePosteatro.x, mousePosteatro.y);
                    speed = 2f;


                }

                else
                {
                    Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    target = new Vector2(mousePos.x, transform.position.y);
                    if (caminaar == false)
                    {
                        walk.Play();
                        caminaar = true;
                    }
                    speed = 3f;
                }
            }
        }

        

            if (sceneName == "Lobby"||sceneName=="Pajar"|| sceneName == "Entrada"||sceneName=="taberna"||sceneName=="final")
        {
            if (target.x > transform.position.x && speed > 0.99f || target.x > transform.position.x && speed < -0.99f)
            {
                transform.localScale = new Vector3(0.3488562f, 0.3488562f, 0.3488562f);
                anim.SetBool("move", true);
            }
            else if (target.x < transform.position.x && speed > 0.99f || target.x > transform.position.x && speed < -0.99f)
            {
                transform.localScale = new Vector3(-0.3488562f, 0.3488562f, 0.3488562f);
                anim.SetBool("move", true);

            }
            else if (target.x == transform.position.x || speed < 0.99f && speed > -0.99f)
            {
                anim.SetBool("move", false);
                caminaar = false;
                walk.Stop();

            }
        }
        if (sceneName == "CalleLincoln"||sceneName=="limbo")
        {
            if (target.x > transform.position.x && speed != 0)
            {
                transform.localScale = new Vector3(0.2762817f, 0.2762817f, 0.2762817f);
                anim.SetBool("move", true);
            }
            else if (target.x < transform.position.x && speed != 0)
            {
                transform.localScale = new Vector3(-0.2762817f, 0.2762817f, 0.2762817f);
                anim.SetBool("move", true);

            }
            else if (target.x == transform.position.x || speed == 0)
            {
                anim.SetBool("move", false);
                caminaar = false;
                walk.Stop();
            }
        }
        if (sceneName == "Teatro_Lincoln"||sceneName=="callejuana"||sceneName=="catedral")
        {
            if (target.x > transform.position.x && speed != 0)
            {
                transform.localScale = new Vector3(0.2270262f, 0.2270262f, 0.2270262f);
                anim.SetBool("move", true);
            }
            else if (target.x < transform.position.x && speed != 0)
            {
                transform.localScale = new Vector3(-0.2270262f, 0.2270262f, 0.2270262f);
                anim.SetBool("move", true);

            }
            else if (target.x == transform.position.x || speed == 0)
            {
                anim.SetBool("move", false);
                walk.Stop();
                caminaar = false;

            }
        }
        if (sceneName == "palco")
        {
            if (target.x > transform.position.x && speed != 0)
            {
                transform.localScale = new Vector3(0.402179f, 0.402179f, 0.402179f);
                anim.SetBool("move", true);
            }
            else if (target.x < transform.position.x && speed != 0)
            {
                transform.localScale = new Vector3(-0.402179f, 0.402179f, 0.402179f);
                anim.SetBool("move", true);

            }
            else if (target.x == transform.position.x || speed == 0)
            {
                anim.SetBool("move", false);
                caminaar = false;
                walk.Stop();

            }
        }
        if (sceneName == "callejon")
        {
            if (target.x > transform.position.x && speed != 0)
            {
                transform.localScale = new Vector3(0.3660888f, 0.3660888f, 0.3660888f);
                anim.SetBool("move", true);
            }
            else if (target.x < transform.position.x && speed != 0)
            {
                transform.localScale = new Vector3(-0.3660888f, 0.3660888f, 0.3660888f);
                anim.SetBool("move", true);

            }
            else if (target.x == transform.position.x || speed == 0)
            {
                anim.SetBool("move", false);

                caminaar = false;
                walk.Stop();
            }
        }



        if (Input.GetMouseButtonDown(0)&& cuadros==true &&interact == true&&adiosalospiojos==true)
        {
            
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target = new Vector2(cuadro1.transform.position.x, transform.position.y);
            //speed = 3f;
            saltos = true;
            if (sceneName == "Lobby")
            {
                anim.SetBool("cuadros",true);
            }

        }
        if (Input.GetMouseButtonDown(0) && cuadros == true && tercero==true && adiosalospiojos == true)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target = new Vector2(cuadro2.transform.position.x, transform.position.y);
            //speed = 3f;
            saltos = true;
        }
        if (saltos == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime * speed);
        }
    }
}
