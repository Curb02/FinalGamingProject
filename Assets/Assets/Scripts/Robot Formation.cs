using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotFormation : MonoBehaviour
{
    // Generates my robots in a circle formation

    public GameObject prefab;
    public int numberOfObjects = 20;
    public float radius = 5f;

    void Start() 
    {
        for(int y = 0; y < 1; y++)
       {
        for (int i = 0; i < numberOfObjects; i++)
        {
            float angle = i * Mathf.PI * 2 / numberOfObjects;
            float x = Mathf.Cos(angle) * radius;
            float z = Mathf.Sin(angle) * radius;
            Vector3 pos = transform.position + new Vector3(x, y, z);
            float angleDegrees = -angle*Mathf.Rad2Deg;
            Quaternion rot = Quaternion.Euler(0, angleDegrees, 0);
            Instantiate(prefab, pos, rot);
        }
        }
    }
}
