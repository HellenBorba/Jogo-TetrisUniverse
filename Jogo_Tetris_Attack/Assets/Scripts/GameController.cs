using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    /*
    public GameObject[] bloco;
    public GameObject mouseL, mouseR;
    private float Horizontal, Vertical;
    */

    public GameObject[] Bol;
    public Transform[] local;

    public float timer;
    //----------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        /*
        GameObject tempPrefab = Instantiate(Bol[(int)Random.Range(0, 5)]) as GameObject;
        tempPrefab.transform.position = local[].position;
        */
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
            if (timer >= 5)
            {
                Spawn();
                timer = 0;
            }
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
        Instantiate(Bol[(int)Random.Range(0, 5)], new Vector3(local[0].position.x, local[0].position.y, 0), Quaternion.identity);
        Instantiate(Bol[(int)Random.Range(0, 5)], new Vector3(local[1].position.x, local[1].position.y, 0), Quaternion.identity);
        Instantiate(Bol[(int)Random.Range(0, 5)], new Vector3(local[2].position.x, local[2].position.y, 0), Quaternion.identity);
        Instantiate(Bol[(int)Random.Range(0, 5)], new Vector3(local[3].position.x, local[3].position.y, 0), Quaternion.identity);
        Instantiate(Bol[(int)Random.Range(0, 5)], new Vector3(local[4].position.x, local[4].position.y, 0), Quaternion.identity);
        Instantiate(Bol[(int)Random.Range(0, 5)], new Vector3(local[5].position.x, local[5].position.y, 0), Quaternion.identity);
        Instantiate(Bol[(int)Random.Range(0, 5)], new Vector3(local[6].position.x, local[6].position.y, 0), Quaternion.identity);
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    public void Jogo()
    {
        SceneManager.LoadScene(0);
    }
}
