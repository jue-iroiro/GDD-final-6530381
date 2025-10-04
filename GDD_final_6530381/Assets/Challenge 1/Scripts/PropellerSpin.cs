using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    public float rotationSpeed = 1000f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the propeller around the Z-axis (forward direction)
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
