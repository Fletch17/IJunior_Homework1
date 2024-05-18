using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;     

    private void Update()
    {
        var _movementDirection = Vector3.forward.normalized * _movementSpeed;
        
        transform.Translate(_movementDirection, Space.Self);
    }
}
