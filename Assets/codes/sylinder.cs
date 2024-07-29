using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sylinder : MonoBehaviour
{
  

private void OnCollisionEnter(Collision collision)
{
    Vector3 silindir;
    silindir=transform.position;
    Vector3 top;
    //hareket eden nesneyi aldım
    top=collision.gameObject.transform.position;
 collision.gameObject.GetComponent<Rigidbody>().velocity=(top-silindir)*10;
    
    
}
}
