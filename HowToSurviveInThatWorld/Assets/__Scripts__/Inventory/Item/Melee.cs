using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum E_WeaponType
{
    Hand,   //��
    Axe,    //����
    Pick,   //���
    Sword,  //��
    Gun,    //��
}
public class MeleeData : WeaponData //���� ����
{
    public E_WeaponType WeaponType;
}
