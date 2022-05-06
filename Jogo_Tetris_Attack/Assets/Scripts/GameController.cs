using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    /*
    public GameObject[] bloco;
    public GameObject mouseL, mouseR;
    private float Horizontal, Vertical;
    */

    public GameObject[] Bol;
    public Transform[] local;
    public bool tempoStop;
    public Text texto;
   
    private float timer, Points;
    private BlocoDescendo BD;
    //----------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        Spawn();
        /*
        GameObject tempPrefab = Instantiate(Bol[(int)Random.Range(0, 5)]) as GameObject;
        tempPrefab.transform.position = local[].position;
        */
        BD = GameObject.Find("Bloco_Blue (1)").GetComponent<BlocoDescendo>();
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        /*
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        mouseL.transform.position = new Vector2(mousePos.x - 0.5f, mousePos.y); 
       // mouseR.transform.position = new Vector2(mousePos.x + 0.5f, mousePos.y); 
        */
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            Spawn();
            timer = 0;
        }
       //----------------------------------------------------------------------------------------------------------------------------------
        texto.text = ("Points: ");
        
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    /*
    public void Mudança(int x)
    {
        Vector2 posicao = bloco[x].transform.position;
        Vector2 postion = bloco[2].transform.position;
        bloco[2].transform.position = posicao;
        bloco[x].transform.position = postion;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Bloco"))
        {
            bloco = collision.gameObject;
            Vector2 blocopostion = bloco.transform.position;
            bloco.transform.position = GameObject.Find("mouseL").GetCompenent<MouselScript>().blocopostion;
        }
    }
    */
    //----------------------------------------------------------------------------------------------------------------------------------
    public void Spawn()
    {
        if (tempoStop == true)
        {
            Instantiate(Bol[(int)Random.Range(0, 5)], new Vector3(local[0].position.x, local[0].position.y, 0), Quaternion.identity);
            Instantiate(Bol[(int)Random.Range(0, 5)], new Vector3(local[1].position.x, local[1].position.y, 0), Quaternion.identity);
            Instantiate(Bol[(int)Random.Range(0, 5)], new Vector3(local[2].position.x, local[2].position.y, 0), Quaternion.identity);
            Instantiate(Bol[(int)Random.Range(0, 5)], new Vector3(local[3].position.x, local[3].position.y, 0), Quaternion.identity);
            Instantiate(Bol[(int)Random.Range(0, 5)], new Vector3(local[4].position.x, local[4].position.y, 0), Quaternion.identity);
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    public void Jogo()
    {
        SceneManager.LoadScene(0);
    }
}
