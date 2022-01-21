using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 

public class handle_s : MonoBehaviour
{   
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(-1, 0, 1);
    }
}
