using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenHood: MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gm;
    public GameObject parent;
   
    float x;
    float y;
    float z;
    bool cl = false;
    void Start()
    {

        gm.transform.parent = parent.transform;
        x = gm.transform.localPosition.x;
        y = gm.transform.localPosition.y;
        z = gm.transform.localPosition.z;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseOver()
    {
        print(name);
        print("done");
        if (Input.GetMouseButtonDown(0))
        {
            if (!cl)
            {
                gm.transform.localPosition = new Vector3(x, y + (-0.601f), z + (-0.336f));
                gm.transform.localRotation = Quaternion.Euler(-30f, 0, -90f);
                
                cl = !cl;
            }
            else
            {
                cl = !cl;
                gm.transform.localPosition = new Vector3(x, y, z);
                gm.transform.localRotation = Quaternion.Euler(0, 0, -90f);
              
            }
        }

    }
}
