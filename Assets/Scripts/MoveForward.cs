using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] float minSpeed = 10f;
    [SerializeField] float maxSpeed = 40f;
    [SerializeField] float foodSpeed = 20f;
    public float speed;
    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("Food"))
        {
            transform.Translate(Vector3.forward * foodSpeed * Time.deltaTime);
        }
        else if (gameObject.CompareTag("Animal"))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        
    }
}
