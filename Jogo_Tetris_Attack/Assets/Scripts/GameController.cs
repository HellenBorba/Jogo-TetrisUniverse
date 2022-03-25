using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] bloco;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Mudança(int x)
    {
        Vector2 posicao = bloco[x].transform.position;
        Vector2 postion = bloco[2].transform.position;
        bloco[2].transform.position = posicao;
        bloco[x].transform.position = postion;
    }
}
