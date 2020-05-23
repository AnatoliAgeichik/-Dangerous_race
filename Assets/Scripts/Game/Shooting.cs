using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    
    public float bulletForce = 2000000f;

    private float timeRecharge = 3f;
    bool isShoot = true;


    // Update is called once per frame
   
    public void Shoot()
    {
        if (isShoot)
        {

            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
            

        }
        isShoot = false;
        StartCoroutine(Recharge());
    }
    IEnumerator Recharge()
    {
        yield return new WaitForSeconds(timeRecharge);
        isShoot = true;
    }
}
