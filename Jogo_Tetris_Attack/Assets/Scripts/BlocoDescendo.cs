using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlocoDescendo : MonoBehaviour
{
    [SerializeField]
    private float time, stop;

    private GameController TM;
    private MouseRScript MR;
    private MouseLScript ML;
    //----------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        MR = GameObject.Find("MouseR").GetComponent<MouseRScript>();
        ML = GameObject.Find("MouseL").GetComponent<MouseLScript>();
        TM = GameObject.Find("GameController").GetComponent<GameController>();
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        time += Time.deltaTime;
        if (stop == 1)
        {
            //print("Funciona");
        }
        else if(time >= 1)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 1.15f, transform.position.z);
            time = 0;
        }
        //----------------------------------------------------------------------------------------------------------------------------------
        if (Input.GetButtonDown("Fire2"))
        {
            MR.bloco.transform.position = ML.blocoposition;
            ML.bloco.transform.position = MR.blocoposition;
            if (MR.bloco.tag == ML.bloco.tag)
            {
                Destroy(ML.bloco);
                Destroy(MR.bloco);
            }
           // BlocoDestroy();
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Col") || (collision.gameObject.CompareTag("Blue") || (collision.gameObject.CompareTag("Purple") || (collision.gameObject.CompareTag("Green") || (collision.gameObject.CompareTag("Red") || (collision.gameObject.CompareTag("Yellow")))))))
        {
            if(stop == 0)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + 1.15f, transform.position.z);
                stop = 1;
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------
        if (collision.gameObject.CompareTag("Nol"))
        {
            TM.tempoStop = false;
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    public void BlocoDestroy()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - 1.15f, transform.position.z);
        stop = 0;
    }
}
