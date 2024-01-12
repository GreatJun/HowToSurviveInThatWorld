using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Base : MonoBehaviour
{
    //Dictionary�ڽĿ� �ִ� Type�� Ÿ�Կ� �ش��ϴ� ������Ʈ�� �����մϴ�.
    private Dictionary<Type, UnityEngine.Object[]> _objects = new();

    private bool _initialized = false;

    protected virtual void OnEnable()
    {
        Initialize();
    }

    //�ʱ�ȭ�� �ߴ��� ���ߴ��� üũ�ϴ� �Լ��Դϴ�.
    //���⼭ Protected�� �ƴ� public���� �ϴ� ������ �ʱ�ȭ�� �ٸ� Ŭ���������� �ϱ� �����Դϴ�.
    public virtual bool Initialize()
    {
        if (_initialized == true)
            return false;

        _initialized = true;
        return true;
    }

    private void Bind<T>(Type type) where T : UnityEngine.Object  
    {
        string[] names = Enum.GetNames(type); //type�� ������ �� �����ͼ� �����
        UnityEngine.Object[] objects = new UnityEngine.Object[names.Length]; //type�� ������ ũ�⸸ŭ �迭ũ�� ����

        for (int i = 0; i < objects.Length; i++)
        {
            objects[i] = typeof(T) == typeof(GameObject) ? this.gameObject.FindChild(names[i]) : gameObject.FindChild<T>(names[i]);
        }
        _objects.Add(typeof(T), objects);
    }

    //Bind�� �̿��ؼ� dictionary�� ������ ��� �����մϴ�.
    protected void BindObject(Type type) => Bind<GameObject>(type);
    protected void BindText(Type type) => Bind<TextMeshProUGUI>(type);
    protected void BindButton(Type type) => Bind<Button>(type);
    protected void BindImage(Type type) => Bind<Image>(type);


    private T Get<T>(int index) where T : UnityEngine.Object
    {
        if (!_objects.TryGetValue(typeof(T), out UnityEngine.Object[] objs))
            return null;
        if (index < 0 && index >= _objects.Count)
            return null;
        return objs[index] as T;
    }

    protected GameObject GetObject(int index) => Get<GameObject>(index);
    protected TextMeshProUGUI GetText(int index) => Get<TextMeshProUGUI>(index);
    protected Button GetButton(int index) => Get<Button>(index);
    protected Image GetImage(int index) => Get<Image>(index);

}
