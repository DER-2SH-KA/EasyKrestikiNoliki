namespace EasyKrestikiNoliki
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelfaut = new System.Windows.Forms.Label();
            this.panelField = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelCurrPlayer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelfaut
            // 
            this.labelfaut.AutoSize = true;
            this.labelfaut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelfaut.Location = new System.Drawing.Point(189, 37);
            this.labelfaut.Name = "labelfaut";
            this.labelfaut.Size = new System.Drawing.Size(219, 29);
            this.labelfaut.TabIndex = 0;
            this.labelfaut.Text = "Крестики-Нолики";
            this.labelfaut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelField
            // 
            this.panelField.Location = new System.Drawing.Point(135, 80);
            this.panelField.Name = "panelField";
            this.panelField.Size = new System.Drawing.Size(300, 300);
            this.panelField.TabIndex = 1;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(398, 386);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(162, 34);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Перезапуск";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelCurrPlayer
            // 
            this.labelCurrPlayer.AutoSize = true;
            this.labelCurrPlayer.Location = new System.Drawing.Point(191, 400);
            this.labelCurrPlayer.Name = "labelCurrPlayer";
            this.labelCurrPlayer.Size = new System.Drawing.Size(72, 13);
            this.labelCurrPlayer.TabIndex = 3;
            this.labelCurrPlayer.Text = "Ходит игрок:";
            this.labelCurrPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.labelCurrPlayer);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.panelField);
            this.Controls.Add(this.labelfaut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "Крестики-Нолики";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelfaut;
        private System.Windows.Forms.Panel panelField;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelCurrPlayer;
    }
}

