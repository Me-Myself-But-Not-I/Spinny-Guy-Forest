using System;
using UnityEngine;
using UnityEngine.Serialization;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D selfRb;
    public bool isOnGround;
    public int energy;
    public GameObject self;
    private GameObject player;
    public Transform groundDetector;
    public float rayDistDown;
    public float rayDistSide;

    private void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
            RaycastHit2D groundCheck = Physics2D.Raycast(groundDetector.transform.position, Vector2.down, rayDistDown);
            isOnGround = groundCheck.collider != null && groundCheck.collider.CompareTag("Ground") || groundCheck.collider != null && groundCheck.collider.CompareTag("Box");
            if (player.transform.position.x > self.transform.position.x && energy > 0)
            {
                selfRb.AddForce(transform.right * 6, ForceMode2D.Force);
                energy -= 1;
                RaycastHit2D boxCheck = Physics2D.Raycast(groundDetector.transform.position, Vector2.right, rayDistSide);
                if (boxCheck.collider != null && boxCheck.collider.CompareTag("Box") && isOnGround)
                {
                    selfRb.AddForce(transform.up * 8, ForceMode2D.Impulse);
                }
            }
            else if (player.transform.position.x < self.transform.position.x && energy > 0)
            {
                selfRb.AddForce(transform.right * -6, ForceMode2D.Force);
                energy -= 1;
                RaycastHit2D boxCheck = Physics2D.Raycast(groundDetector.transform.position, Vector2.left, rayDistSide);
                if (boxCheck.collider != null && boxCheck.collider.CompareTag("Box") && isOnGround)
                {
                    selfRb.AddForce(transform.up * 8, ForceMode2D.Impulse);
                }
            }
    }
}
