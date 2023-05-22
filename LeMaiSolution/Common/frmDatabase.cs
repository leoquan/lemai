using LeMaiLogic;
using System;
using System.Windows.Forms;

namespace Common
{
	public partial class frmDatabase : frmBase
	{
		DatabaseConfig _dbconfig;
		int _type = 0;
		public frmDatabase() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
		{
			InitializeComponent();
			this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(base.Number_KeyPress);
			this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(base.Control_KeyPress);
			this.txtServer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(base.Control_KeyPress);
			this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(base.Control_KeyPress);
			this.txtDatabaseName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(base.Control_KeyPress);
			_dbconfig = new DatabaseConfig();
			txtServer.Text = _dbconfig.ServerName;
			txtPort.Text = _dbconfig.Port.ToString();
			txtUser.Text = _dbconfig.User;
			txtPassword.Text = _dbconfig.Password;
			txtDatabaseName.Text = _dbconfig.DatabaseName;
			PBean.CONNECTION_STRING = string.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};", _dbconfig.ServerName, _dbconfig.Port, _dbconfig.User, _dbconfig.Password, _dbconfig.DatabaseName);
		}
		public frmDatabase(int type) : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
		{
			InitializeComponent();
			this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(base.Number_KeyPress);
			this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(base.Control_KeyPress);
			this.txtServer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(base.Control_KeyPress);
			this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(base.Control_KeyPress);
			this.txtDatabaseName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(base.Control_KeyPress);
			_dbconfig = new DatabaseConfig();
			txtServer.Text = _dbconfig.ServerName;
			txtPort.Text = _dbconfig.Port.ToString();
			txtUser.Text = _dbconfig.User;
			txtPassword.Text = _dbconfig.Password;
			txtDatabaseName.Text = _dbconfig.DatabaseName;
			_type = type;
			if (type == 0)
			{
				PBean.CONNECTION_STRING = string.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};", _dbconfig.ServerName, _dbconfig.Port, _dbconfig.User, _dbconfig.Password, _dbconfig.DatabaseName);
			}
			if (type == 1)
			{
				PBean.CONNECTION_STRING = string.Format("Server={0},{1};User Id={2};Password={3};Database={4};", _dbconfig.ServerName, _dbconfig.Port, _dbconfig.User, _dbconfig.Password, _dbconfig.DatabaseName);
			}

		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			//Save config
			_dbconfig.ServerName = txtServer.Text;
			_dbconfig.Port = Int32.Parse(txtPort.Text);
			_dbconfig.User = txtUser.Text;
			_dbconfig.Password = txtPassword.Text;
			_dbconfig.DatabaseName = txtDatabaseName.Text;
			_dbconfig.Save();
			if (_type == 0)
			{
				PBean.CONNECTION_STRING = string.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};", _dbconfig.ServerName, _dbconfig.Port, _dbconfig.User, _dbconfig.Password, _dbconfig.DatabaseName);
			}
			if (_type == 1)
			{
				PBean.CONNECTION_STRING = string.Format("Server={0},{1};User Id={2};Password={3};Database={4};", _dbconfig.ServerName, _dbconfig.Port, _dbconfig.User, _dbconfig.Password, _dbconfig.DatabaseName);
			}

			this.Close();

		}

		private void btnTest_Click(object sender, EventArgs e)
		{
			if (_type == 0)
			{
				PBean.CONNECTION_STRING = string.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};", txtServer.Text, txtPort.Text, txtUser.Text, txtPassword.Text, txtDatabaseName.Text);
				IDataContext dc = PCommon.getDataContext();
				try
				{
					dc.Open();
					btnSave.Enabled = true;
					MessageBox.Show("Connect successfull", PBean.MESSAGE_TITLE);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Connect to server is failure. Error:" + ex.ToString(), PBean.MESSAGE_TITLE);
					btnSave.Enabled = false;
				}
				finally
				{
					dc.Close();
				}
			}
			if (_type == 1)
			{
				PBean.CONNECTION_STRING = string.Format("Server={0},{1};User Id={2};Password={3};Database={4};", txtServer.Text, txtPort.Text, txtUser.Text, txtPassword.Text, txtDatabaseName.Text);
				IDataContext dc = PCommon.getDataContext();
				try
				{
					dc.Open();
					btnSave.Enabled = true;
					MessageBox.Show("Connect successfull", PBean.MESSAGE_TITLE);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Connect to server is failure. Error:" + ex.ToString(), PBean.MESSAGE_TITLE);
					btnSave.Enabled = false;
				}
				finally
				{
					dc.Close();
				}
			}
		}
	}
}
