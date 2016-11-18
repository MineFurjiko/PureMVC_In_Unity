using PureMVC.Interfaces;
using PureMVC.Patterns;
using System.Collections.Generic;
using UnityEngine;
public class TitlePanelMediator : Mediator, IMediator {
	public new const string NAME = "TitlePanelMediator";

	public TitlePanelMediator(TitlePanel titlePanel):base(NAME,titlePanel) {
		Debug.Log("Instantiate TitlePanelMediator");

	}

	private new TitlePanel ViewComponent {
		get {
			return m_viewComponent as TitlePanel;
		}
	}

	public override IList<string> ListNotificationInterests() {
		var list = base.ListNotificationInterests();

		list.Add(NotificationEnum.BOOSTRAP);

		return list;
	}

	public override void HandleNotification(INotification notification) {
		switch (notification.Name) {
			case NotificationEnum.BOOSTRAP:
				ViewComponent.label.text = "Welcome to PureMVC in Unity3d!";
				break;
		}
	}
}

