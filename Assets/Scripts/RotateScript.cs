using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gm;
    public Slider slidery;
    
    void Start()
    {
        
        gm.transform.rotation = Quaternion.Euler(0, slidery.value,0);
    }

    // Update is called once per frame
    void Update()
    {
        slidery.onValueChanged.AddListener(delegate { valchange(); });
        
    }
    void valchange()
    {
        gm.transform.rotation = Quaternion.Euler(0,slidery.value,0);
    }
}
