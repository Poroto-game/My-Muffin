using MoreMountains.Feedbacks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject slash;
    public MMFeedbacks slashSound;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            slash.SetActive(true);
            slashSound?.PlayFeedbacks();
            StartCoroutine(ResetSlash());
            
        }


    }

    IEnumerator ResetSlash()
    {
        yield return new WaitForSeconds(0.5f);
        slash.SetActive(false);
    }

}
