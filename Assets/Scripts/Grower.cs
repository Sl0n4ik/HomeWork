using UnityEngine;

public class Grower : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed = 0.4f;

    private void Update()
    {
        transform.localScale += Vector3.one * _scaleSpeed * Time.deltaTime;
    }
}
