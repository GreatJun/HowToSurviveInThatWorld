using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingInventory : MonoBehaviour
{
    [SerializeField] private ItemSlot[] _baseSlot; //Inventory�� ���� ������ �ִ� ���Ե�
    [SerializeField] private ItemDataSo[] _itemDataSo;
    public ItemSlot[] BaseSlot { get => _baseSlot; }
    private void Awake()
    {
        _baseSlot = GetComponentsInChildren<ItemSlot>(); //�ڱ� �ڽĵ��� ItemSlot�� ������ �ִ� ������Ʈ���� �����ɴϴ�.
        SlotDataSet();
    }
    public void SlotDataSet() //������ ������ �������ֱ� ���� �Լ�
    {
        int i = 0;
        for (; i < _itemDataSo.Length; i++)
            _baseSlot[i].SetInfo(_itemDataSo[i], i, -1, false);
        for (; i < _baseSlot.Length; i++)
            _baseSlot[i].SetInfo(new ItemDataSo(), i, -1, false);
    }
}
