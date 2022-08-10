using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fase3 : MonoBehaviour
{
    public Text texto;

    private GameController GM;
    //----------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        GM = GameObject.Find("GameController").GetComponent<GameController>();
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        if (GM.points >= GM.pontosFase)
        {
            StartCoroutine(paineis());
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    IEnumerator paineis()
    {
        yield return new WaitForSeconds(0f);
        texto.text = "Par�bens voc� passou! voc� foi �timo!";
        yield return new WaitForSeconds(7f);
        texto.text = "";
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Menu");
    }
}
