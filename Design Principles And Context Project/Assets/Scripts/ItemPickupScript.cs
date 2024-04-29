using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickupScript : MonoBehaviour
{

    public float rotationSpeed = 50f;
    public ItemCountScript itemCountScript;
    AudioSource pickupSound;

    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

    private void playSound()
    {
        pickupSound = GetComponent<AudioSource>();
        pickupSound.Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playSound();
            itemCountScript.IncreaseCount();
            Destroy(gameObject);
        }
    }

}
