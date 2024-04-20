using UnityEngine;
using KevinCastejon.MoreAttributes;
namespace KevinCastejon.MoreAttributes.Examples
{
    public class TestHeaderPlusAttribute : MonoBehaviour
    {
        [HeaderPlus("Assets/KevinCastejon/MoreAttributes/Demos/HeaderPlus/Icons/greencrossicon.png", "Health", (int)HeaderPlusColor.green)]
        [SerializeField] private int _currentHealth;
        [SerializeField] private int _maxHealth;
        [HeaderPlus("Assets/KevinCastejon/MoreAttributes/Demos/HeaderPlus/Icons/atk.png", "Attack", (int)HeaderPlusColor.red)]
        [SerializeField] private int _damagePoints;
        [SerializeField] private int _attackSpeed;
    }
}
