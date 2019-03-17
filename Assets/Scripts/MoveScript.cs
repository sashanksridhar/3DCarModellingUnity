using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoveScript : MonoBehaviour
{
    public GameObject gm;
    public Slider sliderz;
    // Start is called before the first frame update
    void Start()
    {
       
        gm.transform.position = new Vector3(0, 0, sliderz.value);
    }

    // Update is called once per frame
    void Update()
    {
        sliderz.onValueChanged.AddListener(delegate { valchange(); });
    }
    void valchange()
    {
        gm.transform.position = new Vector3(0, 0,sliderz.value);
    }
}
