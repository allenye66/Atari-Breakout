using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        float mousex = Input.mousePosition.x;
        float mousey = Input.mousePosition.y;
        Vector2 yuh = new Vector2(mousex, mousey);
        transform.position = yuh;
    }
}
