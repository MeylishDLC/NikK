using UnityEngine;

public class TriggerDetector : MonoBehaviour
{
    [SerializeField] private Vector3 Force;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Rigidbody>())
        {
            other.GetComponent<Rigidbody>().AddForce(Force, ForceMode.Impulse);
        }
    }
    
}