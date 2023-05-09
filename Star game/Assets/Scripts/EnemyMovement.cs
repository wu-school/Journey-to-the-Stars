using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    Vector2[] wayPoints;
    int currentTarget = 1;
    Rigidbody2D rb;

    [SerializeField]
    int speed = 5;

    [SerializeField]
    float error = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = changeDirection(currentTarget);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (reachedWaypoint(currentTarget))
        {
            currentTarget = (currentTarget + 1) % wayPoints.Length;
            rb.velocity = changeDirection(currentTarget);
        }
    }

    bool reachedWaypoint(int currentTarget)
    {
        return Vector2.Distance(transform.position, wayPoints[currentTarget]) < error;
    }

    Vector2 changeDirection(int currentTarget)
    {
        Vector2 target = wayPoints[currentTarget];
        Vector2 newVelocity = new Vector2(
            target.x - transform.position.x,
            target.y - transform.position.y
        );
        newVelocity.Normalize();
        return newVelocity * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        } else if(other.tag == "Laser"){
            Debug.Log("lasered");
            Destroy(gameObject);
        }
    }

}
