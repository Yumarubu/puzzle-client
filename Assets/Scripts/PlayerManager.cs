using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    Rigidbody2D rigidbody2;
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
    }

    public enum DIRECTION_TIPE
    {
        STOP,
        RIGHT,
        LEFT,
    }

    DIRECTION_TIPE direction = DIRECTION_TIPE.STOP;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        if(x == 0)
        {
            //止まっている
            direction = DIRECTION_TIPE.STOP;
        }
        else if(x > 0)
        {
            //右に動く
            direction = DIRECTION_TIPE.RIGHT;
        }
        else if (x < 0)
        {
            //左に動く
            direction = DIRECTION_TIPE.LEFT;
        }

        // スペースが押されたらJumpさせる
        if(Input.GetKey("spece"))
        {
            // Jump()
        }
    }

    private void FixedUpdate()
    {
        switch(direction)
        {
            case DIRECTION_TIPE.STOP:
                speed = 0;
                break;

            case DIRECTION_TIPE.RIGHT:
                speed = 3;
                transform.localScale = new Vector3(1, 1, 1);
                break;

            case DIRECTION_TIPE.LEFT:
                speed = -3;
                transform.localScale = new Vector3(-1, 1, 1);
                break;
        }
        rigidbody2.velocity = new Vector2(speed, rigidbody2.velocity.y);
    }
}
