using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    public float moveDistance = 5f; // Максимальна відстань руху вліво-вправо
    public float moveSpeed = 2f;    // Швидкість руху

    private Vector3 startPos;

    void Start()
    {
        // Запам'ятовуємо початкову позицію перешкоди
        startPos = transform.position;
    }

    void Update()
    {
        // Створюємо плавний рух вліво-вправо по осі X
        float offset = Mathf.Sin(Time.time * moveSpeed) * moveDistance;
        transform.position = startPos + new Vector3(0, 0, offset); // Рухаємо лише по осі X
    }
}
