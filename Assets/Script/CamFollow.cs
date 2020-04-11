using UnityEngine;

public class CamFollow : MonoBehaviour
{
    [SerializeField] Transform target;
        
    void LateUpdate(){
        transform.position = target.position;
    }
}
