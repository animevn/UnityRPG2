using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveTarget : MonoBehaviour
{
   [SerializeField] Transform target;

    // Update is called once per frame
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = target.position;
    }
}
