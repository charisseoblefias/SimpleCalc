/*
 * Created by SharpDevelop.
 * User: Charisse Oblefias
 * Date: 6/5/2021
 * Time: 5:39 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleCalc
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void AddRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			int first, second, sum;
			
			if (int.TryParse(FirstTextBox.Text, out first))
			{
				if (int.TryParse(SecondTextBox.Text, out second))
				{
					sum = first + second;
					AnswerTextBox.Text = sum.ToString();
				}
				else
				{
					MessageBox.Show("The data in Second Number is invalid.");
				}
			}
			else
			{
				MessageBox.Show("The data in First Number is invalid.");
			}
		}
		void SubtractRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			int first, second, difference;
			
			if (int.TryParse(FirstTextBox.Text, out first))
			{
				if (int.TryParse(SecondTextBox.Text, out second))
				{
					difference = first - second;
					AnswerTextBox.Text = difference.ToString();
				}
				else
				{
					MessageBox.Show("The data in Second Number is invalid.");
				}
			}
			else
			{
				MessageBox.Show("The data in First Number is invalid.");
			}
		}
		void MultiplyRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			int first, second, product;
			
			if (int.TryParse(FirstTextBox.Text, out first))
			{
				if (int.TryParse(SecondTextBox.Text, out second))
				{
					product = first * second;
					AnswerTextBox.Text = product.ToString();
				}
				else
				{
					MessageBox.Show("The data in Second Number is invalid.");
				}
			}
			else
			{
				MessageBox.Show("The data in First Number is invalid.");
			}
		}
		void DivideRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			int first, second, quotient;
			
			if (int.TryParse(FirstTextBox.Text, out first))
			{
				if (int.TryParse(SecondTextBox.Text, out second))
				{
					quotient = first / second;
					AnswerTextBox.Text = quotient.ToString();
				}
				else
				{
					MessageBox.Show("The data in Second Number is invalid.");
				}
			}
			else
			{
				MessageBox.Show("The data in First Number is invalid.");
			}
		}
		void ClearButtonClick(object sender, EventArgs e)
		{
			AddRadioButton.Checked = false;
			SubtractRadioButton.Checked = false;
			MultiplyRadioButton.Checked = false;
			DivideRadioButton.Checked = false;
			FirstTextBox.Clear();
			SecondTextBox.Clear();
			AnswerTextBox.Clear();
		}
		void ExitButtonClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		}
	}
