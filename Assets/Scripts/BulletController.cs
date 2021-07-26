using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public float bulletSpeed;
    public Rigidbody rb;
    public float lifeTime;
    public GameObject impactEffect;



    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.forward * bulletSpeed;
        lifeTime -= Time.deltaTime;
        if(lifeTime <= 0 )
        {
            Destroy(gameObject);
        }
    
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject, 2.0f);
        Instantiate(impactEffect, transform.position, transform.rotation);
    }
}
