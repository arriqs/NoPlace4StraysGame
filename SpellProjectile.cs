using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellProjectile : MonoBehaviour
{
    [SerializeField] private Transform vfxHitSuccess;
    [SerializeField] private Transform vfxHitMiss;
    private Rigidbody spellProjectileRigidbody;

    private void Awake()
    {
        spellProjectileRigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        float speed = 30f;
        spellProjectileRigidbody.velocity = transform.forward * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<SpellTarget>() != null)
        {
            // Hit target
            Instantiate(vfxHitSuccess, transform.position, Quaternion.identity);
        }
        else
        {
            // Hit something else
            Instantiate(vfxHitMiss, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}
