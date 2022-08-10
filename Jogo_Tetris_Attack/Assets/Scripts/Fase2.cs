using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fase2 : MonoBehaviour
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
        texto.text = "Parábens! você passou para a próxima fase";
        yield return new WaitForSeconds(4f);
        texto.text = "";
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Scene3");
    }
}
