using UnityEngine;

public class spin: MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(100, 100, 100);

    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime, Space.Self);
    }
}

