using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellController : MonoBehaviour
{
   public ParticleSystem shellExlposion;

   private void OnCollisionEnter(Collision other)
   {
       ParticleSystem fire = Instantiate(shellExlposion, transform.position, Quaternion.identity);

       fire.Play();
       
       Destroy(gameObject);
       Destroy(fire.gameObject,1.0f);
   }
}
