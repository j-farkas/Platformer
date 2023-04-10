using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] AudioClip CoinPickupSFX;

    bool collected = false;
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player" && !collected)
        {   
            collected = true;
            AudioSource.PlayClipAtPoint(CoinPickupSFX, Camera.main.transform.position);
            FindObjectOfType<GameSession>().addCoin();
            Destroy(gameObject);
        }
         
    }
}
