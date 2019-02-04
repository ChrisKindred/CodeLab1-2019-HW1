using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 3, 1f);
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
       GameObject newPrize = Instantiate(Resources.Load<GameObject>("Prefab/Prize"));
       newPrize.transform.position = new Vector2(Random.Range(-10, 10), Random.Range(-5, 5));
    }
    
}
