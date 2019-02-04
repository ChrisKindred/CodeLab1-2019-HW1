using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{

    public KeyCode upKey;
    public KeyCode rightKey;
    public KeyCode leftKey;
    public KeyCode downKey;
    
    public float forceAmount = 1;

    Rigidbody2D rb;

    public int score = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update() {
        
        Vector2 newForce = new Vector2(); //the force we will add to our player
        
        if (Input.GetKey(upKey)) //When someone presses "W"
        {
            newForce.y += forceAmount;
        }
        
        else if (Input.GetKey(downKey)) //When someone presses "S"
        {
            newForce.y -= forceAmount;
        }
        
        else if (Input.GetKey(leftKey)) //When someone presses "A"
        {
            newForce.x -= forceAmount;
        }
  
        else if (Input.GetKey(rightKey)) //When someone presses "D"
        {
            newForce.x += forceAmount;
        }
        
        rb.AddForce(newForce);
        
    }
}
