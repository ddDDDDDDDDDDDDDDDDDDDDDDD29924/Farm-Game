using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    float topBound = 75.0f;
    float lowerBound = -1f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            // Если объект — еда/животное, уменьшаем жизнь игрока
            if (gameObject.CompareTag("Animal"))
            {
                FindObjectOfType<Health>()?.LoseLife(1);
            }
            Destroy(gameObject);
        }
    }
}
