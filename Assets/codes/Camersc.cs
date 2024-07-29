using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camersc : MonoBehaviour
{
    [SerializeField] GameObject FollowObj;
    [SerializeField] Vector3 OffSet;
    
    void Update()
    {
        transform.position = FollowObj.transform.position + OffSet;
    }
}
