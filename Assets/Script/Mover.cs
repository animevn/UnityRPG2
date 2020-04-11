using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    [SerializeField] Transform target;
    Ray rayLight;
        
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            rayLight = Camera.main.ScreenPointToRay(Input.mousePosition);
            
        }
        Debug.DrawRay(rayLight.origin, rayLight.direction * 1000);
        GetComponent<NavMeshAgent>().destination = target.position;
    }
}
