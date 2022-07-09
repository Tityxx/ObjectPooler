using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ToolsAndMechanics.ObjectPool
{
    /// <summary>
    /// Пример спавна объектов
    /// </summary>
    public class ExampleObjectsSpawner : MonoBehaviour
    {
        [SerializeField]
        private float spawnDelay = 1;

        [SerializeField]
        private PoolableObjectData[] datas;
        [SerializeField]
        private Transform[] positions;

        private ObjectPoolController poolController;

        private IEnumerator Start()
        {
            poolController = FindObjectOfType<ObjectPoolController>();

            while (true)
            {
                for (int i = 0; i < datas.Length; i++)
                {
                    poolController.GetObject(datas[i], positions[i].position);
                }
                yield return new WaitForSeconds(spawnDelay);
            }
        }
    }
}