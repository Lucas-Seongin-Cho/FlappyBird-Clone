using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePipe : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe; // Creating a pipe in GameObject form
    public float timediff; // Input
    float timer; //  Making a varable
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; // By adding delta time, let the timer equal to every FPS
        if (timer>timediff) // Create a pipe in every timediff 
        {
           GameObject newpipe = Instantiate(pipe); 
           newpipe.transform.position = new Vector3(3.23f, Random.Range(-1.0f, 2.2f),0); // Create new pipe in random Y range
            timer = 0; // Reset the timeer after creating a pipe
            Destroy(newpipe, 10.0f);
        }
    }
}
