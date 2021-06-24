//Attach this script to a GameObject.
//Attach a Rigidbody to the GameObject by clicking the GameObject in the Hierarchy and
//clicking the Add Component button. Search for Rigidbody in the field and select
//it when shown.

using UnityEngine;



public class StopRigidBody : MonoBehaviour
{
    Rigidbody m_Rigidbody;



    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        //This locks the RigidBody so that it does not move or rotate in the Z axis.
        m_Rigidbody.constraints = RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationX;
    }






}