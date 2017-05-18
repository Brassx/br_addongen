using System.Windows.Forms;

namespace BrassGAddonGen
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gen = new System.Windows.Forms.Button();
            this.addonName = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.outputDirectory = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.setOutput = new System.Windows.Forms.Button();
            this.titleBar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.titleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gen
            // 
            this.gen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(213)))), ((int)(((byte)(224)))));
            this.gen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.gen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gen.Location = new System.Drawing.Point(12, 209);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(75, 23);
            this.gen.TabIndex = 0;
            this.gen.Text = "Generate";
            this.gen.UseVisualStyleBackColor = false;
            this.gen.Click += new System.EventHandler(this.gen_Click);
            // 
            // addonName
            // 
            this.addonName.Location = new System.Drawing.Point(6, 16);
            this.addonName.Name = "addonName";
            this.addonName.Size = new System.Drawing.Size(248, 20);
            this.addonName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.addonName, "Pick the name for your addon. No spaces or illegal filename characters.");
            this.addonName.TextChanged += new System.EventHandler(this.addonName_TextChanged);
            this.addonName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addonName_KeyDown);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 161);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Config Directory";
            this.toolTip1.SetToolTip(this.checkBox1, "Check this if you\'d like your addon to have a config directory/file.");
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // outputDirectory
            // 
            this.outputDirectory.Location = new System.Drawing.Point(6, 16);
            this.outputDirectory.Name = "outputDirectory";
            this.outputDirectory.ReadOnly = true;
            this.outputDirectory.Size = new System.Drawing.Size(190, 20);
            this.outputDirectory.TabIndex = 4;
            this.toolTip1.SetToolTip(this.outputDirectory, "Output Directroy for the Addon structure.");
            this.outputDirectory.WordWrap = false;
            this.outputDirectory.TextChanged += new System.EventHandler(this.outputDirectory_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addonName);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 44);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Addon Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.setOutput);
            this.groupBox2.Controls.Add(this.outputDirectory);
            this.groupBox2.Location = new System.Drawing.Point(12, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 44);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Directory";
            // 
            // setOutput
            // 
            this.setOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(213)))), ((int)(((byte)(224)))));
            this.setOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setOutput.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.setOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setOutput.Location = new System.Drawing.Point(202, 14);
            this.setOutput.Name = "setOutput";
            this.setOutput.Size = new System.Drawing.Size(52, 23);
            this.setOutput.TabIndex = 9;
            this.setOutput.Text = "Set";
            this.setOutput.UseVisualStyleBackColor = false;
            this.setOutput.Click += new System.EventHandler(this.setOutput_Click);
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.titleBar.Controls.Add(this.button1);
            this.titleBar.Controls.Add(this.titleLabel);
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(284, 30);
            this.titleBar.TabIndex = 8;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.titleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(257, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 1;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(3, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(141, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Brassx\'s Addon Generator";
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.titleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.titleLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(12, 184);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(147, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Generate Empty Lua Files";
            this.toolTip1.SetToolTip(this.checkBox2, "Check this to generate empty lua files in client, shared, and server directories." +
        " Works good for bases.");
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(284, 244);
            this.ControlBox = false;
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.gen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Brassx\'s Addon Gen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gen;
        private System.Windows.Forms.TextBox addonName;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox outputDirectory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button button1;
        private Button setOutput;
        private ToolTip toolTip1;
        private CheckBox checkBox2;
    }
}

