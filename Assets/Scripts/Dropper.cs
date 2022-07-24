using System.Security.Cryptography;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigid;
    [SerializeField] float dropTime = 5f;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;
        rigid = GetComponent<Rigidbody>();
        rigid.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (dropTime < Time.time)
        {
            renderer.enabled = true;
            rigid.useGravity = true;
        }


    }
}
