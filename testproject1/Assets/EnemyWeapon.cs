using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    public float targetTime = 2f;
    public Transform firePoint;
    public GameObject bulletPrefab;

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
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        targetTime = 2f;
    }

}
