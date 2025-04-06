using UnityEngine;

public class AstroidMotion : MonoBehaviour
{
    public float a = 5f;  // Радіус астроїди
    public float speed = 1f;  // Швидкість руху
    private float t = 0f;  // Час

    void Update()
    {
        t += Time.deltaTime * speed;  // Збільшуємо час
        float x = a * Mathf.Pow(Mathf.Cos(t), 3);  // Рух по X
        float y = a * Mathf.Pow(Mathf.Sin(t), 3);  // Рух по Y
        transform.position = new Vector3(x, y, 0);  // Рухаємо циліндр
    }
}
