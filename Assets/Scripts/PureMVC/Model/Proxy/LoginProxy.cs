using PureMVC.Patterns;
using System;
using System.Collections.Generic;
using UnityEngine;

class LoginProxy : Proxy {
	public new static string NAME = "LoginProxy";

	public new LoginVO Data {
		get { return m_data as LoginVO; }
	}

	public LoginProxy()
		: base(NAME, new LoginVO()) {
		Debug.Log("Instantiate LoginVOProxy");

		Data.UserName = "flyme";
		Data.Password = "bf3000z";
	}

	public void VerifyLoginVO(LoginVO login) {
		var rs = Data.Equals(login);
		if (rs) {
			SendNotification(NotificationEnum.LoginPanelNotification.LOGINSUCCEED);
		}
		else {
			SendNotification(NotificationEnum.LoginPanelNotification.LOGINFAIL);
		}

	}

}
