using System;
using UnityEngine;

public class DoorButton : MonoBehaviour
{
    [SerializeField] private GameObject door;
    [SerializeField] private SpriteRenderer sprite;
    public Sprite[]  sprites;

    void start()
    {
        sprite.sprite = sprites[0];
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(door);
            sprite.sprite = sprites[1];
            Destroy(gameObject);
        }
    }
}
