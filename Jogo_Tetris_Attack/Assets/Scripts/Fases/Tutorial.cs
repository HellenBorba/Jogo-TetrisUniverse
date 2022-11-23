using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    public Text texto;

    private GameController GM;
    //----------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        GM = GameObject.Find("GameController").GetComponent<GameController>();
        texto.text = "Você pode trocar blocos utilizando o R";
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(paineis());
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    IEnumerator paineis()
    {
        yield return new WaitForSeconds(0f);
        texto.text = "Agora tente fazer pontos, basta deixar 3 blocos iguais um ao lado do outro! Na vertical ou na horizontal";
        yield return new WaitForSeconds(4f);
        texto.text = "";
    }
    //----------------------------------------------------------------------------------------------------------------------------------
}
