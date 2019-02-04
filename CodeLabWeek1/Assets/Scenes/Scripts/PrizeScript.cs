using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrizeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) //if the collider that hit us has a tag "Player"
        {
            other.gameObject.GetComponent<PlayerController>().score++; //Get the PlayerController and add 1 to its score

        }
            
        Destroy(gameObject); //Destroy the gameObject I am attached to
    }
}
