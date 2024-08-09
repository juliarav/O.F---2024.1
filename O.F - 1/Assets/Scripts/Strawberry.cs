using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strawberry : MonoBehaviour
{
    private SpriteRenderer sprite;
    private CircleCollider2D cc;

    public GameObject collected;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer> ();
        cc = GetComponent<CircleCollider2D> ();
    }


    void OnTriggerEnter2D (Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            sprite.enabled = false;
            cc.enabled = false;
            collected.SetActive (true);
            Destroy(gameObject, 0.25f);
        }
    }
}
