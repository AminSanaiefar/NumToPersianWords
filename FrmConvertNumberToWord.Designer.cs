namespace ConvertNumberToPersianWord
{
    partial class FrmConvertNumberToWord
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.txtNumberWord = new System.Windows.Forms.TextBox();
            this.rbEn = new System.Windows.Forms.RadioButton();
            this.rbFa = new System.Windows.Forms.RadioButton();
            this.txtNumber = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Number :";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Appearance.Options.UseFont = true;
            this.btnSubmit.Location = new System.Drawing.Point(12, 45);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(427, 40);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit !";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtNumberWord
            // 
            this.txtNumberWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumberWord.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtNumberWord.Location = new System.Drawing.Point(12, 91);
            this.txtNumberWord.Multiline = true;
            this.txtNumberWord.Name = "txtNumberWord";
            this.txtNumberWord.Size = new System.Drawing.Size(427, 87);
            this.txtNumberWord.TabIndex = 3;
            // 
            // rbEn
            // 
            this.rbEn.AutoSize = true;
            this.rbEn.Checked = true;
            this.rbEn.Location = new System.Drawing.Point(16, 184);
            this.rbEn.Name = "rbEn";
            this.rbEn.Size = new System.Drawing.Size(38, 17);
            this.rbEn.TabIndex = 4;
            this.rbEn.TabStop = true;
            this.rbEn.Text = "En";
            this.rbEn.UseVisualStyleBackColor = true;
            // 
            // rbFa
            // 
            this.rbFa.AutoSize = true;
            this.rbFa.Location = new System.Drawing.Point(60, 184);
            this.rbFa.Name = "rbFa";
            this.rbFa.Size = new System.Drawing.Size(37, 17);
            this.rbFa.TabIndex = 4;
            this.rbFa.Text = "Fa";
            this.rbFa.UseVisualStyleBackColor = true;
            this.rbFa.CheckedChanged += new System.EventHandler(this.rbFa_CheckedChanged);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(150, 15);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Properties.Appearance.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtNumber.Properties.Appearance.Options.UseFont = true;
            this.txtNumber.Properties.BeepOnError = true;
            this.txtNumber.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtNumber.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtNumber.Properties.MaskSettings.Set("mask", "d");
            this.txtNumber.Properties.MaskSettings.Set("valueAfterDelete", DevExpress.Data.Mask.NumericMaskManager.ValueAfterDelete.Null);
            this.txtNumber.Properties.MaskSettings.Set("valueType", typeof(long));
            this.txtNumber.Properties.MaskSettings.Set("autoHideDecimalSeparator", false);
            this.txtNumber.Properties.MaskSettings.Set("hideInsignificantZeros", false);
            this.txtNumber.Size = new System.Drawing.Size(289, 24);
            this.txtNumber.TabIndex = 5;
            // 
            // FrmConvertNumberToWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 208);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.rbFa);
            this.Controls.Add(this.rbEn);
            this.Controls.Add(this.txtNumberWord);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmConvertNumberToWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConvertNumberToWord";
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private System.Windows.Forms.TextBox txtNumberWord;
        private System.Windows.Forms.RadioButton rbEn;
        private System.Windows.Forms.RadioButton rbFa;
        private DevExpress.XtraEditors.TextEdit txtNumber;
    }
}