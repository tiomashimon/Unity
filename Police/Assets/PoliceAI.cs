using UnityEngine;
using UnityEngine.AI;

public class PoliceAI : MonoBehaviour
{
    public Transform player;       // Посилання на гравця
    private NavMeshAgent agent;    // Агент для навігації

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();  // Отримуємо компонент NavMeshAgent
    }

    void Update()
    {
        // Якщо гравець існує, встановлюємо напрямок для поліцейського
        if (player != null)
        {
            agent.SetDestination(player.position);
        }
    }

    // Обробка події зіткнення
    void OnTriggerEnter(Collider other)
    {
        // Перевірка, чи це гравець
        if (other.CompareTag("Player"))
        {
            // Кінець гри: виведення в консоль
            Debug.Log("Кінець гри! Поліцейський затримав злочинця!");

            // Тут можна зупинити гру або додати іншу логіку:
            // Наприклад, зупинка часу:
            Time.timeScale = 0;  // Зупиняє всі рухи та анімації
        }
    }
}
