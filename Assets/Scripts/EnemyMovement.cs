using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed = 3f;
    public float patrolRange = 10f;

    private Vector3 target;

    void Start()
    {
        PickNewTarget();
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target) < 1f)
        {
            PickNewTarget();
        }
    }

    void PickNewTarget()
    {
        float x = Random.Range(-patrolRange, patrolRange);
        float z = Random.Range(-patrolRange, patrolRange);

        target = new Vector3(x, transform.position.y, z);
    }
}