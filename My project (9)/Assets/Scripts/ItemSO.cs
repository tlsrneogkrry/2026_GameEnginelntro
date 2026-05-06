using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Game/Creats Item")]
public class ItemSO : ScriptableObject
{
    [Header("Score Value")]
    public int point = 10;
}
