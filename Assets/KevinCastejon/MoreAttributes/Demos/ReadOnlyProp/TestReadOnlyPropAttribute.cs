using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KevinCastejon.MoreAttributes;
namespace KevinCastejon.MoreAttributes.Examples
{
    public class TestReadOnlyPropAttribute : MonoBehaviour
    {
        [ReadOnlyProp]
        [SerializeField] private int _healthPoints;
        [ReadOnlyProp]
        [SerializeField] private int _damages;
    }
}
