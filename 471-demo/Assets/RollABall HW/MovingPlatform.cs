using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed = 3f; 
    public float distance = 10f; 

    private Vector3 startPosition;
    private int direction = 1;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        transform.position += Vector3.right * speed * direction * Time.deltaTime;

        if (Mathf.Abs(transform.position.x - startPosition.x) >= distance)
        {
            direction *= -1; 
        }
    }
}