using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f;
    
    private Rigidbody playerRb;

    private float zBoundLower = -6.0f;
    private float zBoundUpper = 17.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        ConstrainPlayerPosition();
    }
    
    // Movement
    void MovePlayer()
    {
        playerRb.AddForce(Vector3.forward * speed * Input.GetAxis("Vertical") * Time.deltaTime, ForceMode.Impulse);
        playerRb.AddForce(Vector3.right * speed * Input.GetAxis("Horizontal") * Time.deltaTime, ForceMode.Impulse);
        //transform.Translate(Vector3.forward * (speed * Time.deltaTime * Input.GetAxis("Vertical")));
        //transform.Translate(Vector3.right * (speed * Time.deltaTime * Input.GetAxis("Horizontal")));
    }

    // Constrain
    void ConstrainPlayerPosition()
    {
        if (transform.position.z < zBoundLower)
        {
            transform.position = new Vector3 (transform.position.x, transform.position.y, zBoundLower);
        }
        else if (transform.position.z > zBoundUpper)
        {
            transform.position = new Vector3 (transform.position.x, transform.position.y, zBoundUpper);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player crashed to a fire ball.");
        Destroy(other.gameObject);
    }
}
