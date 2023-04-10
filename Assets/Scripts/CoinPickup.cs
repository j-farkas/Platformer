using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] AudioClip CoinPickupSFX;
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player")
        {   
            AudioSource.PlayClipAtPoint(CoinPickupSFX, Camera.main.transform.position);
            Destroy(gameObject);
        }
         
    }
}
