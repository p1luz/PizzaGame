
namespace PizzaGame
{
    partial class frmTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTurno));
            this.cmdMangia = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.radio1pizza = new System.Windows.Forms.RadioButton();
            this.radio2pizze = new System.Windows.Forms.RadioButton();
            this.radio3pizze = new System.Windows.Forms.RadioButton();
            this.cmdSaltaTurno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdMangia
            // 
            this.cmdMangia.Location = new System.Drawing.Point(208, 173);
            this.cmdMangia.Name = "cmdMangia";
            this.cmdMangia.Size = new System.Drawing.Size(84, 70);
            this.cmdMangia.TabIndex = 1;
            this.cmdMangia.Text = "Mangia!";
            this.cmdMangia.UseVisualStyleBackColor = true;
            this.cmdMangia.Click += new System.EventHandler(this.cmdMangia_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Enabled = false;
            this.txtInfo.Location = new System.Drawing.Point(38, 24);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(393, 95);
            this.txtInfo.TabIndex = 2;
            this.txtInfo.TabStop = false;
            // 
            // radio1pizza
            // 
            this.radio1pizza.AutoSize = true;
            this.radio1pizza.Location = new System.Drawing.Point(72, 170);
            this.radio1pizza.Name = "radio1pizza";
            this.radio1pizza.Size = new System.Drawing.Size(75, 21);
            this.radio1pizza.TabIndex = 3;
            this.radio1pizza.TabStop = true;
            this.radio1pizza.Text = "1 Pizza";
            this.radio1pizza.UseVisualStyleBackColor = true;
            // 
            // radio2pizze
            // 
            this.radio2pizze.AutoSize = true;
            this.radio2pizze.Location = new System.Drawing.Point(72, 198);
            this.radio2pizze.Name = "radio2pizze";
            this.radio2pizze.Size = new System.Drawing.Size(75, 21);
            this.radio2pizze.TabIndex = 4;
            this.radio2pizze.TabStop = true;
            this.radio2pizze.Text = "2 Pizze";
            this.radio2pizze.UseVisualStyleBackColor = true;
            // 
            // radio3pizze
            // 
            this.radio3pizze.AutoSize = true;
            this.radio3pizze.Location = new System.Drawing.Point(72, 226);
            this.radio3pizze.Name = "radio3pizze";
            this.radio3pizze.Size = new System.Drawing.Size(75, 21);
            this.radio3pizze.TabIndex = 5;
            this.radio3pizze.TabStop = true;
            this.radio3pizze.Text = "3 Pizze";
            this.radio3pizze.UseVisualStyleBackColor = true;
            // 
            // cmdSaltaTurno
            // 
            this.cmdSaltaTurno.Enabled = false;
            this.cmdSaltaTurno.Location = new System.Drawing.Point(347, 170);
            this.cmdSaltaTurno.Name = "cmdSaltaTurno";
            this.cmdSaltaTurno.Size = new System.Drawing.Size(84, 70);
            this.cmdSaltaTurno.TabIndex = 6;
            this.cmdSaltaTurno.Text = "Salta turno!";
            this.cmdSaltaTurno.UseVisualStyleBackColor = true;
            this.cmdSaltaTurno.Click += new System.EventHandler(this.cmdSaltaTurno_Click);
            // 
            // frmTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 303);
            this.ControlBox = false;
            this.Controls.Add(this.cmdSaltaTurno);
            this.Controls.Add(this.radio3pizze);
            this.Controls.Add(this.radio2pizze);
            this.Controls.Add(this.radio1pizza);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.cmdMangia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quante pizze vuoi mangiare?";
            this.Load += new System.EventHandler(this.frmTurno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdMangia;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.RadioButton radio1pizza;
        private System.Windows.Forms.RadioButton radio2pizze;
        private System.Windows.Forms.RadioButton radio3pizze;
        private System.Windows.Forms.Button cmdSaltaTurno;
    }
}