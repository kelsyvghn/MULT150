using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    int count = 0;
    private float distance = 2f;

    // Start is called before the first frame update
    void Start()
    {
       // AddLamps(count);
       while (count < 10)
       {
           Vector3 offset = new Vector3(count, distance, count);
           Instantiate(prefab, transform.position + offset, Quaternion.identity);
           count += 1;
       }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))Instantiate(prefab);
        if (Input.GetKeyDown(KeyCode.Space))Instantiate(prefab, transform.position, transform.rotation);
    }


}
