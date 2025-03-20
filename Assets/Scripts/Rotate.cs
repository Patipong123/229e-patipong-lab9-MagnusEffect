using UnityEngine;

public class Rotate : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 angularV, torque;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.angularVelocity = angularV;
        }
        else if (Input.GetKeyDown(KeyCode.Q)) 
        {
            rb.AddTorque(torque);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            rb.angularVelocity = Vector3.zero;
        }
    }
}
