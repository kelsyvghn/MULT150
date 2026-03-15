using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float health = 1004;
        float PoisonDamage = 125.5f;
        print(health);
        health -= PoisonDamage;
        print(health);
        health -= PoisonDamage;
        print(health);
        health -= PoisonDamage;
        print(health);
        health -= PoisonDamage;
        print(health);
        health -= PoisonDamage;
        print(health);
        health -= PoisonDamage;
        print(health);
        health -= PoisonDamage;
        print(health);
        health -= PoisonDamage;
        print(health);
        print("Player has been unalived!");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
