﻿using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour{

    void Update(){
        if (Input.GetMouseButton(0)){
            MoveToCursor();
        }
        UpdateAnimator();
    }

    private void MoveToCursor(){
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool hasHit = Physics.Raycast(ray, out hit);
        if (hasHit){
            GetComponent<NavMeshAgent>().destination = hit.point;
        } 
        Debug.DrawRay(ray.origin, ray.direction * 1000);
    }

    private void UpdateAnimator(){
        Vector3 velocity = GetComponent<NavMeshAgent>().velocity;
        Vector3 localVelocity = transform.InverseTransformDirection(velocity);
        float speed = localVelocity.z;
        GetComponent<Animator>().SetFloat("forward", speed);
        
    }

}