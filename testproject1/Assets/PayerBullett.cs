using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PayerBullett : MonoBehaviour
{
    public float speed = 0.001f;
    public Rigidbody2D rb;
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = -transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);

        GameObject enemy = hitInfo.gameObject;
        if (enemy != null && enemy.tag != "Player" && enemy.tag == "Finish")
        {
            Debug.Log("Wow");
            Destroy(enemy);
            Destroy(gameObject);
        }

        
    }

}
