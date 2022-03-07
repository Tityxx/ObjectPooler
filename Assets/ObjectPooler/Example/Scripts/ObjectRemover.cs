using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ������ �������� ������� � ���
/// </summary>
public class ExampleObjectRemover : MonoBehaviour
{
    [SerializeField]
    private float delay = 1f;

    private void OnEnable()
    {
        StartCoroutine(RemoveObjectWithDelay(delay));
    }

    private IEnumerator RemoveObjectWithDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        if (TryGetComponent(out PoolInformation info))
        {
            info.ObjectPool.FreeObject(gameObject);
        }
    }
}
