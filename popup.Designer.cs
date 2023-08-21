namespace Recran
{
    partial class popup
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
            this.ok = new MaterialSkin.Controls.MaterialButton();
            this.t_panel = new System.Windows.Forms.Panel();
            this.text = new MaterialSkin.Controls.MaterialLabel();
            this.t_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ok
            // 
            this.ok.AutoEllipsis = true;
            this.ok.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ok.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ok.Depth = 0;
            this.ok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ok.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ok.HighEmphasis = true;
            this.ok.Icon = global::Recran.Properties.Resources.oie_25162057zlc96v0;
            this.ok.ImageKey = "(none)";
            this.ok.Location = new System.Drawing.Point(411, 24);
            this.ok.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ok.MouseState = MaterialSkin.MouseState.HOVER;
            this.ok.Name = "ok";
            this.ok.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ok.Size = new System.Drawing.Size(42, 74);
            this.ok.TabIndex = 5;
            this.ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ok.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ok.UseAccentColor = false;
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click_1);
            // 
            // t_panel
            // 
            this.t_panel.Controls.Add(this.text);
            this.t_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.t_panel.Location = new System.Drawing.Point(3, 24);
            this.t_panel.Name = "t_panel";
            this.t_panel.Size = new System.Drawing.Size(408, 74);
            this.t_panel.TabIndex = 4;
            // 
            // text
            // 
            this.text.Depth = 0;
            this.text.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.text.Location = new System.Drawing.Point(13, 15);
            this.text.MouseState = MaterialSkin.MouseState.HOVER;
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(375, 59);
            this.text.TabIndex = 0;
            this.text.Text = "You can now close this popup using both cross on top rigth and  ok button at rigt" +
    "h";
            // 
            // popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 101);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.t_panel);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "popup";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "popup";
            this.TopMost = true;
            this.t_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton ok;
        private System.Windows.Forms.Panel t_panel;
        private MaterialSkin.Controls.MaterialLabel text;
    }
}