using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlocoDescendo : MonoBehaviour
{
    [SerializeField]
    public float time, stop;
    //----------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        time += Time.deltaTime;
        if (stop == 1)
        {

        } else
        if (time >= 1)
          {
            transform.position = new Vector3(transform.position.x, transform.position.y - 1.15f, transform.position.z);
            time = 0;
          }
    }
    //----------------------------------------------------------------------------------------------------------------------------------
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Col") || (collision.gameObject.CompareTag("Blue") || (collision.gameObject.CompareTag("Purple") || (collision.gameObject.CompareTag("Green") || (collision.gameObject.CompareTag("Red") || (collision.gameObject.CompareTag("Yellow")))))))
        {
            if (stop == 0)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + 1.15f, transform.position.z);
                stop = 1;
            }
        }
    }
} 
