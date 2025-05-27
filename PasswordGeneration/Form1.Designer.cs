namespace PasswordGeneration
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.TextBoxPasswordGeneration = new Guna.UI2.WinForms.Guna2TextBox();
            this.CheckBoxUpperCase = new Guna.UI2.WinForms.Guna2CheckBox();
            this.CheckBoxLowerCase = new Guna.UI2.WinForms.Guna2CheckBox();
            this.CheckBoxNumbers = new Guna.UI2.WinForms.Guna2CheckBox();
            this.CheckBoxSpecial = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ButtonPasswordGeneration = new Guna.UI2.WinForms.Guna2Button();
            this.TrackBarLength = new Guna.UI2.WinForms.Guna2TrackBar();
            this.labelLengthValue = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxPasswordGeneration
            // 
            this.TextBoxPasswordGeneration.BorderColor = System.Drawing.Color.Blue;
            this.TextBoxPasswordGeneration.BorderRadius = 10;
            this.TextBoxPasswordGeneration.BorderThickness = 2;
            this.TextBoxPasswordGeneration.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPasswordGeneration.DefaultText = "";
            this.TextBoxPasswordGeneration.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxPasswordGeneration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxPasswordGeneration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPasswordGeneration.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPasswordGeneration.FillColor = System.Drawing.Color.PaleTurquoise;
            this.TextBoxPasswordGeneration.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPasswordGeneration.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPasswordGeneration.ForeColor = System.Drawing.Color.Black;
            this.TextBoxPasswordGeneration.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPasswordGeneration.Location = new System.Drawing.Point(223, 261);
            this.TextBoxPasswordGeneration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxPasswordGeneration.Name = "TextBoxPasswordGeneration";
            this.TextBoxPasswordGeneration.PasswordChar = '\0';
            this.TextBoxPasswordGeneration.PlaceholderText = "";
            this.TextBoxPasswordGeneration.SelectedText = "";
            this.TextBoxPasswordGeneration.Size = new System.Drawing.Size(631, 60);
            this.TextBoxPasswordGeneration.TabIndex = 0;
            // 
            // CheckBoxUpperCase
            // 
            this.CheckBoxUpperCase.AutoSize = true;
            this.CheckBoxUpperCase.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBoxUpperCase.CheckedState.BorderRadius = 0;
            this.CheckBoxUpperCase.CheckedState.BorderThickness = 0;
            this.CheckBoxUpperCase.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBoxUpperCase.Location = new System.Drawing.Point(36, 51);
            this.CheckBoxUpperCase.Name = "CheckBoxUpperCase";
            this.CheckBoxUpperCase.Size = new System.Drawing.Size(116, 24);
            this.CheckBoxUpperCase.TabIndex = 1;
            this.CheckBoxUpperCase.Tag = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            this.CheckBoxUpperCase.Text = "UpperCase";
            this.CheckBoxUpperCase.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CheckBoxUpperCase.UncheckedState.BorderRadius = 0;
            this.CheckBoxUpperCase.UncheckedState.BorderThickness = 0;
            this.CheckBoxUpperCase.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // CheckBoxLowerCase
            // 
            this.CheckBoxLowerCase.AutoSize = true;
            this.CheckBoxLowerCase.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBoxLowerCase.CheckedState.BorderRadius = 0;
            this.CheckBoxLowerCase.CheckedState.BorderThickness = 0;
            this.CheckBoxLowerCase.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBoxLowerCase.Location = new System.Drawing.Point(37, 109);
            this.CheckBoxLowerCase.Name = "CheckBoxLowerCase";
            this.CheckBoxLowerCase.Size = new System.Drawing.Size(115, 24);
            this.CheckBoxLowerCase.TabIndex = 2;
            this.CheckBoxLowerCase.Tag = "abcdefghijklmnopqrstuvwxyz";
            this.CheckBoxLowerCase.Text = "LowerCase";
            this.CheckBoxLowerCase.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CheckBoxLowerCase.UncheckedState.BorderRadius = 0;
            this.CheckBoxLowerCase.UncheckedState.BorderThickness = 0;
            this.CheckBoxLowerCase.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // CheckBoxNumbers
            // 
            this.CheckBoxNumbers.AutoSize = true;
            this.CheckBoxNumbers.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBoxNumbers.CheckedState.BorderRadius = 0;
            this.CheckBoxNumbers.CheckedState.BorderThickness = 0;
            this.CheckBoxNumbers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBoxNumbers.Location = new System.Drawing.Point(207, 51);
            this.CheckBoxNumbers.Name = "CheckBoxNumbers";
            this.CheckBoxNumbers.Size = new System.Drawing.Size(99, 24);
            this.CheckBoxNumbers.TabIndex = 3;
            this.CheckBoxNumbers.Tag = "0123456789";
            this.CheckBoxNumbers.Text = "Numbers";
            this.CheckBoxNumbers.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CheckBoxNumbers.UncheckedState.BorderRadius = 0;
            this.CheckBoxNumbers.UncheckedState.BorderThickness = 0;
            this.CheckBoxNumbers.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // CheckBoxSpecial
            // 
            this.CheckBoxSpecial.AutoSize = true;
            this.CheckBoxSpecial.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBoxSpecial.CheckedState.BorderRadius = 0;
            this.CheckBoxSpecial.CheckedState.BorderThickness = 0;
            this.CheckBoxSpecial.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBoxSpecial.Location = new System.Drawing.Point(207, 109);
            this.CheckBoxSpecial.Name = "CheckBoxSpecial";
            this.CheckBoxSpecial.Size = new System.Drawing.Size(87, 24);
            this.CheckBoxSpecial.TabIndex = 4;
            this.CheckBoxSpecial.Tag = "!@#$%^&*()-_=+<>?";
            this.CheckBoxSpecial.Text = "Special";
            this.CheckBoxSpecial.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CheckBoxSpecial.UncheckedState.BorderRadius = 0;
            this.CheckBoxSpecial.UncheckedState.BorderThickness = 0;
            this.CheckBoxSpecial.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // ButtonPasswordGeneration
            // 
            this.ButtonPasswordGeneration.BorderRadius = 10;
            this.ButtonPasswordGeneration.BorderThickness = 3;
            this.ButtonPasswordGeneration.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonPasswordGeneration.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonPasswordGeneration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonPasswordGeneration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonPasswordGeneration.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPasswordGeneration.ForeColor = System.Drawing.Color.Black;
            this.ButtonPasswordGeneration.Location = new System.Drawing.Point(622, 491);
            this.ButtonPasswordGeneration.Name = "ButtonPasswordGeneration";
            this.ButtonPasswordGeneration.Size = new System.Drawing.Size(232, 158);
            this.ButtonPasswordGeneration.TabIndex = 5;
            this.ButtonPasswordGeneration.Text = "Generation Password";
            this.ButtonPasswordGeneration.Click += new System.EventHandler(this.ButtonPasswordGeneration_Click);
            // 
            // TrackBarLength
            // 
            this.TrackBarLength.FillColor = System.Drawing.Color.Black;
            this.TrackBarLength.Location = new System.Drawing.Point(223, 620);
            this.TrackBarLength.Maximum = 32;
            this.TrackBarLength.Minimum = 8;
            this.TrackBarLength.Name = "TrackBarLength";
            this.TrackBarLength.Size = new System.Drawing.Size(312, 29);
            this.TrackBarLength.TabIndex = 6;
            this.TrackBarLength.ThumbColor = System.Drawing.Color.Yellow;
            this.TrackBarLength.Value = 8;
            this.TrackBarLength.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TrackBarLength_Scroll);
            // 
            // labelLengthValue
            // 
            this.labelLengthValue.AutoSize = true;
            this.labelLengthValue.BackColor = System.Drawing.Color.Gold;
            this.labelLengthValue.Font = new System.Drawing.Font("Ravie", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLengthValue.Location = new System.Drawing.Point(553, 622);
            this.labelLengthValue.Name = "labelLengthValue";
            this.labelLengthValue.Size = new System.Drawing.Size(28, 27);
            this.labelLengthValue.TabIndex = 8;
            this.labelLengthValue.Text = "0";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.guna2Panel1.Controls.Add(this.CheckBoxNumbers);
            this.guna2Panel1.Controls.Add(this.CheckBoxUpperCase);
            this.guna2Panel1.Controls.Add(this.CheckBoxLowerCase);
            this.guna2Panel1.Controls.Add(this.CheckBoxSpecial);
            this.guna2Panel1.Location = new System.Drawing.Point(223, 382);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(371, 171);
            this.guna2Panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Password Type ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.CadetBlue;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(637, 43);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password Generation";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkCyan;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 572);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password Length";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::PasswordGeneration.Properties.Resources.Vector_2;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(392, 25);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(274, 116);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 15;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1132, 750);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.labelLengthValue);
            this.Controls.Add(this.TrackBarLength);
            this.Controls.Add(this.ButtonPasswordGeneration);
            this.Controls.Add(this.TextBoxPasswordGeneration);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox TextBoxPasswordGeneration;
        private Guna.UI2.WinForms.Guna2CheckBox CheckBoxUpperCase;
        private Guna.UI2.WinForms.Guna2CheckBox CheckBoxLowerCase;
        private Guna.UI2.WinForms.Guna2CheckBox CheckBoxNumbers;
        private Guna.UI2.WinForms.Guna2CheckBox CheckBoxSpecial;
        private Guna.UI2.WinForms.Guna2Button ButtonPasswordGeneration;
        private Guna.UI2.WinForms.Guna2TrackBar TrackBarLength;
        private System.Windows.Forms.Label labelLengthValue;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

