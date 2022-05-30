using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShoot : MonoBehaviour
{
   public Rigidbody prefabshell;
   public Transform firefTransform;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Fire();
        
        }
    }
    void Fire()
    {
        Rigidbody InstanceShell = Instantiate(prefabshell, firefTransform.position, firefTransform.rotation) as Rigidbody;
        InstanceShell.velocity = 30.0f * firefTransform.forward;
    }
}
