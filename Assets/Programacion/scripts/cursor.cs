using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor : MonoBehaviour
{
    public SpriteRenderer rend;
    public Sprite normalcursor;
    public Sprite clickcursor;
    public Sprite talkcursor;
    public bool hablando;
    //public GameObject efecto;
    public float tiempo;
    void Start()
    {
        Cursor.visible = false;
        rend = GetComponent<SpriteRenderer>();
    }
    IEnumerator pausa()
    {
        //tiempo de espera en un objeto
        yield return new WaitForSeconds(0.1f);

        rend.sprite = normalcursor;
    }
  

    void Update()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPos;
        if (hablando == true)
        {
            rend.sprite = talkcursor;
        }
        else if (hablando == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rend.sprite = clickcursor;
                //Instantiate(efecto, transform.position, Quaternion.identity);
            }
            else if (Input.GetMouseButtonUp(0))
            {
                StartCoroutine("pausa");
            }
        }


           
        
    }
}
