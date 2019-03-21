using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Vector3[] targetPositions;

    private int currentPositionIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = targetPositions[currentPositionIndex];
        transform.position = 0.95f * transform.position + 0.05f * targetPosition;
        if (Vector3.Distance(transform.position, targetPosition)< 0.1f)
        
        {
            currentPositionIndex++;
            if (currentPositionIndex >= targetPositions.Length)
            {
                currentPositionIndex = 0;
            }
        }
    }
}
