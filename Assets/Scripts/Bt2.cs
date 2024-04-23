using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bt2 : MonoBehaviour
{
    private Vector3 initialPosition;
    private bool movingRight = true;
    public float speed = 1.0f;

    void Start()
    {
        // Lưu vị trí ban đầu của đối tượng
        initialPosition = transform.position;
    }

    void Update()
    {
        // Kiểm tra nếu đối tượng đang di chuyển sang phải
        if (movingRight)
        {
            // Di chuyển đối tượng sang phải theo trục x
            transform.Translate(Vector3.right * Time.deltaTime * speed);

            // Kiểm tra xem đối tượng đã đi đủ xa chưa
            if (transform.position.x >= initialPosition.x + 2.0f)
            {
                // Nếu đã đi đủ xa, chuyển hướng di chuyển sang trái
                movingRight = false;
            }
        }
        else
        {
            // Di chuyển đối tượng sang trái theo trục x
            transform.Translate(Vector3.left * Time.deltaTime * speed);

            // Kiểm tra xem đối tượng đã trở lại vị trí ban đầu chưa
            if (transform.position.x <= initialPosition.x)
            {
                // Nếu đã trở lại vị trí ban đầu, chuyển hướng di chuyển sang phải
                movingRight = true;
            }
        }
    }
}
