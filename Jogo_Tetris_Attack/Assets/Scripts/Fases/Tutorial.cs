using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    public Text texto;
    public Animator anim, anim1, anim2;

    private GameController GM;
    //----------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        GM = GameObject.Find("GameController").GetComponent<GameController>();
        //----------------------------------------------------------------------------------------------------------------------------------
        texto.text = "Você pode trocar blocos utilizando o R.";
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            texto.text = "Agora tente fazer pontos, basta deixar 3 blocos iguais um ao lado do outro! Na vertical ou na horizontal. Tente primeiro na vertical, junte os blocos que estão brilhando.";
            anim.SetFloat("Cor", 1);
            anim1.SetFloat("Cor1", 1);
            anim2.SetFloat("Cor2", 1);
        }
        if(GM.points >= 3)
        {
            StartCoroutine(sla());
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------]
    IEnumerator sla()
    {
        yield return new WaitForSeconds(0f);
        texto.text = "Isso ai! Note que você ganhou pontos!";
        yield return new WaitForSeconds(4f);
        texto.text = "Hora de começar a jogar de verdade!Boa Sorte!!";
        yield return new WaitForSeconds(4f);
        texto.text = "";
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Menu");
    }
    //----------------------------------------------------------------------------------------------------------------------------------
}
