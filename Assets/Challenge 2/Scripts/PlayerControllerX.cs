using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool canInstantiate = true;
    private float previousTime = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canInstantiate)
        {
            canInstantiate = false;
            previousTime = Time.time;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }

        if(canInstantiate == false && Time.time-previousTime>3)
        {
            canInstantiate = true;
        }
    }
}
