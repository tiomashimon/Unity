using UnityEngine;
using UnityEngine.SceneManagement;  

public class FinishLine : MonoBehaviour
{
    // Це подія, коли гравець торкається фінішної точки
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            Debug.Log("Вітаємо, ви досягли фінішу!");

            
        }
    }
}
