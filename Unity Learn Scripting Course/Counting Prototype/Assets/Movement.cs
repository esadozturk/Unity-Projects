using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 0.5f;
    
    private float forwardInput;
    private float horizontalInput;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * forwardInput * speed);
        transform.Translate(Vector3.right * horizontalInput * speed);
    }
}
