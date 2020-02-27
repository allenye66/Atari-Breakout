using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pad : MonoBehaviour
{
    public float speed = 5f;

    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*  input = Input.GetAxisRaw("Horizontal");
          Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
          transform.position += movement * Time.deltaTime;
          */
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0f, 0f);

    }

}
