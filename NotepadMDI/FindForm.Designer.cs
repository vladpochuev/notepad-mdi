using System.ComponentModel;

namespace NotepadMDI
{
    partial class FindForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxMatchCase = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxMatchWholeWord = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            //
            // textBoxFind
            //
            this.textBoxFind.Location = new System.Drawing.Point(12, 12);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(216, 20);
            this.textBoxFind.TabIndex = 0;
            //
            // buttonOk
            //
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(245, 12);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(57, 20);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            //
            // buttonCancel
            //
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(245, 38);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(57, 20);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            //
            // checkBoxMatchCase
            //
            this.checkBoxMatchCase.Location = new System.Drawing.Point(12, 38);
            this.checkBoxMatchCase.Name = "checkBoxMatchCase";
            this.checkBoxMatchCase.Size = new System.Drawing.Size(14, 20);
            this.checkBoxMatchCase.TabIndex = 2;
            this.checkBoxMatchCase.Text = "checkBox1";
            this.checkBoxMatchCase.UseVisualStyleBackColor = true;
            //
            // label1
            //
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Match case";
            //
            // label2
            //
            this.label2.Location = new System.Drawing.Point(126, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Match whole word";
            //
            // checkBoxMatchWholeWord
            //
            this.checkBoxMatchWholeWord.Location = new System.Drawing.Point(106, 38);
            this.checkBoxMatchWholeWord.Name = "checkBoxMatchWholeWord";
            this.checkBoxMatchWholeWord.Size = new System.Drawing.Size(14, 20);
            this.checkBoxMatchWholeWord.TabIndex = 3;
            this.checkBoxMatchWholeWord.Text = "checkBox2";
            this.checkBoxMatchWholeWord.UseVisualStyleBackColor = true;
            //
            // FindForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 73);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxMatchWholeWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxMatchCase);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FindForm";
            this.Text = "Find";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.CheckBox checkBoxMatchCase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxMatchWholeWord;

        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;

        #endregion
    }
}