namespace message
{
    partial class Dialog
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
            this.TB_Dialog = new System.Windows.Forms.TextBox();
            this.BT_Send = new System.Windows.Forms.Button();
            this.TB_Message = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_Dialog
            // 
            this.TB_Dialog.Location = new System.Drawing.Point(12, 12);
            this.TB_Dialog.Multiline = true;
            this.TB_Dialog.Name = "TB_Dialog";
            this.TB_Dialog.ReadOnly = true;
            this.TB_Dialog.Size = new System.Drawing.Size(391, 317);
            this.TB_Dialog.TabIndex = 0;
            // 
            // BT_Send
            // 
            this.BT_Send.Location = new System.Drawing.Point(162, 415);
            this.BT_Send.Name = "BT_Send";
            this.BT_Send.Size = new System.Drawing.Size(75, 23);
            this.BT_Send.TabIndex = 1;
            this.BT_Send.Text = "Отправить";
            this.BT_Send.UseVisualStyleBackColor = true;
            this.BT_Send.Click += new System.EventHandler(this.BT_Send_Click);
            // 
            // TB_Message
            // 
            this.TB_Message.Location = new System.Drawing.Point(115, 356);
            this.TB_Message.Multiline = true;
            this.TB_Message.Name = "TB_Message";
            this.TB_Message.Size = new System.Drawing.Size(288, 20);
            this.TB_Message.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ваше сообщение:";
            // 
            // Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Message);
            this.Controls.Add(this.BT_Send);
            this.Controls.Add(this.TB_Dialog);
            this.Name = "Dialog";
            this.Text = "Чат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Dialog;
        private System.Windows.Forms.Button BT_Send;
        private System.Windows.Forms.TextBox TB_Message;
        private System.Windows.Forms.Label label1;
    }
}