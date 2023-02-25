using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _forwardForce = 2000f;
    [SerializeField] private float _sidewayForce = 500f;
    
    private void FixedUpdate()
    {
        _rigidbody.AddForce(0, 0, _forwardForce *  Time.deltaTime);

        if (Input.GetKey("d"))
        {
            _rigidbody.AddForce(_sidewayForce * Time.deltaTime, 0, 0);
        }
        
        if (Input.GetKey("a"))
        {
            _rigidbody.AddForce(-_sidewayForce * Time.deltaTime, 0, 0);
        }
    }
}
