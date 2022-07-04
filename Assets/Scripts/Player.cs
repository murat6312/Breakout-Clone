using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class Player : MonoBehaviour
{
    Rigidbody rb;
    private float horizontalInput;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void update()
    {
        horizontalInput = Input.GetAxis("Horizontal") * 5;
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(horizontalInput, rb.velocity.y, rb.velocity.z);

    }
}
*/

public class Player : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    Vector3 mousex;
    void Start()
    {
        Cursor.visible = false;
        rb = GetComponent<Rigidbody>();
    }

    void update()
    {
        
    }
    

    void FixedUpdate()
    {
        mousex = new Vector3(Input.mousePosition.x, 0, 0) * 30f ;
        rb.MovePosition(new Vector3(Camera.main.ScreenToViewportPoint(mousex).x, -17, -50));
        
    }
}


