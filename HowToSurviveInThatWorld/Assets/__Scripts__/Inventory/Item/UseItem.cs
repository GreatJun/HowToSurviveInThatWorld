using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum E_UseItemType
{
    Hp,
    Hunger,
}

[CreateAssetMenu(fileName = "UseItemData", menuName = "ItemDataSO/UseItem", order = 0)]
public class UseItem : ItemDataSo
{
    public E_UseItemType UseType; //�������� ������ ä������
    public int CurrentAmont; //���� ����
    public int MaxStack; //�������� ����������
}
