namespace Recran
{
    partial class fp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fp));
            this.screen_list = new MaterialSkin.Controls.MaterialComboBox();
            this.header = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.record_activ = new MaterialSkin.Controls.MaterialCheckbox();
            this.screenshot = new MaterialSkin.Controls.MaterialButton();
            this.preview_group = new System.Windows.Forms.GroupBox();
            this.preview = new System.Windows.Forms.PictureBox();
            this.footer = new System.Windows.Forms.Panel();
            this.recaudio = new MaterialSkin.Controls.MaterialCheckbox();
            this.header.SuspendLayout();
            this.panel2.SuspendLayout();
            this.preview_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).BeginInit();
            this.footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // screen_list
            // 
            this.screen_list.AutoResize = false;
            this.screen_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.screen_list.Depth = 0;
            this.screen_list.Dock = System.Windows.Forms.DockStyle.Left;
            this.screen_list.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.screen_list.DropDownHeight = 174;
            this.screen_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.screen_list.DropDownWidth = 121;
            this.screen_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.screen_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.screen_list.FormattingEnabled = true;
            this.screen_list.Hint = "Screen to record";
            this.screen_list.IntegralHeight = false;
            this.screen_list.ItemHeight = 43;
            this.screen_list.Location = new System.Drawing.Point(0, 0);
            this.screen_list.MaxDropDownItems = 4;
            this.screen_list.MouseState = MaterialSkin.MouseState.OUT;
            this.screen_list.Name = "screen_list";
            this.screen_list.Size = new System.Drawing.Size(355, 49);
            this.screen_list.StartIndex = 0;
            this.screen_list.TabIndex = 0;
            this.screen_list.SelectedIndexChanged += new System.EventHandler(this.screen_list_SelectedIndexChanged);
            // 
            // header
            // 
            this.header.Controls.Add(this.panel2);
            this.header.Controls.Add(this.screen_list);
            this.header.Dock = System.Windows.Forms.DockStyle.Left;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(593, 56);
            this.header.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.record_activ);
            this.panel2.Controls.Add(this.screenshot);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(355, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 56);
            this.panel2.TabIndex = 1;
            // 
            // record_activ
            // 
            this.record_activ.AutoSize = true;
            this.record_activ.Depth = 0;
            this.record_activ.Dock = System.Windows.Forms.DockStyle.Right;
            this.record_activ.Enabled = false;
            this.record_activ.Location = new System.Drawing.Point(154, 0);
            this.record_activ.Margin = new System.Windows.Forms.Padding(0);
            this.record_activ.MouseLocation = new System.Drawing.Point(-1, -1);
            this.record_activ.MouseState = MaterialSkin.MouseState.HOVER;
            this.record_activ.Name = "record_activ";
            this.record_activ.ReadOnly = false;
            this.record_activ.Ripple = true;
            this.record_activ.Size = new System.Drawing.Size(84, 56);
            this.record_activ.TabIndex = 0;
            this.record_activ.Text = "Record";
            this.record_activ.UseVisualStyleBackColor = true;
            this.record_activ.CheckedChanged += new System.EventHandler(this.record_activ_CheckedChanged);
            // 
            // screenshot
            // 
            this.screenshot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.screenshot.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.screenshot.Depth = 0;
            this.screenshot.Dock = System.Windows.Forms.DockStyle.Left;
            this.screenshot.Enabled = false;
            this.screenshot.HighEmphasis = true;
            this.screenshot.Icon = null;
            this.screenshot.Location = new System.Drawing.Point(0, 0);
            this.screenshot.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.screenshot.MouseState = MaterialSkin.MouseState.HOVER;
            this.screenshot.Name = "screenshot";
            this.screenshot.NoAccentTextColor = System.Drawing.Color.Empty;
            this.screenshot.Size = new System.Drawing.Size(155, 56);
            this.screenshot.TabIndex = 3;
            this.screenshot.Text = "Take ScreenShot";
            this.screenshot.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.screenshot.UseAccentColor = false;
            this.screenshot.UseVisualStyleBackColor = true;
            this.screenshot.Click += new System.EventHandler(this.screenshot_Click);
            // 
            // preview_group
            // 
            this.preview_group.Controls.Add(this.preview);
            this.preview_group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preview_group.Location = new System.Drawing.Point(3, 24);
            this.preview_group.Name = "preview_group";
            this.preview_group.Size = new System.Drawing.Size(796, 412);
            this.preview_group.TabIndex = 6;
            this.preview_group.TabStop = false;
            this.preview_group.Text = "Live Preview";
            // 
            // preview
            // 
            this.preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preview.Image = global::Recran.Properties.Resources.recran;
            this.preview.Location = new System.Drawing.Point(3, 16);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(790, 393);
            this.preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.preview.TabIndex = 2;
            this.preview.TabStop = false;
            // 
            // footer
            // 
            this.footer.Controls.Add(this.header);
            this.footer.Controls.Add(this.recaudio);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(3, 436);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(796, 56);
            this.footer.TabIndex = 5;
            // 
            // recaudio
            // 
            this.recaudio.AutoSize = true;
            this.recaudio.Depth = 0;
            this.recaudio.Dock = System.Windows.Forms.DockStyle.Right;
            this.recaudio.Location = new System.Drawing.Point(593, 0);
            this.recaudio.Margin = new System.Windows.Forms.Padding(0);
            this.recaudio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.recaudio.MouseState = MaterialSkin.MouseState.HOVER;
            this.recaudio.Name = "recaudio";
            this.recaudio.ReadOnly = false;
            this.recaudio.Ripple = true;
            this.recaudio.Size = new System.Drawing.Size(203, 56);
            this.recaudio.TabIndex = 0;
            this.recaudio.Text = "Record computer sound";
            this.recaudio.UseVisualStyleBackColor = true;
            this.recaudio.CheckedChanged += new System.EventHandler(this.recaudio_CheckedChanged);
            // 
            // fp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 495);
            this.Controls.Add(this.preview_group);
            this.Controls.Add(this.footer);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fp";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "fp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fp_FormClosed);
            this.Load += new System.EventHandler(this.fp_Load);
            this.header.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.preview_group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.preview)).EndInit();
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox preview;
        private MaterialSkin.Controls.MaterialComboBox screen_list;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialCheckbox record_activ;
        private System.Windows.Forms.GroupBox preview_group;
        private System.Windows.Forms.Panel footer;
        private MaterialSkin.Controls.MaterialCheckbox recaudio;
        private MaterialSkin.Controls.MaterialButton screenshot;
    }
}