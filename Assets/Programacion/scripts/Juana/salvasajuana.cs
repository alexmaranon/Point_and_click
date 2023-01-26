using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class salvasajuana : MonoBehaviour
{
    public List<GameObject> juana = new List<GameObject> { };
    public List<GameObject> detective = new List<GameObject> { };
    string sceneName;
    public static bool hashabladoconjua;
    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;

        StartCoroutine("conver");
    }
    IEnumerator conver()
    {
        hashabladoconjua = true;
        CharacterMovement.movimiento = false;
        CharacterMovement.speed = 0f;
        yield return new WaitForSeconds(0);
        CharacterMovement.movimiento = false;
        CharacterMovement.speed = 0f;
        yield return new WaitForSeconds(1);
        CharacterMovement.movimiento = false;
        CharacterMovement.speed = 0f;
        juana[0].SetActive(true);
        yield return new WaitForSeconds(3);
        juana[0].SetActive(false);
        detective[0].SetActive(true);
        yield return new WaitForSeconds(3);
        detective[0].SetActive(false);
        juana[1].SetActive(true);
        yield return new WaitForSeconds(3);
        juana[1].SetActive(false);
        detective[1].SetActive(true);
        yield return new WaitForSeconds(3);
        detective[1].SetActive(false);
        detective[2].SetActive(true);
        yield return new WaitForSeconds(3);
        detective[2].SetActive(false);
        juana[2].SetActive(true);
        yield return new WaitForSeconds(3);
        juana[2].SetActive(false);
        yield return new WaitForSeconds(2);
        CharacterMovement.movimiento = true;
        SceneManager.LoadScene("Pajar");
    }

}
