using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] Transform interior;
    public void rotateTile()
    {
        //interior = this.transform.Find("Rotate");
        interior.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
    }
}
