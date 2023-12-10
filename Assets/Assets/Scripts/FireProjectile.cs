using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    // Launches the Projectile so that the Player aka the turret will be able to shoot

[SerializeField] private AudioClip sndNewDamage;
[SerializeField] private AudioClip sndCrashWarning;
[SerializeField] private AudioClip sndHasDamageWarning;
[SerializeField] private AudioClip sndFueldLow;
    public Rigidbody projectile;
    public float speed = 4;


    //Now I'm Keeping track of both the total shots fired and time elapsed with the turret object

    public int totalShotsFired = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody p = Instantiate(projectile, transform.position, transform.rotation);
            p.velocity = transform.forward * speed;
            totalShotsFired++;
            print("Total Shots Fired = " + totalShotsFired);
        }
    }
}
