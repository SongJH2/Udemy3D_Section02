using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    Rigidbody rigidbody;
    MeshRenderer meshRenderer;

    [SerializeField] float timeToWait = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        meshRenderer = GetComponent<MeshRenderer>();

        meshRenderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait && !meshRenderer.enabled)
        {
            meshRenderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
