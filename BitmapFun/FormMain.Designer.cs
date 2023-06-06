namespace BitmapFun
{
	partial class FormMain
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
			btnFirst = new Button();
			pcbMainViewer = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pcbMainViewer).BeginInit();
			SuspendLayout();
			// 
			// btnFirst
			// 
			btnFirst.Location = new Point(56, 71);
			btnFirst.Name = "btnFirst";
			btnFirst.Size = new Size(75, 23);
			btnFirst.TabIndex = 0;
			btnFirst.Text = "First";
			btnFirst.UseVisualStyleBackColor = true;
			btnFirst.Click += button1_Click;
			// 
			// pcbMainViewer
			// 
			pcbMainViewer.Location = new Point(460, 108);
			pcbMainViewer.Name = "pcbMainViewer";
			pcbMainViewer.Size = new Size(200, 200);
			pcbMainViewer.TabIndex = 1;
			pcbMainViewer.TabStop = false;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(pcbMainViewer);
			Controls.Add(btnFirst);
			Name = "FormMain";
			Text = "Bitmap Fun!";
			((System.ComponentModel.ISupportInitialize)pcbMainViewer).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button btnFirst;
		private PictureBox pcbMainViewer;
	}
}