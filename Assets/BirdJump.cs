using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb; // Bring Rigidbody 2D
    public float jumpPower; // Input 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Get Ridgidbody2D component
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Take an action when touching
        {
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * jumpPower;//(0,1) // Velocity is used to utilize Vector
        }
  
    }
     private void OnCollisionEnter2D(Collision2D other) {
         
         if(Score.score>Score.bestScore){
             Score.bestScore = Score.score;
         }
            SceneManager.LoadScene(1);
        }

}
