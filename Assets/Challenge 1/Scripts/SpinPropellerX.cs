using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public Vector3 _rotation;
    
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(_rotation * Time.deltaTime); 
    }
}
