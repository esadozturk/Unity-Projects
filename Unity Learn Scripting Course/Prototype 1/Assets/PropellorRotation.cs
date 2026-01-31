using UnityEngine;

public class PropellorRotation : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, 10);
    }
}
