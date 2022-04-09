
namespace VixenModules.OutputFilter.ShutterFilter
{
	partial class ShutterFilterSetup
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTag = new System.Windows.Forms.TextBox();
            this.checkBoxConvert = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textOpenShutter = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonCancel);
            this.flowLayoutPanel1.Controls.Add(this.buttonOk);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 106);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(383, 35);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(304, 3);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(221, 3);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            this.buttonOk.MouseLeave += new System.EventHandler(this.buttonBackground_MouseLeave);
            this.buttonOk.MouseHover += new System.EventHandler(this.buttonBackground_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tag:";
            // 
            // textBoxTag
            // 
            this.textBoxTag.Location = new System.Drawing.Point(44, 15);
            this.textBoxTag.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTag.Name = "textBoxTag";
            this.textBoxTag.Size = new System.Drawing.Size(116, 23);
            this.textBoxTag.TabIndex = 4;
            this.textBoxTag.TextChanged += new System.EventHandler(this.textBoxTag_TextChanged);
            // 
            // checkBoxConvert
            // 
            this.checkBoxConvert.AutoSize = true;
            this.checkBoxConvert.Location = new System.Drawing.Point(19, 45);
            this.checkBoxConvert.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxConvert.Name = "checkBoxConvert";
            this.checkBoxConvert.Size = new System.Drawing.Size(228, 19);
            this.checkBoxConvert.TabIndex = 5;
            this.checkBoxConvert.Text = "Automatically Open and Close Shutter";
            this.checkBoxConvert.UseVisualStyleBackColor = true;
            this.checkBoxConvert.CheckedChanged += new System.EventHandler(this.checkBoxConvert_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Open Shutter Value:";
            // 
            // textOpenShutter
            // 
            this.textOpenShutter.Location = new System.Drawing.Point(131, 77);
            this.textOpenShutter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textOpenShutter.Name = "textOpenShutter";
            this.textOpenShutter.Size = new System.Drawing.Size(116, 23);
            this.textOpenShutter.TabIndex = 7;
            this.textOpenShutter.TextChanged += new System.EventHandler(this.textOpenShutter_TextChanged);
            // 
            // ShutterFilterSetup
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(383, 141);
            this.Controls.Add(this.textOpenShutter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxConvert);
            this.Controls.Add(this.textBoxTag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ShutterFilterSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Shutter Filter Setup";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxTag;
		private System.Windows.Forms.CheckBox checkBoxConvert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textOpenShutter;
    }
}