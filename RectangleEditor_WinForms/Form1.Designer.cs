
using System.Drawing;
using System.Windows.Forms;

namespace RectangleEditor_WinForms {
	partial class Form1 {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label_width = new System.Windows.Forms.Label();
			this.textBox_width = new System.Windows.Forms.TextBox();
			this.label_height = new System.Windows.Forms.Label();
			this.textBox_height = new System.Windows.Forms.TextBox();
			this.label_x = new System.Windows.Forms.Label();
			this.textBox_x = new System.Windows.Forms.TextBox();
			this.label_y = new System.Windows.Forms.Label();
			this.textBox_y = new System.Windows.Forms.TextBox();
			this.radioButton_red = new System.Windows.Forms.RadioButton();
			this.radioButton_blue = new System.Windows.Forms.RadioButton();
			this.radioButton_yellow = new System.Windows.Forms.RadioButton();
			this.radioButton_gray = new System.Windows.Forms.RadioButton();
			this.createButton = new System.Windows.Forms.Button();
			this.flowLayoutPanel_create = new System.Windows.Forms.FlowLayoutPanel();
			this.canvas = new System.Windows.Forms.PictureBox();
			this.flowLayoutPanel_create.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
			this.SuspendLayout();
			// 
			// label_width
			// 
			this.label_width.AutoSize = true;
			this.label_width.Location = new System.Drawing.Point(3, 0);
			this.label_width.Name = "label_width";
			this.label_width.Size = new System.Drawing.Size(45, 30);
			this.label_width.TabIndex = 1;
			this.label_width.Text = "幅: ";
			// 
			// textBox_width
			// 
			this.textBox_width.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.textBox_width.Location = new System.Drawing.Point(54, 3);
			this.textBox_width.Name = "textBox_width";
			this.textBox_width.Size = new System.Drawing.Size(70, 35);
			this.textBox_width.TabIndex = 0;
			// 
			// label_height
			// 
			this.label_height.AutoSize = true;
			this.label_height.Location = new System.Drawing.Point(130, 0);
			this.label_height.Name = "label_height";
			this.label_height.Size = new System.Drawing.Size(59, 30);
			this.label_height.TabIndex = 5;
			this.label_height.Text = "高さ: ";
			// 
			// textBox_height
			// 
			this.textBox_height.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.textBox_height.Location = new System.Drawing.Point(195, 3);
			this.textBox_height.Name = "textBox_height";
			this.textBox_height.Size = new System.Drawing.Size(70, 35);
			this.textBox_height.TabIndex = 2;
			// 
			// label_x
			// 
			this.label_x.AutoSize = true;
			this.label_x.Location = new System.Drawing.Point(271, 0);
			this.label_x.Name = "label_x";
			this.label_x.Size = new System.Drawing.Size(34, 30);
			this.label_x.TabIndex = 6;
			this.label_x.Text = "x: ";
			// 
			// textBox_x
			// 
			this.textBox_x.Location = new System.Drawing.Point(311, 3);
			this.textBox_x.Name = "textBox_x";
			this.textBox_x.Size = new System.Drawing.Size(70, 35);
			this.textBox_x.TabIndex = 3;
			// 
			// label_y
			// 
			this.label_y.AutoSize = true;
			this.label_y.Location = new System.Drawing.Point(387, 0);
			this.label_y.Name = "label_y";
			this.label_y.Size = new System.Drawing.Size(34, 30);
			this.label_y.TabIndex = 7;
			this.label_y.Text = "y: ";
			// 
			// textBox_y
			// 
			this.textBox_y.Location = new System.Drawing.Point(427, 3);
			this.textBox_y.Name = "textBox_y";
			this.textBox_y.Size = new System.Drawing.Size(70, 35);
			this.textBox_y.TabIndex = 4;
			// 
			// radioButton_red
			// 
			this.radioButton_red.AutoSize = true;
			this.radioButton_red.Location = new System.Drawing.Point(503, 3);
			this.radioButton_red.Name = "radioButton_red";
			this.radioButton_red.Size = new System.Drawing.Size(68, 34);
			this.radioButton_red.TabIndex = 8;
			this.radioButton_red.TabStop = true;
			this.radioButton_red.Text = "red";
			this.radioButton_red.UseVisualStyleBackColor = true;
			// 
			// radioButton_blue
			// 
			this.radioButton_blue.AutoSize = true;
			this.radioButton_blue.Location = new System.Drawing.Point(577, 3);
			this.radioButton_blue.Name = "radioButton_blue";
			this.radioButton_blue.Size = new System.Drawing.Size(78, 34);
			this.radioButton_blue.TabIndex = 9;
			this.radioButton_blue.TabStop = true;
			this.radioButton_blue.Text = "blue";
			this.radioButton_blue.UseVisualStyleBackColor = true;
			// 
			// radioButton_yellow
			// 
			this.radioButton_yellow.AutoSize = true;
			this.radioButton_yellow.Location = new System.Drawing.Point(661, 3);
			this.radioButton_yellow.Name = "radioButton_yellow";
			this.radioButton_yellow.Size = new System.Drawing.Size(96, 34);
			this.radioButton_yellow.TabIndex = 10;
			this.radioButton_yellow.TabStop = true;
			this.radioButton_yellow.Text = "yellow";
			this.radioButton_yellow.UseVisualStyleBackColor = true;
			// 
			// radioButton_gray
			// 
			this.radioButton_gray.AutoSize = true;
			this.radioButton_gray.Location = new System.Drawing.Point(763, 3);
			this.radioButton_gray.Name = "radioButton_gray";
			this.radioButton_gray.Size = new System.Drawing.Size(78, 34);
			this.radioButton_gray.TabIndex = 11;
			this.radioButton_gray.TabStop = true;
			this.radioButton_gray.Text = "gray";
			this.radioButton_gray.UseVisualStyleBackColor = true;
			// 
			// createButton
			// 
			this.createButton.Location = new System.Drawing.Point(847, 3);
			this.createButton.Name = "createButton";
			this.createButton.Size = new System.Drawing.Size(131, 40);
			this.createButton.TabIndex = 12;
			this.createButton.Text = "create";
			this.createButton.UseVisualStyleBackColor = true;
			this.createButton.Click += new System.EventHandler(this.createButton_Click);
			// 
			// flowLayoutPanel_create
			// 
			this.flowLayoutPanel_create.Controls.Add(this.label_width);
			this.flowLayoutPanel_create.Controls.Add(this.textBox_width);
			this.flowLayoutPanel_create.Controls.Add(this.label_height);
			this.flowLayoutPanel_create.Controls.Add(this.textBox_height);
			this.flowLayoutPanel_create.Controls.Add(this.label_x);
			this.flowLayoutPanel_create.Controls.Add(this.textBox_x);
			this.flowLayoutPanel_create.Controls.Add(this.label_y);
			this.flowLayoutPanel_create.Controls.Add(this.textBox_y);
			this.flowLayoutPanel_create.Controls.Add(this.radioButton_red);
			this.flowLayoutPanel_create.Controls.Add(this.radioButton_blue);
			this.flowLayoutPanel_create.Controls.Add(this.radioButton_yellow);
			this.flowLayoutPanel_create.Controls.Add(this.radioButton_gray);
			this.flowLayoutPanel_create.Controls.Add(this.createButton);
			this.flowLayoutPanel_create.Location = new System.Drawing.Point(316, 38);
			this.flowLayoutPanel_create.Name = "flowLayoutPanel_create";
			this.flowLayoutPanel_create.Size = new System.Drawing.Size(1135, 57);
			this.flowLayoutPanel_create.TabIndex = 13;
			// 
			// pictureBox1
			// 
			this.canvas.Location = new System.Drawing.Point(220, 190);
			this.canvas.Name = "canvas";
			this.canvas.Size = new System.Drawing.Size(1418, 780);
			this.canvas.TabIndex = 14;
			this.canvas.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1919, 1163);
			this.Controls.Add(this.canvas);
			this.Controls.Add(this.flowLayoutPanel_create);
			this.Name = "Form1";
			this.Text = "RectangleEditor";
			this.flowLayoutPanel_create.ResumeLayout(false);
			this.flowLayoutPanel_create.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox textBox_width;
		private System.Windows.Forms.TextBox textBox_height;
		private System.Windows.Forms.TextBox textBox_x;
		private System.Windows.Forms.TextBox textBox_y;
		private System.Windows.Forms.Label label_width;
		private System.Windows.Forms.Label label_height;
		private System.Windows.Forms.Label label_x;
		private System.Windows.Forms.Label label_y;
		private System.Windows.Forms.RadioButton radioButton_red;
		private System.Windows.Forms.RadioButton radioButton_blue;
		private System.Windows.Forms.RadioButton radioButton_yellow;
		private System.Windows.Forms.RadioButton radioButton_gray;
		private System.Windows.Forms.Button createButton;
		private FlowLayoutPanel flowLayoutPanel_create;
		private PictureBox canvas;
	}
}

