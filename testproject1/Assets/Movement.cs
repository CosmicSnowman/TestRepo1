using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    public float shipRotate = 18f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);


        transform.localRotation = Quaternion.Euler(new Vector3(0, 0, rb.transform.rotation.eulerAngles.z + shipRotate));
        if (rb.transform.rotation.eulerAngles.z < -50)
        {
            shipRotate = shipRotate * -1;
        }
        else if (rb.transform.rotation.eulerAngles.z > 50)
        {
            shipRotate = shipRotate * -1;
        }
    }
}
