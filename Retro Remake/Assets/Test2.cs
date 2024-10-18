using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    public GameObject Prefab;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn",5, 3);
    }

    // Update is called once per frame
    void spawn()
    {
        Instantiate(Prefab, transform.position + offset, Quaternion.identity);
    }
}
