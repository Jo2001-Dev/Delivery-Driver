using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    SpriteRenderer spriteRenderer;
    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }
    [SerializeField] float DestructionT = 0.5f ;
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
  
    void OnCollisionEnter2D(Collision2D other)
    {
        
    
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Package" && hasPackage == false)
        {
            Debug.Log("Package picked Up!");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, DestructionT);

        }
        if (other.tag == "Customer" && hasPackage == true)
        {
            Debug.Log("Package Delivered!");
            spriteRenderer.color = noPackageColor;
            hasPackage = false;
        }

        


    }
}
