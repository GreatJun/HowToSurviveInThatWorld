using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Manager_UI 
{
    private static readonly int InitialPopupOrder = 10; //Pop_UP UI�� sortingOrder �⺻ ���Դϴ�.

    private List<UI_Popup> _popups = new();

    public GameObject Root //UI�� �θ� ���� �̾ȿ��� ������ �մϴ�.
    {
        get
        {
            GameObject root = GameObject.Find("@UI_Root");
            if (root == null)
                root = new GameObject { name = "@UI_Root" };
            return root;
        }
    }
    public void SetCanvas(GameObject obj) //Canvas�� �⺻ ������ �ֽ�ȭ��ŵ�ϴ�.
    { 
        Canvas canvas = obj.GetOrAddComponent<Canvas>(); //UI�� �ֻ��� ������Ʈ�� Canvas�� ������ Ex)UI_CursorSlot, UI_GameScene
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        canvas.overrideSorting = true;
        CanvasScaler scaler = obj.GetOrAddComponent<CanvasScaler>();
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        scaler.referenceResolution = new(2560, 1440);
    }

    public T ShowPopupUI<T>(string name = null) where T : UI_Popup //�� �Լ��� ���� Pop_Up�� �����ų �� �ֽ��ϴ�.
    {
        if (string.IsNullOrEmpty(name)) name = typeof(T).Name;

        GameObject obj = new GameObject(name); //new GameObject�� �ƴ� Prefab�� �־��ָ� �˴ϴ�.
        obj.transform.SetParent(Root.transform);
        T popup = obj.GetOrAddComponent<T>();
        _popups.Add(popup);

        return popup;
    }
    //public void ClosePopup(UI_Popup popup) //�� �Լ��� ���� Pop_Up�� �����ų �� �ֽ��ϴ�.
    //{
    //    if (_popups.Count == 0) return;

    //    bool isLatest = _popups[_popups.Count - 1] == popup;

    //    _popups.Remove(popup);
    //    Main.Resource.Destroy(popup.gameObject);

    //    if (isLatest) _popupOrder--;
    //    else ReorderAllPopups();
    //}
}
