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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.oDown = new System.Windows.Forms.RadioButton();
            this.oUp = new System.Windows.Forms.RadioButton();
            this.chkMatchCase = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find what:";
            //
            // txtFind
            //
            this.txtFind.Location = new System.Drawing.Point(87, 22);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(161, 20);
            this.txtFind.TabIndex = 1;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            //
            // btnFindNext
            //
            this.btnFindNext.Enabled = false;
            this.btnFindNext.Location = new System.Drawing.Point(279, 21);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(64, 20);
            this.btnFindNext.TabIndex = 2;
            this.btnFindNext.Text = "Find Next";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            //
            // btnCancel
            //
            this.btnCancel.Location = new System.Drawing.Point(279, 62);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 20);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            //
            // groupBox1
            //
            this.groupBox1.Controls.Add(this.oDown);
            this.groupBox1.Controls.Add(this.oUp);
            this.groupBox1.Location = new System.Drawing.Point(109, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 39);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction";
            //
            // oDown
            //
            this.oDown.Checked = true;
            this.oDown.Location = new System.Drawing.Point(65, 16);
            this.oDown.Name = "oDown";
            this.oDown.Size = new System.Drawing.Size(56, 20);
            this.oDown.TabIndex = 1;
            this.oDown.TabStop = true;
            this.oDown.Text = "Down";
            this.oDown.UseVisualStyleBackColor = true;
            //
            // oUp
            //
            this.oUp.Location = new System.Drawing.Point(16, 16);
            this.oUp.Name = "oUp";
            this.oUp.Size = new System.Drawing.Size(43, 20);
            this.oUp.TabIndex = 0;
            this.oUp.Text = "Up";
            this.oUp.UseVisualStyleBackColor = true;
            //
            // chkMatchCase
            //
            this.chkMatchCase.Location = new System.Drawing.Point(12, 74);
            this.chkMatchCase.Name = "chkMatchCase";
            this.chkMatchCase.Size = new System.Drawing.Size(91, 24);
            this.chkMatchCase.TabIndex = 5;
            this.chkMatchCase.Text = "Match Case";
            this.chkMatchCase.UseVisualStyleBackColor = true;
            //
            // FindForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(358, 113);
            this.Controls.Add(this.chkMatchCase);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "FindForm";
            this.Text = "Find";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.RadioButton oDown;

        private System.Windows.Forms.RadioButton oUp;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkMatchCase;

        #endregion
    }
}