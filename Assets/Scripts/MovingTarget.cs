using UnityEngine;

public class MovingTarget : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    private bool movingToB = true;
    private UnityEngine.AI.NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();

        agent.SetDestination(pointB.position);
    }

    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            movingToB = !movingToB; 
            agent.SetDestination(movingToB ? pointB.position : pointA.position);
        }
    }
}
