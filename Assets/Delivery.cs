using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool Package=false;
    [SerializeField] float dellay = 0.5f;
    [SerializeField] Color32 hasPackageColor;
    [SerializeField] Color32 noPackageColor = new Color32(1,1,1,1);

    SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other) {
       
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package" && !Package){
            Debug.Log("Package taken!");
            Package =true;
            Destroy(other.gameObject, dellay);
            spriteRenderer.color=hasPackageColor;
        }
        if (other.tag == "Post"&&Package){
            Debug.Log("Package Delivered!");
            Package=false;
            spriteRenderer.color=noPackageColor;
        }
        
    }
}
