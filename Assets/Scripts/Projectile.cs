using Unity.Mathematics;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject self;
    public GameObject player;
    public float launchForce;
    [SerializeField]public float speed;
    public Rigidbody2D rb;
    
    void Start()
    {
        self.GetComponent<Rigidbody2D>().AddForce(transform.up * launchForce, ForceMode2D.Impulse);
        player = GameObject.Find("Player");
    }
    void Update()
    {
        if (enabled)
        {
            travel();
        }
        self.transform.position = new Vector3(self.transform.position.x, self.transform.position.y, 0);
        Quaternion angleToPlayer = Quaternion.LookRotation(player.transform.position - transform.position, transform.TransformDirection(Vector3.up));
        transform.rotation = new Quaternion( 0 , 0 , angleToPlayer.z, angleToPlayer.w);
    }

    private void travel()
    {
        if (player.transform.position.x > transform.position.x)
        {
           transform.Translate(transform.right.x * speed * Time.deltaTime, 0, 0, Space.Self); 
        }
        else if (player.transform.position.x < transform.position.x)
        {
            transform.Translate(-transform.right.x * speed * Time.deltaTime, 0, 0, Space.Self);
        }
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.CompareTag("Player"))
        {
            Destroy(self);
        }
    }
}
