using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 100f;  // Швидкість обертання

    void Update()
    {
        // Отримуємо ввід для горизонтального і вертикального руху
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // Створюємо напрямок руху
        Vector3 dir = new Vector3(h, 0, v).normalized;

        // Рухаємо персонажа
        transform.Translate(dir * speed * Time.deltaTime);

        // Якщо є горизонтальний ввід (вліво/вправо), обертаємо персонажа
        if (h != 0)
        {
            // Обертання персонажа в залежності від вводу
            transform.Rotate(0, h * rotationSpeed * Time.deltaTime, 0);
        }
    }
}