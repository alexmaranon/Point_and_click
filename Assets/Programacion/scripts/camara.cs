using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class camara : MonoBehaviour
{
    string sceneName;
    public Transform target;
    Vector3 offset;

   // private Vector3 originalPosition;
    private void Start()
    {

        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;



       


        if (sceneName == "Entrada" &&CharacterMovement.entrada == true)
        {
            gameObject.transform.position = inretaction.guardarposientrada;
        }
        if (sceneName == "Lobby" && CharacterMovement.lobby == true)
        {
            gameObject.transform.position = inretaction.guardarposi;
        }
        if (sceneName == "CalleLincoln" && CharacterMovement.calle == true)
        {
            gameObject.transform.position = inretaction.guardarposi1;
        }
        if (sceneName == "Teatro_Lincoln" && CharacterMovement.teatro == true)
        {
            gameObject.transform.position = inretaction.guardarposi2;
        }
        if (sceneName == "callejon" && CharacterMovement.callejuela == true)
        {
            gameObject.transform.position = inretaction.guardarposi3;
        }
        if (sceneName == "palco" && CharacterMovement.palco == true)
        {
            gameObject.transform.position = inretaction.guardarposi4;
        }
        if (sceneName == "Pajar" && CharacterMovement.pajar == true)
        {
            gameObject.transform.position = inretaction.guardarposipajar;
        }
        if (sceneName == "callejuana" && CharacterMovement.callejuana == true)
        {
          //  offset = inretaction.guardarposicalle - target.position;
            gameObject.transform.position = inretaction.guardarposicalle;
        }
        if (sceneName == "taberna" && CharacterMovement.tabern == true)
        {
            gameObject.transform.position = inretaction.guardarpositaber;
        }

        if (sceneName == "catedral" && CharacterMovement.cate == true)
        {
            gameObject.transform.position = inretaction.guardarposicate;
        }

        // originalPosition = transform.position;
       // offset = transform.position - target.position;

    }

    private void Update()
    {

        transform.position = target.position;// + offset;
   
    }
}
