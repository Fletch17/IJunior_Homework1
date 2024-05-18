using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;     

    private void Update()
    {
        var movementDirection = Vector3.forward.normalized * _movementSpeed;
        
        transform.Translate(movementDirection, Space.Self);
    }
}
