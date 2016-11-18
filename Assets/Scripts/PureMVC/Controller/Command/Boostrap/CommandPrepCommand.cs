using System;
using PureMVC.Patterns;
using PureMVC.Interfaces;
using System.Collections.Generic;
using UnityEngine;

class CommandPrepCommand : SimpleCommand {
	public override void Execute(INotification notification) {
		Debug.Log("Register Prep Command.");
		var facade=ApplicationFacade.Instance;

		//注册Command
		facade.RegisterCommand(NotificationEnum.LoginPanelNotification.TRYLOGIN, 
			typeof(LoginCommand));

	}
}

