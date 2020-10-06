using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Direction // Енам (список) направлений
{
    up,
    left,
    down,
    right
}
public class PlayerMove : MonoBehaviour
{
    public double moveSpeed;             // Скорость движения
    Direction nextDir = Direction.right; // Следующее направление движения
    Direction curDir = Direction.right;  // Текущее направление движения (для выбора стороны поворота с помощью сравнения с текущим)

    private void Update()
    {
        GetNextDirection(); // Установка последней нажатой клавиши в качестве следующего направления
    }

    private void FixedUpdate()
    {
        ChangeDirection();
    }

    public void GetNextDirection() // Установка последней нажатой клавиши в качестве следующего направления
    {
        var input = Input.inputString;
        if (!string.IsNullOrEmpty(input))
        {
            Debug.Log("Getting Fucking Input");
            switch (input)
            {
                case "w":
                    nextDir = Direction.up;
                    Debug.Log("Input");
                    break;

                case "a":
                    nextDir = Direction.left;
                    Debug.Log("Input");
                    break;

                case "s":
                    nextDir = Direction.down;
                    Debug.Log("Input");
                    break;

                case "d":
                    nextDir = Direction.right;
                    Debug.Log("Input");
                    break;

                default:
                    break;
            }
        }
    }

    public void ChangeDirection()
    {
        if ((transform.position.x % 2 == 0) && (transform.position.z % 2 == 0)) // Если в центре тайла
        {
            Debug.Log("Center");
            switch (nextDir) // Смена движения в зависимости от следующего направление движения
            {
                case Direction.up:

                    if (curDir == Direction.left || curDir == Direction.right)
                    {
                        iTween.MoveAdd(this.gameObject, iTween.Hash("amount", new Vector3(0, 0, 2), "time", moveSpeed * 0.1, "easetype", iTween.EaseType.linear));
                        curDir = Direction.up;
                    }
                    else
                    {
                        if (curDir == Direction.up)
                        {
                            iTween.MoveAdd(this.gameObject, iTween.Hash("amount", new Vector3(0, 0, 2), "time", moveSpeed * 0.1, "easetype", iTween.EaseType.linear));
                        }
                        else if (curDir == Direction.left)
                        {
                            iTween.MoveAdd(this.gameObject, iTween.Hash("amount", new Vector3(-2, 0, 0), "time", moveSpeed * 0.1, "easetype", iTween.EaseType.linear));
                        }
                        else if (curDir == Direction.down)
                        {
                            iTween.MoveAdd(this.gameObject, iTween.Hash("amount", new Vector3(0, 0, -2), "time", moveSpeed * 0.1, "easetype", iTween.EaseType.linear));
                        }
                        else if (curDir == Direction.right)
                        {
                            iTween.MoveAdd(this.gameObject, iTween.Hash("amount", new Vector3(2, 0, 0), "time", moveSpeed * 0.1, "easetype", iTween.EaseType.linear));
                        }
                    }

                    break;

                case Direction.left:

                    if (curDir == Direction.up || curDir == Direction.down)
                    {
                        iTween.MoveAdd(this.gameObject, iTween.Hash("amount", new Vector3(-2, 0, 0), "time", moveSpeed * 0.1, "easetype", iTween.EaseType.linear));
                        curDir = Direction.left;
                    }
                    else
                    {
                        if (curDir == Direction.up)
                        {
                            iTween.MoveAdd(this.gameObject, iTween.Hash("amount", new Vector3(0, 0, 2), "time", moveSpeed * 0.1, "easetype", iTween.EaseType.linear));
                        }
                        else if (curDir == Direction.left)
                        {
                            iTween.MoveAdd(this.gameObject, iTween.Hash("amount", new Vector3(-2, 0, 0), "time", moveSpeed * 0.1, "easetype", iTween.EaseType.linear));
                        }
                        else if (curDir == Direction.down)
                        {
                            iTween.MoveAdd(this.gameObject, iTween.Hash("amount", new Vector3(0, 0, -2), "time", moveSpeed * 0.1, "easetype", iTween.EaseType.linear));
                        }
                        else if (curDir == Direction.right)
                        {
                            iTween.MoveAdd(this.gameObject, iTween.Hash("amount", new Vector3(2, 0, 0), "time", moveSpeed * 0.1, "easetype", iTween.EaseType.linear));
                        }
                    }

                    break;

                case Direction.down:

                    if (curDir == Direction.left || curDir == Direction.right)
                    {
                        iTween.MoveAdd(this.gameObject, iTween.Hash("amount", new Vector3(0, 0, -2), "time", moveSpeed * 0.1, "easetype", iTween.EaseType.linear));
                        curDir = Direction.down;
                    }
                    else
                    {
                        if (curDir == Direction.up)
                        {
                            iTween.MoveAdd(this.gameObject, iTween.Hash("amount", new Vector3(0, 0, 2), "time", moveSpeed * 0.1, "easetype", iTween.EaseType.linear));
                        }
                        else if (curDir == Direction.left)
                        {
                            iTween.MoveAdd(this.gameObject, iTween.Hash("amount", new Vector3(-2, 0, 0), "time", moveSpeed * 0.1, "easetype", iTween.EaseType.linear));
                        }
                        else if (curDir == Direction.down)
                        {
                            iTween.MoveAdd(this.gameObject, iTween.Hash("amount", new Vector3(0, 0, -2), "time", moveSpeed * 0.1, "easetype", iTween.EaseType.linear));
                        }
                        else if (curDir == Direction.right)
                        {
                            iTween.MoveAdd(this.gameObject, iTween.Hash("amount", new Vector3(2, 0, 0), "time", moveSpeed * 0.1, "easetype", iTween.EaseType.linear));
                        }
                    }

                    break;

                case Direction.right:

                    if (curDir == Direction.up || curDir == Direction.down)
                    {
                        iTween.MoveAdd(this.gameObject, iTween.Hash("amount", new Vector3(2, 0, 0), "time", moveSpeed * 0.1, "easetype", iTween.EaseType.linear));
                        curDir = Direction.right;
                    }
                    else
                    {
                        if (curDir == Direction.up)
                        {
                            iTween.MoveAdd(this.gameObject, iTween.Hash("amount", new Vector3(0, 0, 2), "time", moveSpeed * 0.1, "easetype", iTween.EaseType.linear));
                        }
                        else if (curDir == Direction.left)
                        {
                            iTween.MoveAdd(this.gameObject, iTween.Hash("amount", new Vector3(-2, 0, 0), "time", moveSpeed * 0.1, "easetype", iTween.EaseType.linear));
                        }
                        else if (curDir == Direction.down)
                        {
                            iTween.MoveAdd(this.gameObject, iTween.Hash("amount", new Vector3(0, 0, -2), "time", moveSpeed * 0.1, "easetype", iTween.EaseType.linear));
                        }
                        else if (curDir == Direction.right)
                        {
                            iTween.MoveAdd(this.gameObject, iTween.Hash("amount", new Vector3(2, 0, 0), "time", moveSpeed * 0.1, "easetype", iTween.EaseType.linear));
                        }
                    }

                    break;

                default:
                    break;
            }
        }
    }

   
    
}
