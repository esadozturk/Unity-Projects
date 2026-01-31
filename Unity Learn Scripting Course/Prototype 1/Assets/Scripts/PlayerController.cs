using UnityEngine;

public class PlayerController : MonoBehaviour
{ 
    [SerializeField] private float speed = 7.0f;
    [SerializeField] private float turnSpeed = 50.0f;
    private float horizontalInput;
    public float forwardInput;

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotate the vehicle according to horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
