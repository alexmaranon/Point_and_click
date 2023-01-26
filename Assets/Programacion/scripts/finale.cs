using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finale : MonoBehaviour
{
    public List<GameObject> detectivemalo = new List<GameObject> { };
    public List<GameObject> cocomalo = new List<GameObject> { };
    public List<GameObject> detectivebueno = new List<GameObject> { };
    public List<GameObject> cocobueno = new List<GameObject> { };
    public GameObject coco;
    public GameObject luz1;
    public GameObject luz2;
    public GameObject cuadrocerda;
    // Start is called before the first frame update
    void Start()
    {
        if (pajar.lavasasalvar == true)
        {
            cuadrocerda.SetActive(false);
        }
    }
    IEnumerator finalmalo()
    {
        CharacterMovement.movimiento = false;
        CharacterMovement.speed = 0f;
        coco.GetComponent<BoxCollider2D>().enabled = false;
        yield return new WaitForSeconds(2);
        detectivemalo[0].SetActive(true);
        yield return new WaitForSeconds(3);
        detectivemalo[0].SetActive(false);
        cocomalo[0].SetActive(true);
        yield return new WaitForSeconds(4);
        cocomalo[0].SetActive(false);
        detectivemalo[1].SetActive(true);
        yield return new WaitForSeconds(4);
        detectivemalo[1].SetActive(false);
        cocomalo[1].SetActive(true);
        yield return new WaitForSeconds(4);
        cocomalo[1].SetActive(false);
        detectivemalo[2].SetActive(true);
        yield return new WaitForSeconds(4);
        detectivemalo[2].SetActive(false);
        cocomalo[2].SetActive(true);
        yield return new WaitForSeconds(4);
        cocomalo[2].SetActive(false);
        luz1.SetActive(false);
        luz2.SetActive(true);
        yield return new WaitForSeconds(4);
        Application.Quit();
    }
    IEnumerator finalbueno()
    {
        CharacterMovement.movimiento = false;
        CharacterMovement.speed = 0f;
        coco.GetComponent<BoxCollider2D>().enabled = false;
        yield return new WaitForSeconds(2);
 
        cocobueno[0].SetActive(true);
        yield return new WaitForSeconds(4);
        cocobueno[0].SetActive(false);
        detectivebueno[0].SetActive(true);
        
        yield return new WaitForSeconds(4);
        detectivebueno[0].SetActive(false);
        cocobueno[1].SetActive(true);
        yield return new WaitForSeconds(4);
        cocobueno[1].SetActive(false);
        detectivebueno[1].SetActive(true);
        yield return new WaitForSeconds(4);
        detectivebueno[1].SetActive(false);        
        detectivebueno[2].SetActive(true);
        yield return new WaitForSeconds(4);
        detectivebueno[2].SetActive(false);
        cocobueno[2].SetActive(true);
        yield return new WaitForSeconds(4);
        cocobueno[2].SetActive(false);
        luz1.SetActive(false);
        luz2.SetActive(true);
        yield return new WaitForSeconds(4);
        Application.Quit();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "oso"&&pajar.juanasequema==true)
        {
            StartCoroutine("finalmalo");
        }
        if (collision.gameObject.tag == "oso" && pajar.lavasasalvar == true)
        {
            StartCoroutine("finalbueno");
        }
    }


}
