using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardBlue : MonoBehaviour
{
    public float speed = 7.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right* Time.deltaTime * speed);
        
    }
}
