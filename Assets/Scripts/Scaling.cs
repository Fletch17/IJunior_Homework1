using UnityEngine;

public class Scaling : MonoBehaviour
{
    [SerializeField] private float _scalingSpeed;

    private void Update()
    {
        Vector3 deltaScale = Vector3.one * _scalingSpeed * Time.deltaTime;

        transform.localScale += deltaScale;
    }
}
