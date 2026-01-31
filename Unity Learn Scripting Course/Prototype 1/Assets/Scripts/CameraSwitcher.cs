using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;

    private bool isCamera1Active = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        camera1.enabled = true;
        camera2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            SwitchCameras();
        }
    }

    void SwitchCameras()
    {
        isCamera1Active = !isCamera1Active; 
        camera1.enabled = isCamera1Active;
        camera2.enabled = !isCamera1Active;        
    }
}
