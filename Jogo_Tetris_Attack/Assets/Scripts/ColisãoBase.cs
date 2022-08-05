using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisãoBase : MonoBehaviour
{
    public float timer1, timer2, timer3, timer4, timer5, posTip;
    public GameObject bloco, blocoBase1, blocoBase2, blocoBase3, blocoBase4, blocoBase5;

    private GameController GM;
    //----------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        GM = GameObject.Find("GameController").GetComponent<GameController>();
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        if (!blocoBase1.GetComponent<ColisãoBase>().bloco)
        {
            timer1 += Time.deltaTime;
            if (timer1 >= 2)
            {
                switch (posTip)
                {
                    case 1:
                        GM.Spawn1();
                        break;
                }
                timer1 = 0;
            }
        }
        if (!blocoBase2.GetComponent<ColisãoBase>().bloco)
        {
            timer2 += Time.deltaTime;
            if (timer2 >= 2)
            {
                switch (posTip)
                {
                    case 2:
                        GM.Spawn2();
                        break;
                }
                timer2 = 0;
            }
        }
        if (!blocoBase3.GetComponent<ColisãoBase>().bloco)
        {
            timer3 += Time.deltaTime;
            if (timer3 >= 2)
            {
                switch (posTip)
                {
                    case 3:
                        GM.Spawn3();
                        break;
                }
                timer3 = 0;
            }
        }
        if (!blocoBase4.GetComponent<ColisãoBase>().bloco)
        {
            timer4 += Time.deltaTime;
            if (timer4 >= 2)
            {
                switch (posTip)
                {
                    case 4:
                        GM.Spawn4();
                        break;
                }
                timer4 = 0;
            }
        }
        if (!blocoBase5.GetComponent<ColisãoBase>().bloco)
        {
            timer5 += Time.deltaTime;
            if(timer5 >= 2)
            {
                switch (posTip)
                {
                    case 5:
                        GM.Spawn5();
                        break;
                }
                timer5 = 0;
            }
        }
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Blue") || (collision.gameObject.CompareTag("Purple") || (collision.gameObject.CompareTag("Green") || (collision.gameObject.CompareTag("Red") || (collision.gameObject.CompareTag("Yellow"))))))
        {
            bloco = collision.gameObject;
        }
    }
}
