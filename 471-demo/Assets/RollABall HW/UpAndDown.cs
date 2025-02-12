using UnityEngine;

public class UpAndDown : MonoBehaviour
{
    public float speed = 3f; 
    public float distance = 5f; 

    private Vector3 startPosition;
    private int direction = 1;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        transform.position += Vector3.up * speed * direction * Time.deltaTime;

        if (Mathf.Abs(transform.position.y - startPosition.y) >= distance)
        {
            direction *= -1; 
        }
    }
}
