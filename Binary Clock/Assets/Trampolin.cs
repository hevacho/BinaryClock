using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampolin : MonoBehaviour
{
    public Vector3 JumpForce;
    public SPAWNSPHERES spawnSpehers;
    private void OnCollisionEnter(Collision collision)
    {
        spawnSpehers.KeepSpawn = false;
        collision.gameObject.GetComponent<Rigidbody>().AddForce(JumpForce, ForceMode.Impulse);

    }
}
