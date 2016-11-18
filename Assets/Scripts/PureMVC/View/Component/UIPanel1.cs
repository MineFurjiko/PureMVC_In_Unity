using UnityEngine;
using UnityEngine.UI;
using PureMVC.Patterns;
using System;
using System.Collections;

public class UIPanel1 : PureViewWithMonoBehaviour {
	public Text text;
	public Button button;
	public InputField userNameInputField;
	public InputField PasswordInputField;

	public Action TryLoginEvent;

	public override Mediator Mediator {
		get {
			if (mediator==null) {
				mediator = new UIPanel1Mediator(this);
			}
			return mediator as Mediator;
		}
	}

	public LoginVO GetInputLoginVO() {
		var loginVO = new LoginVO();
		loginVO.UserName = userNameInputField.text;
		loginVO.Password = PasswordInputField.text;
		return loginVO;
	}

	private bool CheckInput(){
		if (string.IsNullOrEmpty(userNameInputField.text)&&string.IsNullOrEmpty(PasswordInputField.text)) 
			return false;
		return true;
	}

	void Start() {
		button.onClick.AddListener(OnClick);
	}

	private void OnClick() {
		if (TryLoginEvent!=null) {
			if (CheckInput()) 
				TryLoginEvent.Invoke();
			else
				text.text = "请检查输入!";
			
		}
	}

	public void LoginSucceed() {
		text.text = "登录成功！";
	}

	public void LoginFail() {
		text.text = "登录失败！";
	}

}
