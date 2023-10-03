//using MoreMountains.Feedbacks;
using MoreMountains.Feedbacks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    public Rigidbody rigidBody;
    public float enemySpeed;
    public Transform targetMuffin;
    public Vector3 targetLocation;
    public Vector3 newPosition;
    private bool reachedMuffin;
    public MMFeedbacks cameraShake;
    public GameObject hitFX;

    void Start()
    {
        enemySpeed = 10f;
        rigidBody.velocity = transform.right * enemySpeed;
        targetMuffin = GameObject.Find("Muffin").GetComponent<Transform>();
        targetLocation = new Vector3(targetMuffin.position.x, targetMuffin.position.y, targetMuffin.position.z);
        reachedMuffin = false;
        hitFX.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (reachedMuffin == false)
        {
            newPosition = Vector3.MoveTowards(transform.position, targetLocation, enemySpeed * Time.deltaTime);
            rigidBody.MovePosition(newPosition);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.transform.tag == "Muffin")
        { 
            reachedMuffin = true;
            
        }



        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Slash")
        {
            Debug.LogError("Camera Shake");
            cameraShake?.PlayFeedbacks();
            hitFX.SetActive(true);
        }
    }


    private void OnCollisionStay(Collision collision)
    {

        if (collision.transform.tag == "Muffin")
        {
            reachedMuffin = true;
        }

    }



    private void OnCollisionExit(Collision collision)
    {
        StartCoroutine(ReachMuffinCooldown());
    }

    IEnumerator ReachMuffinCooldown() 
    { 
        yield return new WaitForSeconds(1.5f);
        reachedMuffin = false;

    }

}
