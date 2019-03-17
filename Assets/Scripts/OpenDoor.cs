using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoor : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gm;
    public GameObject parent;
    public GameObject enterbut;
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
                //nissan gm.transform.localPosition = new Vector3(x + (-0.484f), y + (0.35773f), z + (-0.001f));
                //nissan                gm.transform.localRotation = Quaternion.Euler(0, 0, -90f + (31.889f));
                gm.transform.localPosition = new Vector3(x + (-245f), y, z + (-195.65f));
                gm.transform.localRotation = Quaternion.Euler(0,-15.581f ,0);
                enterbut.SetActive(true);
                cl = !cl;
            }
            else
            {
                cl = !cl;
                //nissan              gm.transform.localPosition = new Vector3(x, y, z);
                //nissan              gm.transform.localRotation = Quaternion.Euler(0, 0, -90f);
                gm.transform.localPosition = new Vector3(x, y, z);
                gm.transform.localRotation= Quaternion.Euler(0,0,0);
                enterbut.SetActive(false);
            }
            }
        
    }
}
