using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KevinCastejon.MoreAttributes;
namespace KevinCastejon.MoreAttributes.Examples
{
    public class TestReadOnlyOnPlayAttribute : MonoBehaviour
    {
        [ReadOnlyOnPlay]
        [SerializeField] private int _healthPoints;

        [ReadOnlyOnPlay(true)]
        [SerializeField] private int _damages;
    }
}
