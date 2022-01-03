using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    // This is a tint
    [SerializeField] Color32 hasPackageColor = new Color32 (255,0,220,255); 
    [SerializeField] Color32 noPackageColor = new Color32 (255,255,255,255);
    [SerializeField] float destroyDelay = 0.01f;

    SpriteRenderer spriteRenderer;

    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Is insurance going to pay for that?");
    }

    void OnTriggerEnter2D(Collider2D other) {
        // if (the thing we trigger is a package)
        // then print package picked up in console
        if (other.tag == "Package" && !hasPackage) 
        {
            Debug.Log("Package Picked Up!");
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
            spriteRenderer.color = hasPackageColor;
        }

        if (other.tag == "Customer" && hasPackage) 
        {
            Debug.Log("Delivered Package!");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
