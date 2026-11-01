using System;
using System.Collections;
using Unity.Mathematics;
using UnityEngine;
using Random = System.Random;

public class RandCannon : MonoBehaviour
{
    public GameObject[] Projectile;
    private bool _spike;
    public int selection;
    public GameObject self;
    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    public int cooldown;
    [SerializeField] private int cooldownTime = 200;


    private void FixedUpdate()
    {
        if (cooldown == 0)
        {
            if (_spike)
            {
                selection = 0;
            }
            else
            {
                selection = 1;
            }
            Instantiate(Projectile[selection], self.transform.position, self.transform.rotation); 
            spriteRenderer.sprite = sprites[1];
            cooldown = cooldownTime;
            _spike = !_spike;
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