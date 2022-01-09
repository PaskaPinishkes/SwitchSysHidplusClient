
namespace SwitchSysHidplusUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.layoutStyle4 = new System.Windows.Forms.ComboBox();
            this.layoutStyle3 = new System.Windows.Forms.ComboBox();
            this.layoutStyle2 = new System.Windows.Forms.ComboBox();
            this.connectionStatus1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modeComboBox = new System.Windows.Forms.ComboBox();
            this.connectionStatus2 = new System.Windows.Forms.Label();
            this.connectionStatus3 = new System.Windows.Forms.Label();
            this.connectionStatus4 = new System.Windows.Forms.Label();
            this.layoutStyle1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect to Switch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ipTextBox
            // 
            this.ipTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ipTextBox.Location = new System.Drawing.Point(3, 54);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(123, 23);
            this.ipTextBox.TabIndex = 1;
            this.ipTextBox.Text = "192.168.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Switch IP";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.layoutStyle4, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.layoutStyle3, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.layoutStyle2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.connectionStatus1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ipTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.modeComboBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.connectionStatus2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.connectionStatus3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.connectionStatus4, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.layoutStyle1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.26863F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.26863F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.80869F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.38542F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.26863F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(645, 373);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // layoutStyle4
            // 
            this.layoutStyle4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutStyle4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.layoutStyle4.FormattingEnabled = true;
            this.layoutStyle4.Items.AddRange(new object[] {
            "Switch Alignment",
            "Xbox Alignment"});
            this.layoutStyle4.Location = new System.Drawing.Point(519, 105);
            this.layoutStyle4.Name = "layoutStyle4";
            this.layoutStyle4.Size = new System.Drawing.Size(123, 23);
            this.layoutStyle4.TabIndex = 19;
            // 
            // layoutStyle3
            // 
            this.layoutStyle3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutStyle3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.layoutStyle3.FormattingEnabled = true;
            this.layoutStyle3.Items.AddRange(new object[] {
            "Switch Alignment",
            "Xbox Alignment"});
            this.layoutStyle3.Location = new System.Drawing.Point(390, 105);
            this.layoutStyle3.Name = "layoutStyle3";
            this.layoutStyle3.Size = new System.Drawing.Size(123, 23);
            this.layoutStyle3.TabIndex = 18;
            // 
            // layoutStyle2
            // 
            this.layoutStyle2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutStyle2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.layoutStyle2.FormattingEnabled = true;
            this.layoutStyle2.Items.AddRange(new object[] {
            "Switch Alignment",
            "Xbox Alignment"});
            this.layoutStyle2.Location = new System.Drawing.Point(261, 105);
            this.layoutStyle2.Name = "layoutStyle2";
            this.layoutStyle2.Size = new System.Drawing.Size(123, 23);
            this.layoutStyle2.TabIndex = 17;
            // 
            // connectionStatus1
            // 
            this.connectionStatus1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionStatus1.AutoSize = true;
            this.connectionStatus1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.connectionStatus1.Location = new System.Drawing.Point(132, 51);
            this.connectionStatus1.Name = "connectionStatus1";
            this.connectionStatus1.Size = new System.Drawing.Size(123, 51);
            this.connectionStatus1.TabIndex = 9;
            this.connectionStatus1.Text = "Disconnected";
            this.connectionStatus1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.connectionStatus1.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(519, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 51);
            this.label6.TabIndex = 8;
            this.label6.Text = "Controller 4";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 51);
            this.label5.TabIndex = 7;
            this.label5.Text = "Controller 3";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 51);
            this.label4.TabIndex = 6;
            this.label4.Text = "Controller 2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 51);
            this.label3.TabIndex = 5;
            this.label3.Text = "Controller 1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(3, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input Mode";
            // 
            // modeComboBox
            // 
            this.modeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeComboBox.FormattingEnabled = true;
            this.modeComboBox.Items.AddRange(new object[] {
            "Normal Mode",
            "Anarchy Mode"});
            this.modeComboBox.Location = new System.Drawing.Point(3, 310);
            this.modeComboBox.Name = "modeComboBox";
            this.modeComboBox.Size = new System.Drawing.Size(123, 23);
            this.modeComboBox.TabIndex = 3;
            this.modeComboBox.SelectedIndexChanged += new System.EventHandler(this.modeComboBox_SelectedIndexChanged);
            // 
            // connectionStatus2
            // 
            this.connectionStatus2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionStatus2.AutoSize = true;
            this.connectionStatus2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.connectionStatus2.Location = new System.Drawing.Point(261, 51);
            this.connectionStatus2.Name = "connectionStatus2";
            this.connectionStatus2.Size = new System.Drawing.Size(123, 51);
            this.connectionStatus2.TabIndex = 13;
            this.connectionStatus2.Text = "Disconnected";
            this.connectionStatus2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // connectionStatus3
            // 
            this.connectionStatus3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionStatus3.AutoSize = true;
            this.connectionStatus3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.connectionStatus3.Location = new System.Drawing.Point(390, 51);
            this.connectionStatus3.Name = "connectionStatus3";
            this.connectionStatus3.Size = new System.Drawing.Size(123, 51);
            this.connectionStatus3.TabIndex = 14;
            this.connectionStatus3.Text = "Disconnected";
            this.connectionStatus3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // connectionStatus4
            // 
            this.connectionStatus4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionStatus4.AutoSize = true;
            this.connectionStatus4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.connectionStatus4.Location = new System.Drawing.Point(519, 51);
            this.connectionStatus4.Name = "connectionStatus4";
            this.connectionStatus4.Size = new System.Drawing.Size(123, 51);
            this.connectionStatus4.TabIndex = 15;
            this.connectionStatus4.Text = "Disconnected";
            this.connectionStatus4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // layoutStyle1
            // 
            this.layoutStyle1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutStyle1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.layoutStyle1.FormattingEnabled = true;
            this.layoutStyle1.Items.AddRange(new object[] {
            "Switch Alignment",
            "Xbox Alignment"});
            this.layoutStyle1.Location = new System.Drawing.Point(132, 105);
            this.layoutStyle1.Name = "layoutStyle1";
            this.layoutStyle1.Size = new System.Drawing.Size(123, 23);
            this.layoutStyle1.TabIndex = 16;
            this.layoutStyle1.SelectedIndexChanged += new System.EventHandler(this.layoutStyle1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 373);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "sys-hidplus Client";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox modeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label connectionStatus1;
        private System.Windows.Forms.Label connectionStatus2;
        private System.Windows.Forms.Label connectionStatus3;
        private System.Windows.Forms.Label connectionStatus4;
        private System.Windows.Forms.ComboBox layoutStyle1;
        private System.Windows.Forms.ComboBox layoutStyle4;
        private System.Windows.Forms.ComboBox layoutStyle3;
        private System.Windows.Forms.ComboBox layoutStyle2;
    }
}

