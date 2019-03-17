using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SelectView : MonoBehaviour
{
    
    public GameObject gm;
    public GameObject gm1;
    // Start is called before the first frame update
    void Start()
    {
        gm.SetActive(true);

        
        gm1.SetActive(false);
        
    }

    // Update is called once per frame
    public void changeView()
    {
        gm.SetActive(!gm.activeSelf);
        gm1.SetActive(!gm1.activeSelf);
    }
}
