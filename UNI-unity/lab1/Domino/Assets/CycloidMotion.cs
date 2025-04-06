using UnityEngine;

public class CycloidMotion : MonoBehaviour
{
    public float radius = 1f;  // Радіус колеса
    public float speed = 1f;   // Швидкість руху
    private float t = 0f;      // Час для обчислень

    void Update()
    {
        // Обчислення координат циклоїди
        float x = radius * (t - Mathf.Sin(t));  // Рух по осі X
        float y = radius * (1 - Mathf.Cos(t));  // Рух по осі Y

        // Оновлюємо позицію кульки
        transform.position = new Vector3(x, y, transform.position.z);

        // Збільшуємо t для руху вперед
        t += Time.deltaTime * speed;

    
    }
}
