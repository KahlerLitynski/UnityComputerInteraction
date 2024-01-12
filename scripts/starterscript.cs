using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;

public class starterscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Kyler");
        
        Vector3 objectPosition = transform.position;

        // Print the position to the console
        Debug.Log("Object Position: " + objectPosition);
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
