using UnityEngine;

public class Log : MonoBehaviour
{
    private GameObject player;
    [SerializeField]  private float accelerationFactor = 1.4f;
    [SerializeField]  private float speed = 2;
    public GameObject sprite;
    private int cooldown;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        if (player.transform.position.x > transform.position.x)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(transform.right * speed, ForceMode2D.Force);
        }
        else if (player.transform.position.x < transform.position.x)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(transform.right * -speed, ForceMode2D.Force);
        }

        if (player.transform.position.x <= transform.position.x + 0.2f && player.transform.position.x >= transform.position.x - 0.5f && cooldown == 0)
        {
            speed *= accelerationFactor;
            cooldown = 50;
        }
    }

    void FixedUpdate()
    {
        if (player.transform.position.x > transform.position.x)
        {
            sprite.transform.rotation = Quaternion.Euler(0, 0, sprite.transform.rotation.eulerAngles.z - 1f * speed);
        }
        if (player.transform.position.x < transform.position.x)
        {
            sprite.transform.rotation = Quaternion.Euler(0, 0, sprite.transform.rotation.eulerAngles.z + 1f * speed);
        }
        
        if (cooldown > 0)
        {
            cooldown -= 1;
        }
    }
}
