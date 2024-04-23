using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bt3 : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 initialPosition;
    private bool movingRight = true;
    public float moveSpeed = 5.0f;

    void Start()
    {
        // Lấy Rigidbody của đối tượng
        rb = GetComponent<Rigidbody>();

        // Lưu vị trí ban đầu của đối tượng
        initialPosition = transform.position;
    }

    void FixedUpdate()
    {
        // Tạo vector vận tốc mới
        Vector3 velocity = Vector3.zero;

        // Kiểm tra hướng di chuyển hiện tại
        if (movingRight)
        {
            // Di chuyển sang phải
            velocity.x = moveSpeed;

            // Kiểm tra nếu đã đi đủ xa
            if (transform.position.x >= initialPosition.x + 2.0f)
            {
                // Chuyển hướng di chuyển sang trái
                movingRight = false;
            }
        }
        else
        {
            // Di chuyển sang trái
            velocity.x = -moveSpeed;

            // Kiểm tra nếu đã quay lại vị trí ban đầu
            if (transform.position.x <= initialPosition.x)
            {
                // Chuyển hướng di chuyển sang phải
                movingRight = true;
            }
        }

        // Gán vận tốc cho Rigidbody
        rb.velocity = velocity;
    }
}
