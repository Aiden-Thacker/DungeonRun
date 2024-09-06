using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SuperPupSystems.Helper;

public class Spikes : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        Health playerhealth = other.GetComponent<Health>();
        if(other.CompareTag("Player"))
        {
            Debug.Log("Player has Died");
            playerhealth.currentHealth = 0;
        }
    }
}
