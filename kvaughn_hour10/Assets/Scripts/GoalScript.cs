using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    // Start is called before the first frame update
    private bool solved = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == tag)
            {
            solved = true;
            other.GetComponent<Rigidbody>().isKinematic = true;
            }
    }

    public bool isSolved()
    {
        return solved;
    }
}
