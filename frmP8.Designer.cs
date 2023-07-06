
namespace ProjetoQuiz
{
    partial class frmP8
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
            this.btnProx = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rbtnCerta = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProx
            // 
            this.btnProx.Location = new System.Drawing.Point(569, 432);
            this.btnProx.Name = "btnProx";
            this.btnProx.Size = new System.Drawing.Size(114, 36);
            this.btnProx.TabIndex = 0;
            this.btnProx.Text = "Próximo";
            this.btnProx.UseVisualStyleBackColor = true;
            this.btnProx.Click += new System.EventHandler(this.btnProx_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.rbtnCerta);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(83, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 241);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(195, 102);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(154, 28);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Road To Street";
            this.radioButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(195, 148);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(185, 28);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "The Marjority Guys";
            this.radioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rbtnCerta
            // 
            this.rbtnCerta.AutoSize = true;
            this.rbtnCerta.Location = new System.Drawing.Point(195, 182);
            this.rbtnCerta.Name = "rbtnCerta";
            this.rbtnCerta.Size = new System.Drawing.Size(151, 28);
            this.rbtnCerta.TabIndex = 4;
            this.rbtnCerta.TabStop = true;
            this.rbtnCerta.Text = "The Jackson 5";
            this.rbtnCerta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtnCerta.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(195, 50);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(131, 28);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "InvisibleFive";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(698, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Qual é o nome do grupo musical no qual Michael Jackson começou sua carreira?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmP8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.btnProx);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmP8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmP8";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rbtnCerta;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
    }
}