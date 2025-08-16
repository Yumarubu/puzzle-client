using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
            //Ž~‚Ü‚Á‚Ä‚¢‚é
            direction = DIRECTION_TIPE.STOP;
        }
        else if(x > 0)
        {
            //‰E‚É“®‚­
            direction = DIRECTION_TIPE.RIGHT;
        }
        else if (x < 0)
        {
            //¶‚É“®‚­
            direction = DIRECTION_TIPE.LEFT;

        }
    }

    private void FixedUpdate()
    {
        switch(direction)
        {
            case DIRECTION_TIPE.STOP:
                break;
        }
    }
}
