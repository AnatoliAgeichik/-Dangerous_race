using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemeAI : MonoBehaviour
{

    private float _speedRotate = 10f;
    public int rotationOffset = -90;
    private float rotZ;
     Transform target;
    Rigidbody2D rb; 
    private float radiusOfVisibility=50f;
    private float minDistance = 10f;

    float distance;

    float timeRecharge=4f;

    bool isShoot = true;

    //public Transform firePoint;

    public GameObject bulletPrefab;

    public float bulletForce = 1f;

    EnemyShoot enemyShoot;

    public float speed = 1f;

    bool stopFlag = false;

    Transform firePoint;
    
    private void Start()
    {
        target = GameObject.FindGameObjectsWithTag("Player")[0].transform;
         rb = GetComponent<Rigidbody2D>();

        
    }

    private void Update()
    {
        distance = Vector2.Distance(transform.position, target.position);
        
        if (distance < radiusOfVisibility && distance>minDistance )
        {
            stopFlag = true;
            persecution();
            if (isShoot)
            {
                
                Shoot();
                isShoot = false;
                StartCoroutine(TankRecharge());
            }
        }
        else if (stopFlag)
        {
           
            rb.drag = 20;
            stopFlag = false;
        }



    }

    private void persecution()
    {
        var dir = (target.position - transform.position).normalized;
        rb.velocity = dir * speed;
        Vector3 difference = target.position - transform.position;
        rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        Quaternion rotation = Quaternion.AngleAxis(rotZ + rotationOffset, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * _speedRotate);

    }


    void Shoot()
    {

        firePoint = transform.Find("TankFirePoint");
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

    }
    IEnumerator TankRecharge()
    {
        yield return new WaitForSeconds(timeRecharge);
        isShoot = true;
    }



}
