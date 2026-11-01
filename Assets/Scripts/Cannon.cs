using System;
using System.Collections;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject Projectile;
    public GameObject self;
    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    public int cooldown;
    [SerializeField] private int cooldownTime = 200;


    private void FixedUpdate()
    {
        if (cooldown == 0)
        {
            print("fire");
            Instantiate(Projectile, self.transform.position, self.transform.rotation); 
            spriteRenderer.sprite = sprites[1];
            cooldown = cooldownTime;
        }
        else if (cooldown > 0)
        {
            print("reload");
            cooldown -= 1;
        }

        if (cooldown < 75)
        { 
            print("Sprite Reset");
            spriteRenderer.sprite = sprites[0];
        }
    }

}
