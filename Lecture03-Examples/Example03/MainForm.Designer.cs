namespace Example03
{
    partial class MainForm
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
            this.weatherDataPanel = new System.Windows.Forms.Panel();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.weatherDataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // weatherDataPanel
            // 
            this.weatherDataPanel.Controls.Add(this.pressureLabel);
            this.weatherDataPanel.Controls.Add(this.humidityLabel);
            this.weatherDataPanel.Controls.Add(this.temperatureLabel);
            this.weatherDataPanel.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.weatherDataPanel.Location = new System.Drawing.Point(63, 65);
            this.weatherDataPanel.Name = "weatherDataPanel";
            this.weatherDataPanel.Size = new System.Drawing.Size(764, 322);
            this.weatherDataPanel.TabIndex = 0;
            // 
            // pressureLabel
            // 
            this.pressureLabel.AutoSize = true;
            this.pressureLabel.Location = new System.Drawing.Point(77, 205);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(93, 35);
            this.pressureLabel.TabIndex = 2;
            this.pressureLabel.Text = "壓力:0";
            // 
            // humidityLabel
            // 
            this.humidityLabel.AutoSize = true;
            this.humidityLabel.Location = new System.Drawing.Point(77, 119);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(93, 35);
            this.humidityLabel.TabIndex = 1;
            this.humidityLabel.Text = "濕度:0";
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(77, 43);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(93, 35);
            this.temperatureLabel.TabIndex = 0;
            this.temperatureLabel.Text = "溫度:0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 456);
            this.Controls.Add(this.weatherDataPanel);
            this.Name = "MainForm";
            this.Text = "不準確觀測站";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.weatherDataPanel.ResumeLayout(false);
            this.weatherDataPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel weatherDataPanel;
        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Label temperatureLabel;
    }
}

