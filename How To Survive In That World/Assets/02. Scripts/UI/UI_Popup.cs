using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Popup : UI_Base
{
    protected Canvas _canvas;

    public override bool Initialize()
    {
        if (!base.Initialize()) return false;

        //this.SetCanvas();//ĵ���� �ʱ����
        _canvas = this.GetComponent<Canvas>();

        return true;
    }
    protected override void SetOrder() => _canvas.sortingOrder = 10;

    //Close�� �۵� �� ���� �߰��ؾ���
    //Pop_Upâ�� ������� ���� ���� �ʿ�
}
