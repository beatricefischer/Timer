namespace Stoppuhr
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this._elapsedTimeLabel = new System.Windows.Forms.Label();
            this.buttonTimer = new System.Windows.Forms.Button();
            this._info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(65, 41);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(162, 46);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start / Stop Stoppuhr";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(65, 116);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // _elapsedTimeLabel
            // 
            this._elapsedTimeLabel.AutoSize = true;
            this._elapsedTimeLabel.Location = new System.Drawing.Point(71, 174);
            this._elapsedTimeLabel.Name = "_elapsedTimeLabel";
            this._elapsedTimeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._elapsedTimeLabel.Size = new System.Drawing.Size(0, 17);
            this._elapsedTimeLabel.TabIndex = 3;
            // 
            // buttonTimer
            // 
            this.buttonTimer.Location = new System.Drawing.Point(436, 41);
            this.buttonTimer.Name = "buttonTimer";
            this.buttonTimer.Size = new System.Drawing.Size(123, 49);
            this.buttonTimer.TabIndex = 4;
            this.buttonTimer.Text = "Start Timer";
            this.buttonTimer.UseVisualStyleBackColor = true;
            this.buttonTimer.Click += new System.EventHandler(this.buttonTimer_Click);
            // 
            // _info
            // 
            this._info.AutoSize = true;
            this._info.Location = new System.Drawing.Point(433, 93);
            this._info.Name = "_info";
            this._info.Size = new System.Drawing.Size(126, 17);
            this._info.TabIndex = 5;
            this._info.Text = "5-Sekunden-Timer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._info);
            this.Controls.Add(this.buttonTimer);
            this.Controls.Add(this._elapsedTimeLabel);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label _elapsedTimeLabel;
        
        
        private System.Windows.Forms.Button buttonTimer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label _info;
    }
}

