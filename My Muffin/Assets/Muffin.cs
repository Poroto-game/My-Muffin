//using MoreMountains.Feedbacks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muffin : MonoBehaviour
{
    //public MMFeedbacks muffinFlicker;
    //public MMFeedbacks muffinWiggle;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.transform.tag == "Enemy")
            //muffinFlicker?.PlayFeedbacks();
            //muffinWiggle?.PlayFeedbacks();
    }
    private void OnCollisionStay(Collision collision)
    {
        //if(collision.transform.tag == "Enemy")
            //muffinFlicker?.PlayFeedbacks();
    }

}
