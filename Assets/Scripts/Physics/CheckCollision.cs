using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    public GameObject Fire;

    private void Awake()
    {
        Fire.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Enter " + collision.gameObject.name);
        Destroy(gameObject);
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Collision Stay " + collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Collision Exit " + collision.gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        Fire.SetActive(true);
        Debug.Log("Trigger Enter " + other.gameObject.name);
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger Stay " + other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Fire.SetActive(false);
        Debug.Log("Trigger Exit " + other.gameObject.name);
    }
}