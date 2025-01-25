using System;
using System.Windows.Forms;

namespace ConvertNumberToPersianWord
{
    public partial class FrmConvertNumberToWord : Form
    {
        bool isEn = true;
        public FrmConvertNumberToWord()
        {
            InitializeComponent();
        }

        private void rbFa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFa.Checked)
            {
                isEn = false;

                label1.Text = "عدد را وارد کنید :";
                btnSubmit.Text = "! ثبت";
            }
            else
            {
                isEn = true;

                label1.Text = "Enter Number :";
                btnSubmit.Text = "Submit !";
            }
            if (!string.IsNullOrEmpty(txtNumber.Text) || !string.IsNullOrWhiteSpace(txtNumber.Text))
            {
                if (isEn)
                {
                    txtNumberWord.Text = ConvertNumberToPersianWord.NumberToText(Int64.Parse(txtNumber.Text), Language.English);
                }
                else
                {
                    txtNumberWord.Text = ConvertNumberToPersianWord.NumberToText(Int64.Parse(txtNumber.Text), Language.Persian);
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNumber.Text) || !string.IsNullOrWhiteSpace(txtNumber.Text))
            {
                if (isEn)
                {
                    txtNumberWord.Text = ConvertNumberToPersianWord.NumberToText(Int64.Parse(txtNumber.Text), Language.English);
                }
                else
                {
                    txtNumberWord.Text = ConvertNumberToPersianWord.NumberToText(Int64.Parse(txtNumber.Text), Language.Persian);
                }
            }
            else
            {
                if (isEn)
                    MessageBox.Show("Please Some Enter Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(".لطفا عددی وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
