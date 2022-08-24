using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public GameObject player;
    public float rampForce;
    public AudioSource obCollision;
    bool hasTouchedRamp = false;
    public Rigidbody rb;
    public float speedIncrease;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            obCollision.Play();
        }
        if (collisionInfo.collider.tag == "Ramp")
        {
            rb.constraints = RigidbodyConstraints.None;
            hasTouchedRamp = true;
            if (hasTouchedRamp)
            {
                movement.forwardForce += rampForce;
            }
        }
        if (collisionInfo.collider.tag == "Ground")
        {
            rb.constraints = RigidbodyConstraints.FreezeRotationX;
            rb.constraints = RigidbodyConstraints.FreezeRotationY;
            rb.constraints = RigidbodyConstraints.FreezeRotationZ;
            player.transform.rotation = Quaternion.identity;
            movement.forwardForce = 1500f;
        }
       
    }
   
    void increaseSpeed()
    {
        movement.forwardForce += speedIncrease;
    }

    void OnTriggerEnter()
    {
        increaseSpeed();
        Invoke("increaseSpeed", 0.6f);
        Invoke("increaseSpeed", 1.2f);
        Invoke("increaseSpeed", 1.8f);
        Invoke("increaseSpeed", 2.2f);

    }
}
