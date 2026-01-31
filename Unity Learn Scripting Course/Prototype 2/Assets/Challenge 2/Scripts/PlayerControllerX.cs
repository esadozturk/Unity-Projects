using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool canSend = true;
    private float waitTime = 0.0f;
    
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canSend)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            canSend = false;
        }

        if (canSend == false)
        {
            waitTime += Time.deltaTime;
        }
        
        if (waitTime > 0.5f)
        {
            canSend = true;
            waitTime = 0.0f;
        }
    }
}
