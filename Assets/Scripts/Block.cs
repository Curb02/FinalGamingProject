using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour

{

    private void Update()

    {

        // Check if the GameObject is on the ground

        if (transform.position.y <= 100.0f)

        {

            // Increase the size by 1% every 1 second

            float scaleFactor = 0.05f;

            Vector3 currentScale = transform.localScale;

            Vector3 newScale = currentScale + new Vector3(scaleFactor, scaleFactor, scaleFactor);

            transform.localScale = newScale;

        }

    }

}