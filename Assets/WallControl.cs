using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallControl : MonoBehaviour
{
    float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)== true)
        {
            transform.Translate(Vector3.back*speed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow)== true)
        {
            transform.Translate(Vector3.forward*speed*Time.deltaTime);
        }
    }
}
