using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colis�es_Baixo : MonoBehaviour
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
            if (blocoEsquerda.GetComponent<Colis�o>().bloco && blocoDireita.GetComponent<Colis�o>().bloco)
            {
                if (blocoEsquerda.GetComponent<Colis�o>().bloco.tag == bloco.tag && blocoDireita.GetComponent<Colis�o>().bloco.tag == bloco.tag)
                {
                    timer2 += Time.deltaTime;
                    if (timer2 >= 0.3f)
                    {
                        Destroy(blocoEsquerda.GetComponent<Colis�o>().bloco);
                        Destroy(bloco);
                        Destroy(blocoDireita.GetComponent<Colis�o>().bloco);
                        blocoEsquerda.GetComponent<Colis�o>().bloco = null;
                        bloco.GetComponent<Colis�o>().bloco = null;
                        blocoDireita.GetComponent<Colis�o>().bloco = null;
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
            if (blocoCima.GetComponent<Colis�o>().bloco)
            {
                blocoCima.GetComponent<Colis�o>().bloco.transform.position = new Vector3(transform.position.x, transform.position.y - 1.15f, transform.position.z);
                blocoCima.GetComponent<Colis�o>().bloco = null;
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
