using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyramidGenerator : MonoBehaviour
{
    public GameObject cubePrefab; // used for my block prefab
    public int pyramidHeight = 5; // manages the height of the pyramid and i made it public so that works as well
    public int pryamidBaseSize = 10; // controls the base size of each layer for the pyramid
    void Start()
    {
        generateRealPyramid();
    }

   //I made the generateRealPryamid to also consider the z axis so it would create an actual 3d pyramid
    void generateRealPyramid()
    {   
        int levelPyramidBase = pryamidBaseSize;
        int levelStart = 0;
        for (int y = 0; y < pyramidHeight; y++)
        {
            for (int x = levelStart ; x < levelPyramidBase; x++)
            {

                for (int z = levelStart; z < levelPyramidBase; z++)
                {
                float xPos = x;
                float yPos = y;
                float zPos = z;

                Vector3 cubePosition = new Vector3(xPos, yPos, zPos);

                // Offset the entire pyramid upward so that its base is at y = 0
                Instantiate(cubePrefab, cubePosition + transform.position, Quaternion.identity, transform);
                }
            }
            levelStart++;
            levelPyramidBase = levelPyramidBase - 1;
        }
    }
}
