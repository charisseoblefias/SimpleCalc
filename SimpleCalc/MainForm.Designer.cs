/*
 * Created by SharpDevelop.
 * User: Charisse Oblefias
 * Date: 6/5/2021
 * Time: 5:39 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SimpleCalc
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton DivideRadioButton;
		private System.Windows.Forms.RadioButton MultiplyRadioButton;
		private System.Windows.Forms.RadioButton SubtractRadioButton;
		private System.Windows.Forms.RadioButton AddRadioButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox FirstTextBox;
		private System.Windows.Forms.TextBox SecondTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox AnswerTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Button ExitButton;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.DivideRadioButton = new System.Windows.Forms.RadioButton();
			this.MultiplyRadioButton = new System.Windows.Forms.RadioButton();
			this.SubtractRadioButton = new System.Windows.Forms.RadioButton();
			this.AddRadioButton = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.FirstTextBox = new System.Windows.Forms.TextBox();
			this.SecondTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.AnswerTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.ClearButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.DivideRadioButton);
			this.groupBox1.Controls.Add(this.MultiplyRadioButton);
			this.groupBox1.Controls.Add(this.SubtractRadioButton);
			this.groupBox1.Controls.Add(this.AddRadioButton);
			this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(28, 62);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(138, 197);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Compute";
			// 
			// DivideRadioButton
			// 
			this.DivideRadioButton.Location = new System.Drawing.Point(19, 143);
			this.DivideRadioButton.Name = "DivideRadioButton";
			this.DivideRadioButton.Size = new System.Drawing.Size(81, 27);
			this.DivideRadioButton.TabIndex = 3;
			this.DivideRadioButton.TabStop = true;
			this.DivideRadioButton.Text = "Divide";
			this.DivideRadioButton.UseVisualStyleBackColor = true;
			this.DivideRadioButton.CheckedChanged += new System.EventHandler(this.DivideRadioButtonCheckedChanged);
			// 
			// MultiplyRadioButton
			// 
			this.MultiplyRadioButton.Location = new System.Drawing.Point(19, 108);
			this.MultiplyRadioButton.Name = "MultiplyRadioButton";
			this.MultiplyRadioButton.Size = new System.Drawing.Size(98, 27);
			this.MultiplyRadioButton.TabIndex = 2;
			this.MultiplyRadioButton.TabStop = true;
			this.MultiplyRadioButton.Text = "Multiply";
			this.MultiplyRadioButton.UseVisualStyleBackColor = true;
			this.MultiplyRadioButton.CheckedChanged += new System.EventHandler(this.MultiplyRadioButtonCheckedChanged);
			// 
			// SubtractRadioButton
			// 
			this.SubtractRadioButton.Location = new System.Drawing.Point(19, 73);
			this.SubtractRadioButton.Name = "SubtractRadioButton";
			this.SubtractRadioButton.Size = new System.Drawing.Size(98, 27);
			this.SubtractRadioButton.TabIndex = 1;
			this.SubtractRadioButton.TabStop = true;
			this.SubtractRadioButton.Text = "Subtract";
			this.SubtractRadioButton.UseVisualStyleBackColor = true;
			this.SubtractRadioButton.CheckedChanged += new System.EventHandler(this.SubtractRadioButtonCheckedChanged);
			// 
			// AddRadioButton
			// 
			this.AddRadioButton.Location = new System.Drawing.Point(19, 38);
			this.AddRadioButton.Name = "AddRadioButton";
			this.AddRadioButton.Size = new System.Drawing.Size(66, 27);
			this.AddRadioButton.TabIndex = 0;
			this.AddRadioButton.TabStop = true;
			this.AddRadioButton.Text = "Add";
			this.AddRadioButton.UseVisualStyleBackColor = true;
			this.AddRadioButton.CheckedChanged += new System.EventHandler(this.AddRadioButtonCheckedChanged);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(197, 104);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 26);
			this.label1.TabIndex = 1;
			this.label1.Text = "First Number:";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(197, 158);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 26);
			this.label2.TabIndex = 2;
			this.label2.Text = "Second Number:";
			// 
			// FirstTextBox
			// 
			this.FirstTextBox.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FirstTextBox.Location = new System.Drawing.Point(332, 96);
			this.FirstTextBox.Name = "FirstTextBox";
			this.FirstTextBox.Size = new System.Drawing.Size(100, 26);
			this.FirstTextBox.TabIndex = 3;
			// 
			// SecondTextBox
			// 
			this.SecondTextBox.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SecondTextBox.Location = new System.Drawing.Point(332, 154);
			this.SecondTextBox.Name = "SecondTextBox";
			this.SecondTextBox.Size = new System.Drawing.Size(100, 26);
			this.SecondTextBox.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(319, 208);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 26);
			this.label3.TabIndex = 5;
			this.label3.Text = "=";
			// 
			// AnswerTextBox
			// 
			this.AnswerTextBox.Location = new System.Drawing.Point(332, 264);
			this.AnswerTextBox.Name = "AnswerTextBox";
			this.AnswerTextBox.Size = new System.Drawing.Size(100, 26);
			this.AnswerTextBox.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(197, 263);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 26);
			this.label4.TabIndex = 7;
			this.label4.Text = "Answer:";
			// 
			// ClearButton
			// 
			this.ClearButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ClearButton.Location = new System.Drawing.Point(113, 338);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(75, 26);
			this.ClearButton.TabIndex = 8;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButtonClick);
			// 
			// ExitButton
			// 
			this.ExitButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExitButton.Location = new System.Drawing.Point(269, 338);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(75, 26);
			this.ExitButton.TabIndex = 9;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButtonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(469, 396);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.AnswerTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.SecondTextBox);
			this.Controls.Add(this.FirstTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "MainForm";
			this.Text = "SimpleCalc";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
