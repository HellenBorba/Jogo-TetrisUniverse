using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            print("oi");
        }
        else if(time >= 1)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 1.15f, transform.position.z);
            time = 0;
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Col"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 1.15f, transform.position.z);
            stop = 1;
        }
    }
}
