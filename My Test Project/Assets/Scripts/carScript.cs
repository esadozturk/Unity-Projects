using UnityEngine;

public class carScript : MonoBehaviour
{
    public AudioSource gasSoundSource;
    public AudioClip gasSoundClip;
    public float rotationVal = 0.3f;
    public float speed = 5f;

    void Update()
    {
        if (Input.GetAxis("Horizontal") == 1)
        {
            transform.Rotate(0, rotationVal, 0);           
        }
        else if (Input.GetAxis("Horizontal") == -1)
        {
            transform.Rotate(0, -rotationVal, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            gasSoundSource.PlayOneShot(gasSoundClip);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
            gasSoundSource.PlayOneShot(gasSoundClip);

        }
        if (!Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.W))
        {
            gasSoundSource.Stop();
        }
    }

}
