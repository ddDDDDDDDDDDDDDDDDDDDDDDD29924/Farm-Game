using UnityEngine;

public class BotController : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] GameObject FoodProjectile;
    [SerializeField] float xRange = 10f;
    [SerializeField] float minTime = 0.2f;
    [SerializeField] float maxTime = 3f;
    private float a = 0f;
    private float b = 2f;
    private float StartDirection;
    public float rTime;
    public float XRange => xRange;
    private bool DirectionDeterminer;

    void Start()
    {
        rTime = Random.Range(minTime, maxTime);
        StartDirection = Random.Range(a, b);
    }

    void moveLeft()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        DirectionDeterminer = false;
    }

    void moveRight()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        DirectionDeterminer = true;
    }

    

    void Update()
    {
    }
}
