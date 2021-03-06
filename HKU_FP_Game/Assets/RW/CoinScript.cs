﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public AudioSource collectSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 90 * Time.deltaTime, 0); 
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.name == "Player")
        {
            // Play the sound cue associated with collecting a coin
            collectSound.Play();
            
            //Add 1 to points
            other.GetComponent<PlayerScript>().points++;
            
            //this destroys things
            Destroy(gameObject); 
        }
    }
}
