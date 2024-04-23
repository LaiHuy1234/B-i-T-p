using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bt4 : MonoBehaviour
{
    private Vector3 initialPosition;
    private bool movingRight = true;
    public float moveSpeed = 5.0f;
    public float moveDistance = 2.0f;

    void Start()
    {
        // Lưu vị trí ban đầu của đối tượng
        initialPosition = transform.position;
    }

    void Update()
    {
        // Tính toán điểm đích mới dựa trên hướng di chuyển hiện tại
        Vector3 targetPosition;
        if (movingRight)
        {
            targetPosition = initialPosition + Vector3.right * moveDistance;
        }
        else
        {
            targetPosition = initialPosition;
        }

        // Di chuyển đối tượng đến điểm đích
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        // Kiểm tra xem đã đạt được điểm đích chưa
        if (transform.position == targetPosition)
        {
            // Nếu đã đạt điểm đích, thay đổi hướng di chuyển
            movingRight = !movingRight;
        }
    }
}
