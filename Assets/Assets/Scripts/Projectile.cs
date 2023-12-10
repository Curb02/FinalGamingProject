using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // This script is placeced on the projecticle sphere 

    public GameObject explosion;
    void Start()
    {
         Destroy(gameObject,10);
    }
    void OnCollisionEnter()
    {
        Instantiate(explosion,transform.position,transform.rotation);
        Destroy(gameObject);
    }
}
