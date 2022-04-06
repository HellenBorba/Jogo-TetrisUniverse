using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBlocos : MonoBehaviour
{
    public int xsi, ysi;
    private GameObject[] bloco;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void PosiçãoBlocos()
    {
        for (int x = 0; x < xsi; x++)
        {
            for (int y = 0; y < ysi; y++)
            {
                //instancia item na posição (x, y)
            }
        }
    }
    void Blocos ()
    {
        bloco = Resources.LoadAll<GameObject>("Prefabs");
        for(int i = 0; i < bloco.Length; i++)
        {
            bloco[i].GetComponent<PosBlocos>().id = i;
        }
    }
}
