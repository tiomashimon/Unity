using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Персонаж
    public float mouseSensitivity = 100f;

    float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Ховає курсор
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

        // Повертаємо навколо осі Y
        transform.Rotate(Vector3.up * mouseX);
    }
}
