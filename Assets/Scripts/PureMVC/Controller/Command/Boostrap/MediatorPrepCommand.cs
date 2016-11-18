using PureMVC.Patterns;
using PureMVC.Interfaces;
using System.Collections.Generic;
using UnityEngine;

class MediatorPrepCommand : SimpleCommand {
	public override void Execute(INotification notification) {
		Debug.Log("Register Prep Mediator.");
		var facade = ApplicationFacade.Instance;

		//注册Mediator
		var pureViews = (notification.Body as PureViewWithMonoBehaviour[]);
		if (pureViews != null)
			foreach (var item in pureViews)
				if (item != null)
					facade.RegisterMediator(item.Mediator);
		
	}
}

