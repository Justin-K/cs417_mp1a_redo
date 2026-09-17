using UnityEngine;

public class Example : MonoBehaviour
{
    public GameObject target;

    void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.up, 23 * Time.deltaTime);
    }
}


