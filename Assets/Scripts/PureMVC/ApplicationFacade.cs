using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
using PureMVC.Interfaces;

public class ApplicationFacade : Facade {
	private ApplicationFacade() {}

	//得到AppFacade单例的工厂方法 
	public new static ApplicationFacade Instance {
		get {
			if (m_instance==null) {
				Debug.Log("Instantiate ApplicationFacade.");
				m_instance = new ApplicationFacade();
			}
			return m_instance as ApplicationFacade;
		}
	}

	/// <summary>
	/// 启动PureMVC
	/// </summary>
	/// <param name="sender"></param>
	public void StartUp(object sender=null) {
		//发送 StartUp 通知
		SendNotification(NotificationEnum.STARTUP, sender);
	}


}
