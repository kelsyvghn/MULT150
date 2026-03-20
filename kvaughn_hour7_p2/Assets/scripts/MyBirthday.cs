using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int day = 0; day <= 30; day++)
        {
            if (day == 4)
            {
                print("it's my birthday!!");
                
            }
            else
            {
                //print("it is the " + day + " of the month");
                print(day);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
