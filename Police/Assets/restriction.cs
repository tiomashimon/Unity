using UnityEngine;

public class ZoneRestriction : MonoBehaviour
{
    // Перевіряємо, чи персонаж знаходиться на дозволеній зоні
    private bool isOnSidewalkOrCrosswalk = false;

    // Метод, який викликається, коли персонаж заходить в зону
    void OnTriggerEnter(Collider other)
    {
        // Якщо персонаж заходить на тротуар або пішохідний перехід
        if (other.CompareTag("Sidewalk") || other.CompareTag("Crosswalk"))
        {
            isOnSidewalkOrCrosswalk = true;  // Дозволяємо бути в цій зоні
        }
    }

    // Метод, який викликається, коли персонаж виходить з зони
    void OnTriggerExit(Collider other)
    {
        // Якщо персонаж виходить з тротуару або пішохідного переходу
        if (other.CompareTag("Sidewalk") || other.CompareTag("Crosswalk"))
        {
            isOnSidewalkOrCrosswalk = false;  // Забороняємо бути в цій зоні
        }
    }

    // Метод для перевірки, чи можна рухатися
    public bool CanMove()
    {
        return isOnSidewalkOrCrosswalk;  // Повертаємо дозволення руху
    }
}
