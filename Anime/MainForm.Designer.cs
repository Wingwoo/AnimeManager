
namespace Anime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AnimeName = new System.Windows.Forms.TextBox();
            this.AnimeURL = new System.Windows.Forms.TextBox();
            this.AnimeList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(265, 217);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(156, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(12, 217);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(242, 23);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(260, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(260, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // AnimeName
            // 
            this.AnimeName.Location = new System.Drawing.Point(265, 44);
            this.AnimeName.Name = "AnimeName";
            this.AnimeName.Size = new System.Drawing.Size(156, 20);
            this.AnimeName.TabIndex = 5;
            this.AnimeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnimeName_KeyDown);
            // 
            // AnimeURL
            // 
            this.AnimeURL.Location = new System.Drawing.Point(265, 136);
            this.AnimeURL.Name = "AnimeURL";
            this.AnimeURL.Size = new System.Drawing.Size(156, 20);
            this.AnimeURL.TabIndex = 6;
            this.AnimeURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnimeURL_KeyDown);
            // 
            // AnimeList
            // 
            this.AnimeList.FormattingEnabled = true;
            this.AnimeList.Location = new System.Drawing.Point(12, 12);
            this.AnimeList.Name = "AnimeList";
            this.AnimeList.Size = new System.Drawing.Size(242, 199);
            this.AnimeList.TabIndex = 7;
            this.AnimeList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnimeList_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 250);
            this.Controls.Add(this.AnimeList);
            this.Controls.Add(this.AnimeURL);
            this.Controls.Add(this.AnimeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AnimeLoader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AnimeName;
        private System.Windows.Forms.TextBox AnimeURL;
        private System.Windows.Forms.ListBox AnimeList;
    }
}

