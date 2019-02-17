using UnityEngine;
using UnityEngine.UI;
public class Enemy : MonoBehaviour
{
    public float speed = 10f;
    public float startHealth = 100;
    private float health;
    private Transform target;
    private int waypointIndex = 0; 


    [Header("Unity Stuff")]
    public Image healthBar;
    void Start()
    {
        health = startHealth;
        target = Waypoints.points[0]; 
    }
    public void TakeDamage(float amount)
    {
        health -=amount;
        healthBar.fillAmount = health/startHealth;
        if(health <=0)
        {
            Die();
        }
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World); 

        if (Vector3.Distance(transform.position, target.position) <= 0.2f) // If we've reached waypoint
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {

        if (waypointIndex >= Waypoints.points.Length - 1) // if out of bounds, destroy enemy and return
        {
            Destroy(gameObject);
            return;
        }

        waypointIndex++;
        target = Waypoints.points[waypointIndex];
    }
    void Die()
    {
        
        Destroy(gameObject);
    }
}
