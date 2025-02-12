using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class rollerball : MonoBehaviour
{
    Vector2 m;
    Rigidbody rb;
    public float fallThreshold = -10f; 

    void Start()
    {
        m = new Vector2(0, 0);
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float x_dir = m.x;
        float z_dir = m.y;
        Vector3 actual_movement = new Vector3(x_dir, 0, z_dir);
        print(actual_movement);

        rb.AddForce(actual_movement);

        if (transform.position.y < fallThreshold)
        {
            RestartGame();
        }
    }

    void OnMove(InputValue movement)
    {
        m = movement.Get<Vector2>();
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
