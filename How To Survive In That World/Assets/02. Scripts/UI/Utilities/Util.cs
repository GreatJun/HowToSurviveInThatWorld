using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Util
{
    //���׸����� ���� �޾Ƽ� ���� ���ϴ� ���۳�Ʈ�� ã�� �� �����Ѵ�.
    public static T FindChild<T>(GameObject go, string name = null) where T : UnityEngine.Object
    {   
        if (go == null)
            return null;
        //������Ʈ�� ��Ȱ��ȭ�� �ڽĵ���� �˻��Ͽ� T�� �ش��ϴ� ������Ʈ�� ������
        T[] components = go.GetComponentsInChildren<T>(true);
        if (string.IsNullOrEmpty(name)) //�̸��� null���̸� �׳� ù��°�� ���� ��������
            return components[0];
        else
            return components.Where(x => x.name == name).FirstOrDefault(); //components�� ����ִ� �̸��� name ������ ���� �������ų� ������ null
    }

    //GameObject�� ���۳�Ʈ�� ã�� �� ���� ������ Transform���� ��ȯ �� �˻��Ͽ� �����Ѵ�.
    public static GameObject FindChild(GameObject go, string name = null) 
    {
        Transform transform = FindChild<Transform>(go, name);
        if (transform == null) 
            return null;
        return transform.gameObject;
    }
}
