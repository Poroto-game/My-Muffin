using MoreMountains.Feedbacks;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Slash : MonoBehaviour
{
    
    
    void Start()
    {
        
    }

    
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
                
        if(other.transform.tag == "Enemy")
        {
            
            Destroy(other.gameObject, 0.2f);            
        }
    }

    

}
