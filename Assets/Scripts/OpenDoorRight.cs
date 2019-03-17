using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoorRight : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gm;
    public GameObject enterbut;
    public GameObject parent;
    float x;
    float y;
    float z;
    bool cl;
    void Start()
    {

        gm.transform.parent = parent.transform;
        x = gm.transform.localPosition.x;
        y = gm.transform.localPosition.y;
        z = gm.transform.localPosition.z;
    }

   
    void OnMouseOver()
    {
        print(name);
        print("done");
        if (Input.GetMouseButtonDown(0))
        {
            if (!cl)
            {
                //nissan gm.transform.localPosition = new Vector3(x - (-0.484f), y + (0.35773f), z - (-0.001f));
                // nissan gm.transform.localRotation = Quaternion.Euler(0, 0, -90f - (31.889f));
                gm.transform.localPosition = new Vector3(-231, y , 235);
                 gm.transform.localRotation = Quaternion.Euler(0,15.137f, 0);
                enterbut.SetActive(true);
                cl = !cl;
            }
            else
            {
                cl = !cl;
                //nissan gm.transform.localPosition = new Vector3(x, y, z);
                //nissan gm.transform.localRotation = Quaternion.Euler(0, 0, -90f);
               gm.transform.localPosition = new Vector3(x, y, z);
                 gm.transform.localRotation = Quaternion.Euler(0, 0, 0);
                enterbut.SetActive(false);
            }
        }

    }
}
