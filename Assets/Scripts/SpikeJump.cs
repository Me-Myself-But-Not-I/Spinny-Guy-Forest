using UnityEngine;

public class SpikeJump : MonoBehaviour
{
    public float crossPos;
    public GameObject self;
    private GameObject player;
    public float jumpForce;

    void Start()
    {
        player = GameObject.Find("Player");
    }
    void Update()
    {
        if (player.transform.position.x > crossPos)
        {
            self.GetComponent<Rigidbody2D>().AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
