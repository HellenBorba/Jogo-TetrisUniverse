using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] bloco;
    public GameObject mouseL, mouseR;
    private float Horizontal, Vertical;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        mouseL.transform.position = new Vector2(mousePos.x - 0.5f, mousePos.y); 
        mouseR.transform.position = new Vector2(mousePos.x + 0.5f, mousePos.y); 
    }
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
