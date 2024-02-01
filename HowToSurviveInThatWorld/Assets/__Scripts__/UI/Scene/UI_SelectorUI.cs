using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class UI_SelectorUI : UI_Scene
{
    enum E_Button //���� ��ư���� �����Ѵ�.
    {
        FemaleBtn,
        maleBtn,
        SelectorBtn,
    }
    enum E_Text
    {
        PlayerNickName,
    }
    enum E_Object
    {
        InputField,
    }
    enum E_Image
    {
        MaleImage,
        FemaleImage,
    }
    [SerializeField] Animator _maleAnimation;
    [SerializeField] Animator _femaleAnimation;
    private GameObject _popUP;
    private TMP_InputField _inputField;
    public override bool Initialize()
    {
        if (!base.Initialize()) return false;
        BindButton(typeof(E_Button));
        BindText(typeof(E_Text));
        BindObject(typeof(E_Object));
        BindImage(typeof(E_Image));

        ChangeGender(0);
        GetButton((int)E_Button.FemaleBtn).onClick.AddListener(() => ChangeGender(0));
        GetButton((int)E_Button.maleBtn).onClick.AddListener(() => ChangeGender(1));
        GetButton((int)E_Button.SelectorBtn).onClick.AddListener(() => SelectorCharacter());

        _popUP = Resources.Load<GameObject>("UI_SelectorPopUp");
        _inputField = GetObject((int)E_Object.InputField).GetComponent<TMP_InputField>();
        _inputField.onValueChanged.AddListener(ValidateInput);
        return true;
    }

    private void ValidateInput(string arg0)
    {
        _inputField.text = Regex.Replace(arg0, @"[^a-zA-Z0-9��-�R]", "");
    }
    private void SelectorCharacter()
    {
        /*
         * ĳ������ �̸��� ������ ������ �ϸ� �۵��� �Լ�
         * ���� 1 (�̸��� 2���� �̸� 16���� �ʰ� �� �˾� ����)
         * ���� 3 (�̸��� �ߺ��� ��� �˾� ����)
         * ������ �����Ǿ��� �� (�������� �˾� ����)
         */
        string nickname = GetText((int)E_Text.PlayerNickName).text;
        GameObject popup = Instantiate(_popUP);
        if (nickname.Length <= 2 || nickname.Length >= 17)
        {
            popup.GetComponent<UI_SelectorPopUP>().TextChange("�α��� ����", "���� ���� 2 ~ 16���� \n ���̷� ���ּ���.");
        }
        else
        {
            popup.GetComponent<UI_SelectorPopUP>().TextChange("�г��� ���� �Ϸ�", $"�ش� \"{nickname}\" �̸����� \n �����Ͻðڽ��ϱ�?", false);
        }
    }

    private void ChangeGender(int GenderIndex) //������ �ٲٴ� �Լ�
    {
        _femaleAnimation.SetFloat("sit", GenderIndex == 1 ? 1 : 0);
        _maleAnimation.SetFloat("sit", GenderIndex == 1 ? 0 : 1);
        ColorChange(GenderIndex);
        // ������ Data�� �Ѱ������ ���� �����ڸ� ���� � ������ �ߴ��� �Ѱ��ֱ� 1 == ���� 0 == ����
    }
    private void ColorChange(int GenderIndex)
    {
        Color maleBtnColor = GetImage((int)E_Image.MaleImage).color;
        Color FemaleBtnColor = GetImage((int)E_Image.FemaleImage).color;
        maleBtnColor = (GenderIndex == 1) ? new Color(61 / 255f, 255 / 255f, 0 / 255f) : new Color(1, 1, 1);
        FemaleBtnColor = (GenderIndex != 1) ? new Color(61 / 255f, 255 / 255f, 0 / 255f) : new Color(1, 1, 1);
        if (GenderIndex == 1)
        {
            GetImage((int)E_Image.MaleImage).color = maleBtnColor;
            GetImage((int)E_Image.FemaleImage).color = FemaleBtnColor;
        }
        else
        {
            GetImage((int)E_Image.MaleImage).color = maleBtnColor;
            GetImage((int)E_Image.FemaleImage).color = FemaleBtnColor;
        }
    }
}
