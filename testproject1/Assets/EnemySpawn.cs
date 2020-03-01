using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemySpawn : MonoBehaviour
{
    public float targetTime = 2f;
    public Transform firePoint;
    public GameObject shipPrefab1;
    public GameObject shipPrefab2;
    public Transform pt1;
    public Transform pt2;
    public Transform pt3;
    public Transform pt4;
    System.Random random = new System.Random();
    // Update is called once per frame
    void Update()
    {
        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            timerEnded();
        }
    }

    void timerEnded()
    {
        //GameObject obj = Instantiate(shipPrefab, firePoint.position, firePoint.rotation) as GameObject;
        //obj.GetComponent<Bullet>().rorl = 
        int ok = random.Next(0, 4);
        if (ok == 0)
        {
            Instantiate(shipPrefab1, pt1.position, pt1.rotation);
        }
        else if (ok == 1)
        {
            Instantiate(shipPrefab1, pt2.position, pt2.rotation);
        }
        else if (ok == 2)
        {
            Instantiate(shipPrefab2, pt3.position, pt3.rotation);
        }
        else if (ok ==3)
        {
            Instantiate(shipPrefab2, pt4.position, pt4.rotation);
        }
        targetTime = 2f;
    }
}
