using UnityEngine;

public class MoveDown : MonoBehaviour
{
    private Rigidbody fireballRb;
    public float speed = 750.0f;
    private float zDestroy = -15.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fireballRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        fireballRb.AddForce(Vector3.back * (speed * Time.deltaTime));

        if (transform.position.z < zDestroy)
        {
            Destroy(gameObject);
        }
    }
}
