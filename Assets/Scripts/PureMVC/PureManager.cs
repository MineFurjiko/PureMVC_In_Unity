using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class PureManager : MonoBehaviour {

	//包含所有视图组件View Component
	public PureViewWithMonoBehaviour[] PureViewComponents;

	void Awake() {
		ApplicationFacade facade = ApplicationFacade.Instance;

		facade.RegisterCommand(NotificationEnum.STARTUP, typeof(StartupCommand));

		//启动PureMVC程序，执行StartUP()方法,传入
		facade.StartUp(PureViewComponents);
	}

}
