using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour
{
    //currently not in game

    public Transform follow;

    private Transform camTransform;

    public Vector3 playerDistance;

    public float MoveSpeed = 400f;

    // Start is called before the first frame update
    void Start()
    {
        camTransform = transform;
    }

    public void Target(Transform newTransformTarget)
    {
        follow = newTransformTarget;
    }

    private void LateUpdate()
    {
        if (follow!=null)
        {
            camTransform.position = Vector3.Lerp(camTransform.position, follow.position+playerDistance, MoveSpeed*Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
