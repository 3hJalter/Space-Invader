using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayerController : MonoBehaviour
{
    public float speed = 6.0f;
    // Start is called before the first frame update
    void Start()
    {
        GameObject gameObject = GameObject.FindWithTag("Player");
        // transform.poistion -> position of the current game object that holds the script
        // gameObject.transform.position -> position of the game object with tag "Player" before

        if (gameObject != null)
        {
            Vector2 v2 = (gameObject.transform.position - transform.position).normalized;
            GetComponent<Rigidbody2D>().velocity = v2 * speed;
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.down * 2.0f *speed;
        }
    }

}
