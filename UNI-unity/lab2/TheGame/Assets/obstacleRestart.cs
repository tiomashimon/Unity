using UnityEngine;
using UnityEngine.SceneManagement;  

public class RestartGame : MonoBehaviour
{
    // Якщо персонаж зіткнеться з об'єктом, перезапустити гру
    private void OnCollisionEnter(Collision collision)
    {
        // Перевірка, чи є об'єкт з яким відбулося зіткнення об'єктом з тегом "Obstacle" (можна змінити за потребою)
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

            Debug.Log("Гра перезапущена!");
        }
    }
}
