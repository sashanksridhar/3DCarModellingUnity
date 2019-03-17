using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenTrunk: MonoBehaviour
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
                gm.transform.localPosition = new Vector3(x+(0.054f), y + (0.869f), z + (-0.783f));
                gm.transform.localRotation = Quaternion.Euler(36f, 0.297f, -90f);

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
