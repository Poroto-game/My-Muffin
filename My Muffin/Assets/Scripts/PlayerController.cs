using MoreMountains.Feedbacks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject slash;
    //public MMFeedbacks slashSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            slash.SetActive(true);
            //slashSound?.PlayFeedbacks();
            StartCoroutine(ResetSlash());
            
        }


    }

    IEnumerator ResetSlash()
    {
        yield return new WaitForSeconds(0.5f);
        slash.SetActive(false);
    }

}
