using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisão : MonoBehaviour
{
    public float timer, timerMax, posTip;
    public GameObject bloco, blocoCima;

    private GameController GM;
    //----------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        GM = GameObject.Find("GameController").GetComponent<GameController>();
        timerMax = 2;
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timerMax)
        {
            if (!bloco)
            {
                timer = 0;
                timerMax = 1;
                if (blocoCima.GetComponent<Colisão>().bloco)
                {
                    blocoCima.GetComponent<Colisão>().bloco.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                    blocoCima.GetComponent<Colisão>().bloco = null;
                }
                //----------------------------------------------------------------------------------------------------------------------------------
                else if (blocoCima.GetComponent<Colisão>().bloco == false)
                {
                    switch(posTip)
                    {
                        case 1:
                            GM.Spawn1();
                            break;
                        case 2:
                            GM.Spawn2();
                            break;
                        case 3:
                            GM.Spawn3();
                            break;
                        case 4:
                            GM.Spawn4();
                            break;
                        case 5:
                            GM.Spawn5();
                            break;
                    }
                }
            }
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    public void OnTriggerStay2D (Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Blue") || (collision.gameObject.CompareTag("Purple") || (collision.gameObject.CompareTag("Green") || (collision.gameObject.CompareTag("Red") || (collision.gameObject.CompareTag("Yellow"))))))
        {
            bloco = collision.gameObject;
        }
    }
}
