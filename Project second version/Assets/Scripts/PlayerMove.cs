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
    public double rotateSpeed;           // Скорость поворота
    Direction nextDir = Direction.right; // Следующее направление движения
    Direction curDir = Direction.right;  // Текущее направление движения (для выбора стороны поворота с помощью сравнения с текущим)
    

    private void Update()
    {
        GetNextDirection(); // Установка последней нажатой клавиши в качестве следующего направления
        ChangeDirection();

        
    }

    public void GetNextDirection() // Установка последней нажатой клавиши в качестве следующего направления
    {
        var input = Input.inputString;
        if (!string.IsNullOrEmpty(input))
        {
            switch (input)
            {
                case "w":
                    nextDir = Direction.up;
                    break;

                case "a":
                    nextDir = Direction.left;
                    break;

                case "s":
                    nextDir = Direction.down;
                    break;

                case "d":
                    nextDir = Direction.right;
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
            switch (nextDir) // Выбор направления движения в зависимости от следующего направление движения
            {
                case Direction.up:

                    iTween.MoveAdd(this.gameObject, iTween.Hash("amount", new Vector3(0, 0, 2), "time", moveSpeed * 0.1, "easetype", iTween.EaseType.linear));
                    if (curDir == Direction.right)
                    {
                        iTween.RotateAdd(this.gameObject, iTween.Hash("amount", new Vector3(0, -90, 0), "time", rotateSpeed, "easetype", iTween.EaseType.linear));
                    }
                    //iTween.RotateAdd(this.gameObject, iTween.Hash("amount", new Vector3(0, 0, 2), "time", rotateSpeed, "easetype", iTween.EaseType.linear));
                    //curDir = Direction.up;

                    break;

                case Direction.left:

                    iTween.MoveAdd(this.gameObject, iTween.Hash("amount", new Vector3(-2, 0, 0), "time", moveSpeed * 0.1, "easetype", iTween.EaseType.linear));

                    break;

                case Direction.down:

                    iTween.MoveAdd(this.gameObject, iTween.Hash("amount", new Vector3(0, 0, -2), "time", moveSpeed * 0.1, "easetype", iTween.EaseType.linear));

                    break;

                case Direction.right:

                    iTween.MoveAdd(this.gameObject, iTween.Hash("amount", new Vector3(2, 0, 0), "time", moveSpeed * 0.1, "easetype", iTween.EaseType.linear));

                    break;

                default:
                    break;
            }
        }
    }
}
