using PureMVC.Interfaces;
using PureMVC.Patterns;
using System.Collections.Generic;
using UnityEngine;

public class UIPanel1Mediator:Mediator,IMediator {
	public new const string NAME = "UIPanel1Mediator";

	public UIPanel1Mediator(UIPanel1 viewComponent):base(NAME,viewComponent) {
		Debug.Log("Instantiate UIPanel1Mediator");

		//add Listener
		viewComponent.TryLoginEvent+=TryLogin;
	}

	/// <summary>
	/// 获取ViewComponent
	/// </summary>
	private new UIPanel1 ViewComponent {
		get {
			return m_viewComponent as UIPanel1;
		}
	}

	/// <summary>
	/// Mediator中实现具体操作
	/// </summary>
	private void TryLogin() {
		//发送的事件string(NotificationEnum.DOSOMETHINGS) 
		//发送者(this)
		//SendNotification(NotificationEnum.LoginPanelNotification.TESTINLOGINPANEL, this);
		SendNotification(NotificationEnum.LoginPanelNotification.TRYLOGIN,
			ViewComponent.GetInputLoginVO());
	}

	/// <summary>
	/// 添加通知监听列表(NotificationEnum)
	/// </summary>
	/// <returns></returns>
	public override IList<string> ListNotificationInterests() {
		var list=base.ListNotificationInterests();

		list.Add(NotificationEnum.LoginPanelNotification.TESTINLOGINPANEL);
		list.Add(NotificationEnum.LoginPanelNotification.LOGINSUCCEED);
		list.Add(NotificationEnum.LoginPanelNotification.LOGINFAIL);

		return list;
	}

	/// <summary>
	/// 处理通知
	/// </summary>
	/// <param name="notification"></param>
	public override void HandleNotification(INotification notification) {
		switch (notification.Name) {
			case NotificationEnum.LoginPanelNotification.TESTINLOGINPANEL:
				Debug.Log("UIPanel1Mediator 处理 "+notification.Name+" ...");
				Debug.Log(notification.Body);
				ViewComponent.text.text = "Click!";
				break;
			case NotificationEnum.LoginPanelNotification.LOGINSUCCEED:
				ViewComponent.LoginSucceed();
				break;
			case NotificationEnum.LoginPanelNotification.LOGINFAIL:
				ViewComponent.LoginFail();
				break;
		}
	}

}

