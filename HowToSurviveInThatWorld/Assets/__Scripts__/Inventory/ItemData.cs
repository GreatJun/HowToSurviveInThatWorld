using System;
using UnityEngine;

public class ItemData : MonoBehaviour
{
    Item item;

    private void Start()
    {
        item = Managers.Data.LoadData<Item>("WeaponData");
        Debug.Log(item.KeyNumber);
    }
}

[Serializable]
public class Item
{
    public int KeyNumber; // ������ ���� ��ȣ
    public string Name; //������ �̸� 
    public string Description; // ������ ����
    public int ItmeBaseType; // ������ Ÿ�� = �Һ�, ����, ��Ÿ
}

