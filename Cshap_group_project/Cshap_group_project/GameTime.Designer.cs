namespace Cshap_group_project
{
    partial class GameTime
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
            components = new System.ComponentModel.Container();
            Game_Time = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Game_Time
            // 
            Game_Time.AutoSize = true;
            Game_Time.Location = new System.Drawing.Point(214, 184);
            Game_Time.Name = "Game_Time";
            Game_Time.Size = new System.Drawing.Size(50, 20);
            Game_Time.TabIndex = 0;
            Game_Time.Text = "label1";
            // 
            // GameTime
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(Game_Time);
            Name = "GameTime";
            Text = "GameTime";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label Game_Time;
        private System.Windows.Forms.Timer timer1;
    }
}