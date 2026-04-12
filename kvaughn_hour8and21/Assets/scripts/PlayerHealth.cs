using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    int healthpoints = 3992;
    
    void Start()
    {
        healthpoints = UsePotion(healthpoints);
        print("health is currently: " + healthpoints);
        healthpoints = UsePotion(healthpoints);
        print("health is currently: " + healthpoints);
        healthpoints = UsePotion(healthpoints);
        print("health is currently: " + healthpoints);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    } 
    int UsePotion(int health)
    {
        int p = (health + 400);
        return p;
    }
}
