using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveModel : MonoBehaviour
{
    public GameObject gm;
    private Vector3 screenPoint;
    bool isMouseDrag;
    private GameObject target;
    private Vector3 offset,screenPosition;

    // Start is called before the first frame update
    private void Start()
    {
        print("hi");
    }
   
    void OnMouseOver()
    {
        print(name);
        print("done");

        if (Input.GetMouseButtonDown(0))
        {
            print("hi");
            
            target = gm;
            if (target != null)
            {
                print("trget");
                isMouseDrag = true;
                Debug.Log("target position :" + target.transform.position);
                //Convert world position to screen position.
                screenPosition = Camera.main.WorldToScreenPoint(target.transform.position);
                offset = target.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPosition.z));
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            isMouseDrag = false;
        }

        if (isMouseDrag)
        {
            //track mouse position.
            Vector3 currentScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPosition.z);

            //convert screen position to world position with offset changes.
            Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenSpace) + offset;

            //It will update target gameobject's current postion.
            target.transform.position = currentPosition;
        }

    }
}
