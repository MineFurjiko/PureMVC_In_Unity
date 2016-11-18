public class NotificationEnum {

	#region PureMVC Notification
	/// <summary>
	/// 启动事件
	/// </summary>
	public const string STARTUP = "startup";

	/// <summary>
	/// 启动完成
	/// </summary>
	public const string BOOSTRAP = "boostrap";
	#endregion

	#region LoginPanel Notification
	public class LoginPanelNotification {
		/// <summary>
		/// 测试事件
		/// </summary>
		public const string TESTINLOGINPANEL = "test_in_login_panel";
		/// <summary>
		/// 尝试登录
		/// </summary>
		public const string TRYLOGIN = "trylogin";
		/// <summary>
		/// 登录成功
		/// </summary>
		public const string LOGINSUCCEED = "login_succeed";
		/// <summary>
		/// 登录失败
		/// </summary>
		public const string LOGINFAIL = "login_fail";
	}
	#endregion
}

