using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ramp : MonoBehaviour
{
    public float steepness;
    public float elevation;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CityController p_cityController = collision.attachedRigidbody.gameObject.GetComponent<CityController>();
        if (p_cityController != null) {
            p_cityController.speed *= 1.1f-steepness;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        CityController p_cityController = collision.attachedRigidbody.gameObject.GetComponent<CityController>();
        if (p_cityController != null)
        {
            p_cityController.m_rigidbody2D.AddForce(new Vector2(0, elevation*p_cityController.direction.normalized.x));
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        CityController p_cityController = collision.attachedRigidbody.gameObject.GetComponent<CityController>();
        if (p_cityController != null)
        {
            p_cityController.speed /= 1.1f - steepness;
        }
    }
}
