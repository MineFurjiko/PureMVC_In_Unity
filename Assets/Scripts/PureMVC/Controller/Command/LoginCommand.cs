using PureMVC.Interfaces;
using PureMVC.Patterns;
using System;
using System.Collections.Generic;

class LoginCommand : SimpleCommand {
	public override void Execute(INotification notification) {
		var LoginVO = notification.Body as LoginVO;
		var proxy = ApplicationFacade.Instance.RetrieveProxy(LoginProxy.NAME) as LoginProxy ;
		proxy.VerifyLoginVO(LoginVO);
	}
}

