using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{

    public float rotationSpeed = 50f;
    AudioSource pickupSound;

    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            pickupSound = GetComponent<AudioSource>();
            pickupSound.Play();
            SceneManager.LoadScene("StartScreen");
            Destroy(gameObject);
        }
    }

}
