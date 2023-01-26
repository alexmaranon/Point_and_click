using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class farolas : MonoBehaviour
{
    
    public static bool farola;
    public Sprite encendida;
    public Sprite apagada;
    private SpriteRenderer sprite;
    float contador=2f;
    public GameObject toro;
    public GameObject luz1;
    public static bool estasfarola;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        if (CharacterMovement.contador == 0)
        {
            sprite.sprite = apagada;
            farola = true;
            toro.GetComponent<BoxCollider2D>().enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            luz1.SetActive(false);
        }
      
    }
    private void OnMouseDown()
    {
        StartCoroutine("wait");
    }
    IEnumerator parar()
    {
        estasfarola = true;
        yield return new WaitForSeconds(0);
        estasfarola = false;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
            contador--;
        CharacterMovement.movimiento = false;
        CharacterMovement.speed = 0f;
        yield return new WaitForSeconds(7);
        
            luz1.gameObject.SetActive(false);

        CharacterMovement.movimiento = true;
        sprite.sprite = apagada;
        
       
        
        
        //toro.GetComponent<BoxCollider2D>().isTrigger = false;
      //  Debug.Log(contador);
    }
    IEnumerator wait()
    {
        if (farola == false)
        {
            farola = true;
            yield return new WaitForSeconds(0.01f);
            farola = false;
        }
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "character")
        {
            if (farola == true)
            {
                StartCoroutine("parar");
                
            }
        }
    }

}
