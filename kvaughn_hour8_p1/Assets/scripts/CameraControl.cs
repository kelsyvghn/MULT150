using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Camera");  
    }

    // Update is called once per frame
    void Update()
    {
        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");
        if(mxVal != 0)
            print("Mouse X movement selected" + mxVal);
        if(myVal != 0)
            print("Mouse Y movement selected" + myVal);
        transform.Translate(mxVal, myVal, 0f);
    }
}
