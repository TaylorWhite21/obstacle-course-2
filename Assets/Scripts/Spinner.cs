using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xSpinSpeed = 0f;
    [SerializeField] float ySpinSpeed = 0f;
    [SerializeField] float zSpinSpeed = 0f;
    Transform spin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xSpinSpeed,ySpinSpeed,zSpinSpeed);
    }
}
