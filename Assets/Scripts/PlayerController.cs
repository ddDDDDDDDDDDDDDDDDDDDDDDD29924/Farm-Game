using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float horizontalInput;
    [SerializeField] float speed = 10f;
    [SerializeField] float xRange = 10f;
    [SerializeField] GameObject projectilePrefab;

    // публичное свойство для доступа к лимиту из других скриптов
    public float XRange => xRange;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        // ровное ограничение позиции игрока по оси X
        float clampedX = Mathf.Clamp(transform.position.x, -xRange, xRange);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
