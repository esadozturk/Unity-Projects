using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private float scaleRate = 5.2f;
    private Vector3 position = new Vector3(3, 4, 1);
    public float red = 0.2f;
    public float green = 0.8f;
    public float blue = 0.1f;
    public float alpha = 0.9f;
    public float xRotationRate = 10.0f;
    public float yRotationRate = 6.7f;
    public float zRotationRate = 8.3f;
    
    void Start()
    {
        transform.position = position;
        transform.localScale = Vector3.one * scaleRate;
        
        Material material = Renderer.material;
        material.color = new Color(red, green, blue, alpha);
    }
    
    void Update()
    {
        transform.Rotate(xRotationRate * Time.deltaTime, yRotationRate * Time.deltaTime, zRotationRate * Time.deltaTime);
        
        Instantiate
    }
}
