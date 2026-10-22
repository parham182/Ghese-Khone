using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    public SpriteRenderer spriteRenderer;

    [HideInInspector]
    public bool canMove = true;

    public static PlayerMovement instance;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        if (!canMove) return;

        float horizontal = InputHandeler.input;

        transform.position += Vector3.right
            * horizontal * speed * Time.deltaTime;

        if (horizontal < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (horizontal > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

}
