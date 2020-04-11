using UnityEngine;
using UnityEngine.AI;

public class CamFollow : MonoBehaviour
{
    [SerializeField] Transform target;
        

    void Update(){
        transform.position = target.position;
    }
}
