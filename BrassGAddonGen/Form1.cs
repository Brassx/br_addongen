using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace BrassGAddonGen
{
    public partial class Form1 : Form
    {
        private Point startPoint = new Point(0, 0);
        private bool drag = false;
        private string OutputDirectory = "";
        private string InitScriptConfig = @"local gm_cl_files = file.Find('ADDON_NAME/client/*.lua', 'LUA'); 
local gm_sh_files = file.Find('ADDON_NAME/shared/*.lua', 'LUA'); 
local gm_sv_files = file.Find('ADDON_NAME/server/*.lua', 'LUA'); 
if (SERVER) then
	AddCSLuaFile('ADDON_NAME/config/config.lua');
end
include('ADDON_NAME/config/config.lua');
for k, v in pairs(gm_cl_files) do
	if (SERVER) then
		AddCSLuaFile('ADDON_NAME/client/'..v);
	else
		include('ADDON_NAME/client/'..v);
	end
end
if (SERVER) then
	for k, v in pairs(gm_sv_files) do
		include('ADDON_NAME/server/'..v);
	end
end
for k , v in pairs(gm_sh_files) do
	include('ADDON_NAME/shared/'..v);
	if (SERVER) then
		AddCSLuaFile('ADDON_NAME/shared/'..v);
	end
end
";
        private string InitScript = @"local gm_cl_files = file.Find('ADDON_NAME/client/*.lua', 'LUA'); 
local gm_sh_files = file.Find('ADDON_NAME/shared/*.lua', 'LUA'); 
local gm_sv_files = file.Find('ADDON_NAME/server/*.lua', 'LUA'); 
for k, v in pairs(gm_cl_files) do
	if (SERVER) then
		AddCSLuaFile('ADDON_NAME/client/'..v);
	else
		include('ADDON_NAME/client/'..v);
	end
end
if (SERVER) then 
	for k, v in pairs(gm_sv_files) do
		include('ADDON_NAME/server/'..v);
	end
end
for k , v in pairs(gm_sh_files) do
	include('ADDON_NAME/shared/'..v);
	if (SERVER) then
		AddCSLuaFile('ADDON_NAME/shared/'..v);
	end
end
";
        public Form1()
        {
            InitializeComponent();
            OutputDirectory = Directory.GetCurrentDirectory();
            outputDirectory.Text = OutputDirectory;
            toolTip1.SetToolTip(outputDirectory, "Output Directroy for the Addon structure." +System.Environment.NewLine + OutputDirectory);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }



        void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            this.startPoint = e.Location;
            this.drag = true;
        }



        void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drag)
            {
                Point p1 = new Point(e.X, e.Y);
                Point p2 = this.PointToScreen(p1);
                Point p3 = new Point(p2.X - this.startPoint.X, p2.Y - this.startPoint.Y);
                this.Location = p3;
            }
        }

        void addonName_KeyDown(object sender, KeyPressEventArgs e)
        {
            if (Path.GetInvalidFileNameChars().Contains(e.KeyChar) ||
                Path.GetInvalidPathChars().Contains(e.KeyChar))
            {
                if (!Char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
        private bool GenerateAddon()
        {
            if (!File.Exists(Directory.GetCurrentDirectory() + "/InitScript.lua"))
            {
                File.WriteAllText(Directory.GetCurrentDirectory() + "/InitScript.lua", InitScript);
            }
            if (!File.Exists(Directory.GetCurrentDirectory() + "/InitScriptConfig.lua"))
            {
                File.WriteAllText(Directory.GetCurrentDirectory() + "/InitScriptConfig.lua", InitScriptConfig);
            }
            this.addonName.Text = this.addonName.Text.ToLower();
            Directory.CreateDirectory(OutputDirectory + "/" + this.addonName.Text);
            Directory.CreateDirectory(OutputDirectory + "/" + this.addonName.Text + "/lua");
            Directory.CreateDirectory(OutputDirectory + "/" + this.addonName.Text + "/lua/autorun");
            Directory.CreateDirectory(OutputDirectory + "/" + this.addonName.Text + "/lua/" + this.addonName.Text);
            Directory.CreateDirectory(OutputDirectory + "/" + this.addonName.Text + "/lua/" + this.addonName.Text +"/client");
            Directory.CreateDirectory(OutputDirectory + "/" + this.addonName.Text + "/lua/" + this.addonName.Text +"/server");
            Directory.CreateDirectory(OutputDirectory + "/" + this.addonName.Text + "/lua/" + this.addonName.Text +"/shared");
            string script = "";
            if (this.checkBox1.Checked == true)
            {
                Directory.CreateDirectory(OutputDirectory + "/" + this.addonName.Text + "/lua/" + this.addonName.Text + "/config");
                script = File.ReadAllText(Directory.GetCurrentDirectory() + "/InitScriptConfig.lua");
                File.WriteAllText(OutputDirectory + "/" + this.addonName.Text + "/lua/"+this.addonName.Text+"/config/config.lua", "//your config stuff goes here.."+System.Environment.NewLine+this.addonName.Text.ToUpper()+"_CONFIG = {};");
            }
            else
            {
                script = File.ReadAllText(Directory.GetCurrentDirectory() + "/InitScript.lua");
            }
            script = script.Replace("ADDON_NAME", this.addonName.Text);
            File.WriteAllText(OutputDirectory + "/" + this.addonName.Text + "/lua/autorun/" + this.addonName.Text+"_init.lua", script);
            if (checkBox2.Checked == true)
            {
                File.WriteAllText(OutputDirectory + "/" + this.addonName.Text + "/lua/" + this.addonName.Text + "/client/cl_" + this.addonName.Text + ".lua", "//your client stuff goes here..");
                File.WriteAllText(OutputDirectory + "/" + this.addonName.Text + "/lua/" + this.addonName.Text + "/server/sv_" + this.addonName.Text + ".lua", "//your server-side stuff goes here..");
                File.WriteAllText(OutputDirectory + "/" + this.addonName.Text + "/lua/" + this.addonName.Text + "/shared/sh_" + this.addonName.Text + ".lua", "//your shared stuff goes here..");
            }
            return true;
        }
        private void gen_Click(object sender, EventArgs e)
        {
            GenerateAddon();
            MessageBox.Show(this, "Addon Generated!", "Success");
        }

        private void outputDirectory_TextChanged(object sender, EventArgs e)
        {
            this.OutputDirectory = this.outputDirectory.Text;
        }

        private void addonName_TextChanged(object sender, EventArgs e)
        {
            this.addonName.Text= this.addonName.Text.Replace(" ", "_");
            this.addonName.Text = this.addonName.Text.Replace(".", "_");
            this.addonName.SelectionStart = this.addonName.Text.Length;
            this.addonName.SelectionLength = 0;
           
        }

        private void setOutput_Click(object sender, EventArgs e)
        {
            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                OutputDirectory = dialog.SelectedPath;
                outputDirectory.Text = OutputDirectory;
            }
        }
    }
}
