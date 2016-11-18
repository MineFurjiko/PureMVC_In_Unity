using PureMVC.Patterns;
using PureMVC.Interfaces;
using System.Collections.Generic;
using UnityEngine;

class ProxyPrepCommand : SimpleCommand {
	public override void Execute(INotification notification) {
		Debug.Log("Register Prep Model.");
		var facade = ApplicationFacade.Instance;

		facade.RegisterProxy(new LoginProxy());
	}
}

