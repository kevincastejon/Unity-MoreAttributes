using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace KevinCastejon.MoreAttributes.Examples
{
    public class TestLayerAttribute : MonoBehaviour
    {
        [SerializeField][Layer] private int _layer;
    }
}
