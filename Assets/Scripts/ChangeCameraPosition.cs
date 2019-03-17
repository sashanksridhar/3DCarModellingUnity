using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraPosition : MonoBehaviour
{
    public float speed;
    private float aspeed = 10;
    private float x;
    private float y;
    private float z;
    bool rightclicked;
    // Start is called before the first frame update
    void Start()
    {
        var angles = transform.eulerAngles;
        x = angles.x;
        y = angles.y;
        z = angles.z;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.I))
        {
            x += aspeed * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(x, y, z);
        }
        if (Input.GetKey(KeyCode.K))
        {
            x -= aspeed * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(x, y, z);
        }
        if (Input.GetKey(KeyCode.J))
        {
            y += aspeed * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(x, y, z);
        }
        if (Input.GetKey(KeyCode.L))
        {
            y -= aspeed * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(x, y, z);
        }
        if (Input.GetKey(KeyCode.M))
        {
            z += aspeed * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(x, y, z);
        }
        if (Input.GetKey(KeyCode.N))
        {
            z -= aspeed * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(x, y, z);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {

            transform.localPosition += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localPosition -= new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition -= new Vector3(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += new Vector3(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {

            transform.localPosition += new Vector3(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {

            transform.localPosition -= new Vector3(0, 0, speed * Time.deltaTime);
        }
    }
    
}
