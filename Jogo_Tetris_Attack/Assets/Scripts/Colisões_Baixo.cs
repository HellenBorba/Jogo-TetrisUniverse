using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisões_Baixo : MonoBehaviour
{
    public float timer1, timer2, timer3, timer4, timer5;
    public GameObject blocoEsquerda, bloco, blocoCima, blocoDireita;
    public int posTip, id;

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
        if (bloco && blocoDireita && blocoEsquerda)
        {
            if (blocoEsquerda.GetComponent<Colisão>().bloco && blocoDireita.GetComponent<Colisão>().bloco)
            {
                if (blocoEsquerda.GetComponent<Colisão>().bloco.tag == bloco.tag && blocoDireita.GetComponent<Colisão>().bloco.tag == bloco.tag)
                {
                    timer2 += Time.deltaTime;
                    if (timer2 >= 0.3f)
                    {
                        Destroy(blocoEsquerda.GetComponent<Colisão>().bloco);
                        Destroy(bloco);
                        Destroy(blocoDireita.GetComponent<Colisão>().bloco);
                        blocoEsquerda.GetComponent<Colisão>().bloco = null;
                        bloco.GetComponent<Colisão>().bloco = null;
                        blocoDireita.GetComponent<Colisão>().bloco = null;
                        GM.points += 3;
                        timer2 = 0;
                    }
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
