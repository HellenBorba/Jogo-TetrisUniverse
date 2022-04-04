using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRScript : MonoBehaviour
{
    public float horizontal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if(horizontal >= 0.9f && Input.GetButtonDown("Horizontal"))
        {
            gameObject.transform.position = new Vector3(transform.position.x + 1.15f, transform.position.y, transform.position.z);
        }
        else if(horizontal <= -0.9f && Input.GetButtonDown("Horizontal"))
        {
            gameObject.transform.position = new Vector3(transform.position.x - 1.15f, transform.position.y, transform.position.z);
        }
    }
}
