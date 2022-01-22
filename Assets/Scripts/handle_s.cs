using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 

public class handle_s : MonoBehaviour
{   
   float timer;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {   
        timer+=Time.deltaTime;
        gameObject.transform.position += new Vector3(-timer, 0, 1);
    }
}
