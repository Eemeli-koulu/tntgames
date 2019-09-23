using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowController : MonoBehaviour
{
    public void LookAtTarget()
    {
        Vector3 _lookDirection = objectoToFollow.position - transform.position;
        Quaternion _rot = Quaternion.LookRotation(_lookDirection, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, _rot, lookSpeed * Time.deltaTime);
    }

    public void MoveToTarget()
    {
        Vector3 _targetPos = objectoToFollow.position + objectoToFollow.forward * offset.z + objectoToFollow.right * offset.x + objectoToFollow.up * offset.y;
        transform.position = Vector3.Lerp(transform.position, _targetPos, followSpeed * Time.deltaTime);


    }

    public void FixedUpdate()
    {
        LookAtTarget();
        MoveToTarget();
    }

    public Transform objectoToFollow;
    public Vector3 offset;
    public float followSpeed = 10;
    public float lookSpeed = 10;
}
