using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    private Light myLight;
    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
        myLight.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.L))
        {
            if (myLight.intensity > 0)
            {
                myLight.intensity = 0;
                
            }
            else
            {
                myLight.intensity = 8;
                //myLight.color = Color.red;
            }
            print("The 'L' key was pressed down this toggles the light off");
            
        }
         
    }
}
