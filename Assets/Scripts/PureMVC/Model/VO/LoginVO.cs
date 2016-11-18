using System;
using System.Collections;

public class LoginVO : IEquatable<LoginVO> {
	private string userName = "";
	private string password = "";

	public string UserName {
		get { return userName; }
		set { userName = value; }
	}

	public string Password {
		get { return password; }
		set { password = value; }
	}

	public LoginVO() { }
	public LoginVO(string userName, string password) {
		this.userName = userName;
		this.password = password;
	}


	public bool Equals(LoginVO other) {
		return (UserName.Equals(other.UserName) && Password.Equals(other.Password));
	}
}
