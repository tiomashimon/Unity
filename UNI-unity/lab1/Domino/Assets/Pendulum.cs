using UnityEngine;

public class Pendulum : MonoBehaviour
{
    public float angle = 30f;  // Кут коливання
    public float speed = 2f;   // Швидкість коливань

    void Update()
    {
        // Рахуємо зміну кута
        float z = angle * Mathf.Sin(Time.time * speed);
        // Обертаємо по осі Z
        transform.localRotation = Quaternion.Euler(0, 0, z);
    }
}
