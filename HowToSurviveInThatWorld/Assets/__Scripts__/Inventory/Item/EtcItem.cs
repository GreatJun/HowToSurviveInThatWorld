using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EtcItem : ItemDataSo
{
    public int MaxStack; //�������� ����������
    public EtcItem(EtcItem etcItem) : base(etcItem)
    {
        MaxStack = etcItem.MaxStack;
    }
}
