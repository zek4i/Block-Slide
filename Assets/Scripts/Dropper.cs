using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer; //caching
    Rigidbody rigidbody;
    [SerializeField] float timeToWait = 3f;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {   

        if(Time.time > timeToWait) //after we reach a certain amount of time make the object fall
        {
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}