using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite_Mover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            //only works when shift is held down
        }
        else
        {
            //only when shift is not held down
            if (Input.GetKey(KeyCode.UpArrow))
            {
                //tf.position = tf.position + Vector3.up * time.deltaTime * speed;
            }
        }
        //if player is holding down shift or isn't holding down shift
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //tf.position = Vector3(0, 0, 0);
        }
    }

}
