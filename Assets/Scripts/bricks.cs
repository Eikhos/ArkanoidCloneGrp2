using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class bricks : MonoBehaviour
{
    public int Hitpoints = 1;
    public static event Action<bricks> BrickDestruction;
    private SpriteRenderer sr;

    private void Start()
    {
        this.sr = this.GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        balle balle = collision.gameObject.GetComponent<balle>();
        ApplyCollision(balle);
    }

    private void ApplyCollision(balle balle)
    {
        this.Hitpoints--;

        if (this.Hitpoints <= 0)
        {
            BrickDestruction?.Invoke(this);

            Destroy(this.gameObject);
        }
        else
        {
            this.sr.sprite = BricksManager.Instance.Sprites[this.Hitpoints - 1];
        }

    }

}
