using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Slash : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.LogError(other);
        
        if(other.transform.tag == "Enemy")
        {
            Destroy(other.gameObject, 0.1f);
            
        }
    }


}
