using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGeneration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string GeneratePassWord(int Length)
        {
            string CharacterSet = BuildCharacterSet();
            if (string.IsNullOrEmpty(CharacterSet))
                throw new ArgumentException("At Least One Character Set Must Be Included.");
            StringBuilder Password = new StringBuilder();
            Random random = new Random();
            for (int Iteration = 0; Iteration < Length ; Iteration++)
            {
                int Index = random.Next(CharacterSet.Length);
                Password.Append(CharacterSet[Index]);
            }
            return Password.ToString();
        }
        private string BuildCharacterSet()
        {
            string CharacterSet = "";
            if (CheckBoxUpperCase.Checked)
            {
                CharacterSet += CheckBoxUpperCase.Tag;
            }
            if (CheckBoxLowerCase.Checked)
            {
                CharacterSet += CheckBoxLowerCase.Tag;
            }
            if (CheckBoxNumbers.Checked)
            {
                CharacterSet += CheckBoxNumbers.Tag;
            }
            if (CheckBoxSpecial.Checked)
            {
                CharacterSet += CheckBoxSpecial.Tag;
            }
            return CharacterSet;
        }
        void PasswordGeneration()
        {
            errorProvider1.Clear();
            if (!CheckBoxUpperCase.Checked && !CheckBoxLowerCase.Checked
                && !CheckBoxNumbers.Checked && !CheckBoxSpecial.Checked)
            {
                errorProvider1.SetError(ButtonPasswordGeneration,
                    "Select At Least One Character Type.");
                return;
            }
            int PasswordLength = TrackBarLength.Value;
            string Password = GeneratePassWord(PasswordLength);
            TextBoxPasswordGeneration.Text = Password;
        }
        private void ButtonPasswordGeneration_Click(object sender, EventArgs e)
        {
            PasswordGeneration();
        }
        private void TrackBarLength_Scroll(object sender, ScrollEventArgs e)
        {
            labelLengthValue.Text = TrackBarLength.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelLengthValue.Text = TrackBarLength.Value.ToString();
            TrackBarLength.Value = 8;
        }
    }
}
