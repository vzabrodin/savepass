using System;
using System.Drawing;
using System.Windows.Forms;

namespace SavePass.Controls
{
	public class PlaceHolderTextBox : TextBox
	{
		public bool IsPlaceHolder { get; private set; } = true;
		string _placeHolderText;
		public string PlaceHolderText
		{
			get { return _placeHolderText; }
			set
			{
				_placeHolderText = value;
				setPlaceholder();
			}
		}

		//when the control loses focus, the placeholder is shown
		private void setPlaceholder()
		{
			if (string.IsNullOrEmpty(this.Text))
			{
				IsPlaceHolder = true;
				this.Text = PlaceHolderText;
				this.ForeColor = Color.Gray;
				this.Font = new Font(this.Font, FontStyle.Regular);
			}
		}

		//when the control is focused, the placeholder is removed
		private void removePlaceHolder()
		{
			if (IsPlaceHolder)
			{
				this.Text = "";
				this.ForeColor = System.Drawing.SystemColors.WindowText;
				this.Font = new Font(this.Font, FontStyle.Regular);
				IsPlaceHolder = false;
			}
		}
		public PlaceHolderTextBox()
		{
			GotFocus += removePlaceHolder;
			LostFocus += setPlaceholder;
		}

		private void setPlaceholder(object sender, EventArgs e)
		{
			setPlaceholder();
		}

		private void removePlaceHolder(object sender, EventArgs e)
		{
			removePlaceHolder();
		}
	}
}