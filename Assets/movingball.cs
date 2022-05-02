using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingball : MonoBehaviour
{
    private Rigidbody ballRd;
    public float speed = 500.0f;
    Vector3 StartPos;

    // Start is called before the first frame update
    void Start()
    {
        ballRd = GetComponent<Rigidbody> ();

        StartPos = new Vector3 (0,0,0);
        ballRd.AddForce (-speed, 0f , speed*0.7f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.CompareTag ("WALL"))
        {
            Vector3 currPos = collision.transform.position;

            Vector3 incomVec = currPos - StartPos;
            Vector3 normalVec = collision.contacts [ 0 ].normal;
            Vector3 reflectVec = Vector3.Reflect (incomVec , normalVec);
            reflectVec = reflectVec.normalized;

            ballRd.AddForce (reflectVec * speed);
        }
        StartPos = transform.position;  //입사각 저장
    }
}
