using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace GenieClient
{
    [DesignerGenerated()]
    public partial class DialogConnect : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            if (disposing && components is object)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        // Required by the Windows Form Designer
        #pragma warning disable 0649
        private System.ComponentModel.IContainer components;
        #pragma warning restore 0649

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogConnect));
            this._TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._OK_Button = new System.Windows.Forms.Button();
            this._Cancel_Button = new System.Windows.Forms.Button();
            this._GroupBox1 = new System.Windows.Forms.GroupBox();
            this.XMLEnabledCheckbox = new System.Windows.Forms.CheckBox();
            this.HandshakeEnabledCheckbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Port = new GenieClient.ComponentTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HostName = new GenieClient.ComponentTextBox();
            this._CheckBoxSavePassword = new System.Windows.Forms.CheckBox();
            this._Label5 = new System.Windows.Forms.Label();
            this._ComboBoxGame = new System.Windows.Forms.ComboBox();
            this._TextBoxCharacter = new System.Windows.Forms.TextBox();
            this._Label4 = new System.Windows.Forms.Label();
            this._TextBoxPassword = new System.Windows.Forms.TextBox();
            this._Label3 = new System.Windows.Forms.Label();
            this._TextBoxAccount = new System.Windows.Forms.TextBox();
            this._Label2 = new System.Windows.Forms.Label();
            this._Label1 = new System.Windows.Forms.Label();
            this._PictureBox1 = new System.Windows.Forms.PictureBox();
            this._TableLayoutPanel1.SuspendLayout();
            this._GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _TableLayoutPanel1
            // 
            this._TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._TableLayoutPanel1.ColumnCount = 2;
            this._TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._TableLayoutPanel1.Controls.Add(this._OK_Button, 0, 0);
            this._TableLayoutPanel1.Controls.Add(this._Cancel_Button, 1, 0);
            this._TableLayoutPanel1.Location = new System.Drawing.Point(221, 374);
            this._TableLayoutPanel1.Name = "_TableLayoutPanel1";
            this._TableLayoutPanel1.RowCount = 1;
            this._TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            this._TableLayoutPanel1.TabIndex = 1;
            // 
            // _OK_Button
            // 
            this._OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._OK_Button.Location = new System.Drawing.Point(3, 3);
            this._OK_Button.Name = "_OK_Button";
            this._OK_Button.Size = new System.Drawing.Size(67, 23);
            this._OK_Button.TabIndex = 0;
            this._OK_Button.Text = "&Connect";
            this._OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // _Cancel_Button
            // 
            this._Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._Cancel_Button.Location = new System.Drawing.Point(76, 3);
            this._Cancel_Button.Name = "_Cancel_Button";
            this._Cancel_Button.Size = new System.Drawing.Size(67, 23);
            this._Cancel_Button.TabIndex = 1;
            this._Cancel_Button.Text = "C&ancel";
            this._Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // _GroupBox1
            // 
            this._GroupBox1.Controls.Add(this.XMLEnabledCheckbox);
            this._GroupBox1.Controls.Add(this.HandshakeEnabledCheckbox);
            this._GroupBox1.Controls.Add(this.label2);
            this._GroupBox1.Controls.Add(this.Port);
            this._GroupBox1.Controls.Add(this.label1);
            this._GroupBox1.Controls.Add(this.HostName);
            this._GroupBox1.Controls.Add(this._CheckBoxSavePassword);
            this._GroupBox1.Controls.Add(this._Label5);
            this._GroupBox1.Controls.Add(this._ComboBoxGame);
            this._GroupBox1.Controls.Add(this._TextBoxCharacter);
            this._GroupBox1.Controls.Add(this._Label4);
            this._GroupBox1.Controls.Add(this._TextBoxPassword);
            this._GroupBox1.Controls.Add(this._Label3);
            this._GroupBox1.Controls.Add(this._TextBoxAccount);
            this._GroupBox1.Controls.Add(this._Label2);
            this._GroupBox1.Controls.Add(this._Label1);
            this._GroupBox1.Controls.Add(this._PictureBox1);
            this._GroupBox1.Location = new System.Drawing.Point(6, 4);
            this._GroupBox1.Name = "_GroupBox1";
            this._GroupBox1.Size = new System.Drawing.Size(357, 364);
            this._GroupBox1.TabIndex = 0;
            this._GroupBox1.TabStop = false;
            this._GroupBox1.Text = "Play.net";
            // 
            // XMLEnabledCheckbox
            // 
            this.XMLEnabledCheckbox.AutoSize = true;
            this.XMLEnabledCheckbox.Checked = true;
            this.XMLEnabledCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.XMLEnabledCheckbox.Location = new System.Drawing.Point(9, 145);
            this.XMLEnabledCheckbox.Name = "XMLEnabledCheckbox";
            this.XMLEnabledCheckbox.Size = new System.Drawing.Size(90, 17);
            this.XMLEnabledCheckbox.TabIndex = 22;
            this.XMLEnabledCheckbox.Text = "XML Enabled";
            this.XMLEnabledCheckbox.UseVisualStyleBackColor = true;
            this.XMLEnabledCheckbox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // HandshakeEnabledCheckbox
            // 
            this.HandshakeEnabledCheckbox.AutoSize = true;
            this.HandshakeEnabledCheckbox.Checked = true;
            this.HandshakeEnabledCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HandshakeEnabledCheckbox.Location = new System.Drawing.Point(186, 145);
            this.HandshakeEnabledCheckbox.Name = "HandshakeEnabledCheckbox";
            this.HandshakeEnabledCheckbox.Size = new System.Drawing.Size(152, 17);
            this.HandshakeEnabledCheckbox.TabIndex = 21;
            this.HandshakeEnabledCheckbox.Text = "Handshake Authentication";
            this.HandshakeEnabledCheckbox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Port Number";
            // 
            // Port
            // 
            this.Port.KeepInput = false;
            this.Port.Location = new System.Drawing.Point(9, 117);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(165, 20);
            this.Port.TabIndex = 19;
            this.Port.Text = "9000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Host Name";
            // 
            // HostName
            // 
            this.HostName.KeepInput = false;
            this.HostName.Location = new System.Drawing.Point(183, 118);
            this.HostName.Name = "HostName";
            this.HostName.Size = new System.Drawing.Size(165, 20);
            this.HostName.TabIndex = 17;
            this.HostName.Text = "abandonedrealms.com";
            // 
            // _CheckBoxSavePassword
            // 
            this._CheckBoxSavePassword.AutoSize = true;
            this._CheckBoxSavePassword.Location = new System.Drawing.Point(9, 164);
            this._CheckBoxSavePassword.Name = "_CheckBoxSavePassword";
            this._CheckBoxSavePassword.Size = new System.Drawing.Size(141, 17);
            this._CheckBoxSavePassword.TabIndex = 16;
            this._CheckBoxSavePassword.Text = "Save password in profile";
            this._CheckBoxSavePassword.UseVisualStyleBackColor = true;
            this._CheckBoxSavePassword.CheckedChanged += new System.EventHandler(this.CheckBoxSavePassword_CheckedChanged);
            // 
            // _Label5
            // 
            this._Label5.AutoSize = true;
            this._Label5.Location = new System.Drawing.Point(180, 55);
            this._Label5.Name = "_Label5";
            this._Label5.Size = new System.Drawing.Size(35, 13);
            this._Label5.TabIndex = 15;
            this._Label5.Text = "Game";
            // 
            // _ComboBoxGame
            // 
            this._ComboBoxGame.FormattingEnabled = true;
            this._ComboBoxGame.Items.AddRange(new object[] {
            "DR",
            "DRX",
            "DRF",
            "GS3",
            "GSX",
            "MO",
            "HX"});
            this._ComboBoxGame.Location = new System.Drawing.Point(183, 71);
            this._ComboBoxGame.Name = "_ComboBoxGame";
            this._ComboBoxGame.Size = new System.Drawing.Size(165, 21);
            this._ComboBoxGame.TabIndex = 3;
            this._ComboBoxGame.Text = "DR";
            // 
            // _TextBoxCharacter
            // 
            this._TextBoxCharacter.Location = new System.Drawing.Point(9, 71);
            this._TextBoxCharacter.Name = "_TextBoxCharacter";
            this._TextBoxCharacter.Size = new System.Drawing.Size(165, 20);
            this._TextBoxCharacter.TabIndex = 2;
            this._TextBoxCharacter.Text = "test";
            // 
            // _Label4
            // 
            this._Label4.AutoSize = true;
            this._Label4.Location = new System.Drawing.Point(6, 55);
            this._Label4.Name = "_Label4";
            this._Label4.Size = new System.Drawing.Size(84, 13);
            this._Label4.TabIndex = 12;
            this._Label4.Text = "Character Name";
            // 
            // _TextBoxPassword
            // 
            this._TextBoxPassword.Location = new System.Drawing.Point(183, 32);
            this._TextBoxPassword.Name = "_TextBoxPassword";
            this._TextBoxPassword.Size = new System.Drawing.Size(165, 20);
            this._TextBoxPassword.TabIndex = 1;
            this._TextBoxPassword.Text = "test";
            this._TextBoxPassword.UseSystemPasswordChar = true;
            // 
            // _Label3
            // 
            this._Label3.AutoSize = true;
            this._Label3.Location = new System.Drawing.Point(180, 16);
            this._Label3.Name = "_Label3";
            this._Label3.Size = new System.Drawing.Size(53, 13);
            this._Label3.TabIndex = 10;
            this._Label3.Text = "Password";
            // 
            // _TextBoxAccount
            // 
            this._TextBoxAccount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this._TextBoxAccount.Location = new System.Drawing.Point(9, 32);
            this._TextBoxAccount.Name = "_TextBoxAccount";
            this._TextBoxAccount.Size = new System.Drawing.Size(165, 20);
            this._TextBoxAccount.TabIndex = 0;
            this._TextBoxAccount.Text = "TEST";
            // 
            // _Label2
            // 
            this._Label2.AutoSize = true;
            this._Label2.Location = new System.Drawing.Point(6, 16);
            this._Label2.Name = "_Label2";
            this._Label2.Size = new System.Drawing.Size(78, 13);
            this._Label2.TabIndex = 8;
            this._Label2.Text = "Account Name";
            // 
            // _Label1
            // 
            this._Label1.Location = new System.Drawing.Point(51, 187);
            this._Label1.Name = "_Label1";
            this._Label1.Size = new System.Drawing.Size(301, 32);
            this._Label1.TabIndex = 7;
            this._Label1.Text = "Leave character name empty to get a list of characters on the account.";
            // 
            // _PictureBox1
            // 
            this._PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("_PictureBox1.Image")));
            this._PictureBox1.Location = new System.Drawing.Point(9, 187);
            this._PictureBox1.Name = "_PictureBox1";
            this._PictureBox1.Size = new System.Drawing.Size(32, 32);
            this._PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this._PictureBox1.TabIndex = 6;
            this._PictureBox1.TabStop = false;
            // 
            // DialogConnect
            // 
            this.AcceptButton = this._OK_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._Cancel_Button;
            this.ClientSize = new System.Drawing.Size(370, 406);
            this.Controls.Add(this._GroupBox1);
            this.Controls.Add(this._TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogConnect";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Simutronics Game Connect";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DialogConnect_Load);
            this.VisibleChanged += new System.EventHandler(this.DialogConnect_VisibleChanged);
            this._TableLayoutPanel1.ResumeLayout(false);
            this._GroupBox1.ResumeLayout(false);
            this._GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private TableLayoutPanel _TableLayoutPanel1;

        internal TableLayoutPanel TableLayoutPanel1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TableLayoutPanel1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TableLayoutPanel1 != null)
                {
                }

                _TableLayoutPanel1 = value;
                if (_TableLayoutPanel1 != null)
                {
                }
            }
        }

        private Button _OK_Button;

        internal Button OK_Button
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _OK_Button;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_OK_Button != null)
                {
                    _OK_Button.Click -= OK_Button_Click;
                }

                _OK_Button = value;
                if (_OK_Button != null)
                {
                    _OK_Button.Click += OK_Button_Click;
                }
            }
        }

        private Button _Cancel_Button;

        internal Button Cancel_Button
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Cancel_Button;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Cancel_Button != null)
                {
                    _Cancel_Button.Click -= Cancel_Button_Click;
                }

                _Cancel_Button = value;
                if (_Cancel_Button != null)
                {
                    _Cancel_Button.Click += Cancel_Button_Click;
                }
            }
        }

        private GroupBox _GroupBox1;

        internal GroupBox GroupBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GroupBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GroupBox1 != null)
                {
                }

                _GroupBox1 = value;
                if (_GroupBox1 != null)
                {
                }
            }
        }

        private Label _Label5;

        internal Label Label5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label5 != null)
                {
                }

                _Label5 = value;
                if (_Label5 != null)
                {
                }
            }
        }

        private ComboBox _ComboBoxGame;

        internal ComboBox ComboBoxGame
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBoxGame;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBoxGame != null)
                {
                }

                _ComboBoxGame = value;
                if (_ComboBoxGame != null)
                {
                }
            }
        }

        private TextBox _TextBoxCharacter;

        internal TextBox TextBoxCharacter
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxCharacter;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxCharacter != null)
                {
                }

                _TextBoxCharacter = value;
                if (_TextBoxCharacter != null)
                {
                }
            }
        }

        private Label _Label4;

        internal Label Label4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label4 != null)
                {
                }

                _Label4 = value;
                if (_Label4 != null)
                {
                }
            }
        }

        private TextBox _TextBoxPassword;

        internal TextBox TextBoxPassword
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxPassword;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxPassword != null)
                {
                }

                _TextBoxPassword = value;
                if (_TextBoxPassword != null)
                {
                }
            }
        }

        private Label _Label3;

        internal Label Label3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label3 != null)
                {
                }

                _Label3 = value;
                if (_Label3 != null)
                {
                }
            }
        }

        private TextBox _TextBoxAccount;

        internal TextBox TextBoxAccount
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxAccount;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxAccount != null)
                {
                }

                _TextBoxAccount = value;
                if (_TextBoxAccount != null)
                {
                }
            }
        }

        private Label _Label2;

        internal Label Label2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label2 != null)
                {
                }

                _Label2 = value;
                if (_Label2 != null)
                {
                }
            }
        }

        private Label _Label1;

        internal Label Label1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label1 != null)
                {
                }

                _Label1 = value;
                if (_Label1 != null)
                {
                }
            }
        }

        private PictureBox _PictureBox1;

        internal PictureBox PictureBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PictureBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PictureBox1 != null)
                {
                }

                _PictureBox1 = value;
                if (_PictureBox1 != null)
                {
                }
            }
        }

        private CheckBox _CheckBoxSavePassword;
        private CheckBox XMLEnabledCheckbox;
        private CheckBox HandshakeEnabledCheckbox;
        private Label label2;
        private ComponentTextBox Port;
        private Label label1;
        private ComponentTextBox HostName;

        internal CheckBox CheckBoxSavePassword
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CheckBoxSavePassword;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CheckBoxSavePassword != null)
                {
                    _CheckBoxSavePassword.CheckedChanged -= CheckBoxSavePassword_CheckedChanged;
                }

                _CheckBoxSavePassword = value;
                if (_CheckBoxSavePassword != null)
                {
                    _CheckBoxSavePassword.CheckedChanged += CheckBoxSavePassword_CheckedChanged;
                }
            }
        }
    }
}