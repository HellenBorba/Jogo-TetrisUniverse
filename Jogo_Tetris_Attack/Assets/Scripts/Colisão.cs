using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisão : MonoBehaviour
{
    public float timer1, timer2, timer3, timer4, timer5;
    public GameObject blocoEsquerda, blocoBaixo, bloco, blocoCima, blocoDireita;

    private GameController GM;
    //----------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        GM = GameObject.Find("GameController").GetComponent<GameController>();
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        #region Matches
        if (bloco && blocoCima && blocoBaixo)
        {
            if (blocoCima.GetComponent<Colisão>().bloco && blocoBaixo.GetComponent<Colisão>().bloco)
            {
                if (blocoCima.GetComponent<Colisão>().bloco.tag == bloco.tag && blocoBaixo.GetComponent<Colisão>().bloco.tag == bloco.tag)
                {
                    Instantiate(GM.trocapormim, gameObject.transform.position, Quaternion.identity);
                    Instantiate(GM.trocapormim, blocoBaixo.transform.position, Quaternion.identity);
                    Instantiate(GM.trocapormim, blocoCima.transform.position, Quaternion.identity);
                    Destroy(gameObject);
                    Destroy(blocoCima);
                    Destroy(blocoBaixo);
                    GM.points += 3;         
                }
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------
        if (bloco && blocoDireita && blocoEsquerda)
        {
            if (blocoEsquerda.GetComponent<Colisão>().bloco && blocoDireita.GetComponent<Colisão>().bloco)
            {
                if (blocoEsquerda.GetComponent<Colisão>().bloco.tag == bloco.tag && blocoDireita.GetComponent<Colisão>().bloco.tag == bloco.tag)
                {
                    Instantiate(GM.trocapormim, gameObject.transform.position, Quaternion.identity);
                    Instantiate(GM.trocapormim, blocoEsquerda.transform.position, Quaternion.identity);
                    Instantiate(GM.trocapormim, blocoDireita.transform.position, Quaternion.identity);
                    Destroy(gameObject);
                    Destroy(blocoEsquerda);
                    Destroy(blocoDireita);
                    GM.points += 3;
                }
            }
        }
        #endregion
        //----------------------------------------------------------------------------------------------------------------------------------
        if (!bloco)
        {
            if (blocoCima.GetComponent<Colisão>().bloco)
            {
                blocoCima.GetComponent<Colisão>().bloco.transform.position = new Vector3(transform.position.x, transform.position.y - 1.15f, transform.position.z);
                blocoCima.GetComponent<Colisão>().bloco = null;
            }
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Blue") || (collision.gameObject.CompareTag("Purple") || (collision.gameObject.CompareTag("Green") || (collision.gameObject.CompareTag("Red") || (collision.gameObject.CompareTag("Yellow"))))))
        {
            bloco = collision.gameObject;
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------
}
