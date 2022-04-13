using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Bloco
{
    blue, yellow, green, red, pink
}
public class GameController : MonoBehaviour
{
    /*
    public GameObject[] bloco;
    public GameObject mouseL, mouseR;
    private float Horizontal, Vertical;
    */
    //----------------------------------------------------------------------------------------------------------------------------------
    public GameObject[] Bol;
    public Transform[] local;
    //----------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        Instantiate(Bol[(int)Random.Range(0, 5)], new Vector3(local[0].position.x, local[0].position.y, 0), Quaternion.identity);
        Instantiate(Bol[(int)Random.Range(0, 5)], new Vector3(local[1].position.x, local[1].position.y, 0), Quaternion.identity);
        Instantiate(Bol[(int)Random.Range(0, 5)], new Vector3(local[2].position.x, local[2].position.y, 0), Quaternion.identity);
        Instantiate(Bol[(int)Random.Range(0, 5)], new Vector3(local[3].position.x, local[3].position.y, 0), Quaternion.identity);
        Instantiate(Bol[(int)Random.Range(0, 5)], new Vector3(local[4].position.x, local[4].position.y, 0), Quaternion.identity);
        Instantiate(Bol[(int)Random.Range(0, 5)], new Vector3(local[5].position.x, local[5].position.y, 0), Quaternion.identity);
        Instantiate(Bol[(int)Random.Range(0, 5)], new Vector3(local[6].position.x, local[6].position.y, 0), Quaternion.identity);
        Instantiate(Bol[(int)Random.Range(0, 5)], new Vector3(local[7].position.x, local[7].position.y, 0), Quaternion.identity);
        Instantiate(Bol[(int)Random.Range(0, 5)], new Vector3(local[8].position.x, local[8].position.y, 0), Quaternion.identity);
        Instantiate(Bol[(int)Random.Range(0, 5)], new Vector3(local[9].position.x, local[9].position.y, 0), Quaternion.identity);
        Instantiate(Bol[(int)Random.Range(0, 5)], new Vector3(local[10].position.x, local[10].position.y, 0), Quaternion.identity);
        Instantiate(Bol[(int)Random.Range(0, 5)], new Vector3(local[11].position.x, local[11].position.y, 0), Quaternion.identity);
        Instantiate(Bol[(int)Random.Range(0, 5)], new Vector3(local[12].position.x, local[12].position.y, 0), Quaternion.identity);
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
}
