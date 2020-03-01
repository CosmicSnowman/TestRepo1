using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet2 : MonoBehaviour
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
        GameObject enemy = hitInfo.gameObject;
        if (enemy != null && enemy.tag != "Finish" && enemy.tag == "Player")
        {
            Debug.Log("hi");
            Destroy(enemy);
            Destroy(gameObject);
            SceneManager.LoadScene(0);
        }
        else if (enemy != null && enemy.tag != "Finish" && enemy.tag == "GameController")
        {
            Destroy(gameObject);
        }



        //check if it is enemyship here
    }

}
