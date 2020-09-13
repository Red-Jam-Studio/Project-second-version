using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Direction
{
    up,
    left,
    down,
    right
}
public class PlayerMove : MonoBehaviour
{
    public int speed;
    Direction dir = Direction.right;
    

    private void Update()
    {
        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            dir = Direction.up;
        }
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            dir = Direction.left;
        }
        if (Input.GetKey("s") || Input.GetKey("down"))
        {
            dir = Direction.down;
        }
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            dir = Direction.right;
        }
    }

    private void FixedUpdate()
    {
        switch (dir)
        {
            case Direction.up:
                iTween.MoveAdd(this.gameObject, iTween.Hash("amount", new Vector3(0, 0, 2), "time", speed, "easetype", iTween.EaseType.linear));
                break;
            case Direction.left:
                iTween.MoveAdd(this.gameObject, iTween.Hash("amount", new Vector3(-2, 0, 0), "time", speed, "easetype", iTween.EaseType.linear));
                break;
            case Direction.down:
                iTween.MoveAdd(this.gameObject, iTween.Hash("amount", new Vector3(0, 0, -2), "time", speed, "easetype", iTween.EaseType.linear));
                break;
            case Direction.right:
                iTween.MoveAdd(this.gameObject, iTween.Hash("amount", new Vector3(2, 0, 0), "time", speed, "easetype", iTween.EaseType.linear));
                break;
            default:
                break;
        }

        //iTween.MoveAdd(this.gameObject, iTween.Hash("amount", new Vector3(0,0,2), "time", speed, "easetype", iTween.EaseType.linear));
    }
}
