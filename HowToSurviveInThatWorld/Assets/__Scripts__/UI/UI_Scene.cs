using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Scene : UI_Base
{
    public override bool Initialize()
    {
        if (!base.Initialize()) return false;

        //this.SetCanvas(); GameManager�� ��������� ����Ͽ� �ʱ�ȭ
        SetOrder();

        return true;
    }

    protected override void SetOrder() //�ſ� �⺻���� �򸮴� UI�� ������ PopUp ���� ���� 0���� �������ش�.
    {
        this.GetComponent<Canvas>().sortingOrder = 0;
    }
}
