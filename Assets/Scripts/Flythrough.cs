using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flythrough : MonoBehaviour
{
    public Vector3 CameraStartPosition;
    public Vector3 CameraStartRotation;
    public float CameraMoveSpeed = 10f;
    public float CameraRotateSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {        
        Vector3 deltaRot = Vector3.zero;
        // Forward/Backward
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKey(KeyCode.W))
        {            
            transform.Translate(Vector3.forward * Time.deltaTime * CameraMoveSpeed);
        }
        else if(Input.GetKeyDown(KeyCode.S) || Input.GetKey(KeyCode.S))
        {            
            transform.Translate(Vector3.back * Time.deltaTime * CameraMoveSpeed);
        }
        // Left/Right
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * CameraMoveSpeed);
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * CameraMoveSpeed);
        }
        // Up/Down
        if(Input.GetKeyDown(KeyCode.Q) || Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.up * Time.deltaTime * CameraMoveSpeed);
        }
        else if(Input.GetKeyDown(KeyCode.E) || Input.GetKey(KeyCode.E))
        {
            transform.Translate(Vector3.down * Time.deltaTime * CameraMoveSpeed);
        }                

        // Rotate Left/Right (Y)
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            deltaRot.y = -Time.deltaTime;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            deltaRot.y = Time.deltaTime;
        }
        // Rotate Up/Down (X)
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKey(KeyCode.UpArrow))
        {
            deltaRot.x = -Time.deltaTime;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            deltaRot.x = Time.deltaTime;
        }

        transform.eulerAngles += (deltaRot * CameraRotateSpeed);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = CameraStartPosition;
            transform.eulerAngles = CameraStartRotation;
        }
    }
}
