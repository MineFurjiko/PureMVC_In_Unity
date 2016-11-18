using PureMVC.Interfaces;
using PureMVC.Patterns;
using System.Collections.Generic;
using UnityEngine;

class StartupCommand : MacroCommand {
	//添加子Command初始化MacroCommand
	protected override void InitializeMacroCommand() {
		Debug.Log("StartupCommand().");
		AddSubCommand(typeof(CommandPrepCommand));
		AddSubCommand(typeof(ProxyPrepCommand));
		AddSubCommand(typeof(MediatorPrepCommand));
	}

	public override void Execute(INotification notification) {
		base.Execute(notification);
		SendNotification(NotificationEnum.BOOSTRAP);
	}
}

