using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
using UnityEngine.UI;

public class TitlePanel : PureViewWithMonoBehaviour {

	public Text label;

	public override Mediator Mediator {
		get {
			if (mediator == null) {
				mediator = new TitlePanelMediator(this);
			}
			return mediator as Mediator;
		}
	}
}
