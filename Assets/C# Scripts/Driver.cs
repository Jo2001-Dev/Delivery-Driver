using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Driver : MonoBehaviour
{
    [SerializeField]float steerSpeed = 120;
    [SerializeField]float moveSpeed = 4;
    [SerializeField]float slowSpeed = 2;
    [SerializeField]float fastSpeed = 8;
    void Update()
    {
        
     
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate (0, moveAmount, 0);
     
    
    }
    void OnCollisionEnter2D(Collision2D other) 
    {
        moveSpeed = slowSpeed;
        
    }
    
 void OnTriggerEnter2D(Collider2D other) {
           if(other.tag == "SpeedUp") 
           {
             moveSpeed = fastSpeed;
           }
           if(other.tag == "Bump") 
           {
            Debug.Log("Ouch!");
             moveSpeed = slowSpeed;
           } 
        }
}
