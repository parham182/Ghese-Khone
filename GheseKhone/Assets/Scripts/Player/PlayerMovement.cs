using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    public SpriteRenderer spriteRenderer;


    void Update()
    {
        float horizontal = Input.input;

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
