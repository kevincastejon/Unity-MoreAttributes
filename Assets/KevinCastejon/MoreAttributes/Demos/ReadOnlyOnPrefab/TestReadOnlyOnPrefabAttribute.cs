using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KevinCastejon.MoreAttributes;
namespace KevinCastejon.MoreAttributes.Examples
{
    public class TestReadOnlyOnPrefabAttribute : MonoBehaviour
    {
        [ReadOnlyOnPrefab]
        [SerializeField] private int _healthPoints;

        [ReadOnlyOnPrefab(true)]
        [SerializeField] private int _damages;
    }
}
