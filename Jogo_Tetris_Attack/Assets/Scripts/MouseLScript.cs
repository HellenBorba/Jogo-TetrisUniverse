using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLScript : MonoBehaviour
{
    public GameObject bloco;
    public Vector2 blocoposition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (collision.gameObject.CompareTag("Bloco"))
            {
                bloco = collision.gameObject;
                blocoposition = bloco.transform.position;
                bloco.transform.position = GameObject.Find("mouseL").GetComponent<MouseRScript>().blocoposition;
            }
        }
    }
}
