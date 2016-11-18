using PureMVC.Patterns;
using UnityEngine;

public abstract class PureViewWithMonoBehaviour : MonoBehaviour {

	protected object mediator;
	public abstract Mediator Mediator { get; }
}
