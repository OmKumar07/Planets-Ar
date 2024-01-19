using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 RotationVect;
    private void Update()
    {
        gameObject.transform.Rotate(RotationVect * Time.deltaTime);
    }
}
