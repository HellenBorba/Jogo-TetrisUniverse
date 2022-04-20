using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlocoDescendo : MonoBehaviour
{
    public float time, stop;
    //----------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        time += Time.deltaTime;
        if (stop == 1)
        {
            print("Funciona");
        }
        else if(time >= 1)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 1.15f, transform.position.z);
            time = 0;
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Col") || (collision.gameObject.CompareTag("Bloco")))
        {
            if(stop == 0)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + 1.15f, transform.position.z);
                stop = 1;
            }
        }
        if(collision.gameObject.CompareTag("Nol"))
        {
            SceneManager.LoadScene(1);
        }
    }
}
