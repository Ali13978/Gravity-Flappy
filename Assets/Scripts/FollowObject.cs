using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    [SerializeField] Transform followObject;
    [SerializeField] Vector2 offset;
    [SerializeField] bool VerticalFollow;
    [SerializeField] bool HorizontalFollow = true;

    private Vector3 defPos;

    private void Awake()
    {
        defPos = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 targetPos = (Vector2)followObject.position - offset;

        if (HorizontalFollow && !VerticalFollow)
            targetPos = new Vector2(targetPos.x, defPos.y);
        else if (!HorizontalFollow && VerticalFollow)
            targetPos = new Vector2(defPos.x, targetPos.y);

        transform.position = new Vector3(targetPos.x, targetPos.y, defPos.z);
    }
}
