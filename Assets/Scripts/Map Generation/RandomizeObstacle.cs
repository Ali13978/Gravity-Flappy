using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeObstacle : MonoBehaviour
{
    [SerializeField] Transform upperPart;
    [SerializeField] Transform lowerPart;
    [SerializeField] float minGap = 2f;
    [SerializeField] float maxGap = 5f;
    [SerializeField] float minHieght;
    [SerializeField] float maxHieght;

    private void Start()
    {
        float gap = Random.Range(minGap, maxGap);
        float hieght = Random.Range(minHieght, maxHieght);
        
        if (hieght > 0)
        {
            upperPart.position = new Vector2(upperPart.position.x, hieght);
            lowerPart.position = new Vector2(lowerPart.position.x, hieght - gap);
        }

        else
        {
            lowerPart.position = new Vector2(lowerPart.position.x, hieght);
            upperPart.position = new Vector2(upperPart.position.x, hieght + gap);
        }

    }
}