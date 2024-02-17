using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    [Tooltip("The target of the gameObject this script is attachted to. ")]
    GameObject target;
    [Tooltip("The tag of the target gameObject for this script.")]
    public string targetTag;
    [Tooltip("How close the target and this gameObject have to be before this gameObject moves towards this target.")]
    public float followDistance;
    [Tooltip("How quickly this gameObject moves towards it's target.")]
    public float followSpeed;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag(targetTag);
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.SqrMagnitude(transform.position - target.transform.position) <= followDistance * followDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, followSpeed * Time.deltaTime);
        }
    }
}
