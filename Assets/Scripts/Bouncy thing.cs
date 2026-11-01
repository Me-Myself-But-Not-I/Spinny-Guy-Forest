using System;
using UnityEngine;

public class Bouncything : MonoBehaviour
{
    [SerializeField] private float force = 7;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player") | col.gameObject.CompareTag("Spikes") && col.gameObject.GetComponent<Rigidbody2D>() != null)
        {
            col.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * force, ForceMode2D.Impulse);
        }
    }
}
