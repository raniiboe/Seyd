namespace Seyd
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
            this.AddEve = new System.Windows.Forms.Button();
            this.EveList = new System.Windows.Forms.ListView();
            this.RamLamList = new System.Windows.Forms.ListView();
            this.EveLambList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddRamLam = new System.Windows.Forms.Button();
            this.AddEveLamb = new System.Windows.Forms.Button();
            this.RemoveEve = new System.Windows.Forms.Button();
            this.RemoveRamLam = new System.Windows.Forms.Button();
            this.RemoveEveLam = new System.Windows.Forms.Button();
            this.EveWeight = new System.Windows.Forms.NumericUpDown();
            this.RamLamWeight = new System.Windows.Forms.NumericUpDown();
            this.EveLambWeight = new System.Windows.Forms.NumericUpDown();
            this.OwnerName = new System.Windows.Forms.TextBox();
            this.OwnerList = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OwnedPortion = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.AddOwner = new System.Windows.Forms.Button();
            this.RemoveOwner = new System.Windows.Forms.Button();
            this.Solve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EveWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RamLamWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EveLambWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OwnedPortion)).BeginInit();
            this.SuspendLayout();
            // 
            // AddEve
            // 
            this.AddEve.Location = new System.Drawing.Point(69, 316);
            this.AddEve.Name = "AddEve";
            this.AddEve.Size = new System.Drawing.Size(75, 23);
            this.AddEve.TabIndex = 0;
            this.AddEve.Text = "Add";
            this.AddEve.UseVisualStyleBackColor = true;
            this.AddEve.Click += new System.EventHandler(this.button1_Click);
            // 
            // EveList
            // 
            this.EveList.HideSelection = false;
            this.EveList.Location = new System.Drawing.Point(48, 163);
            this.EveList.Name = "EveList";
            this.EveList.Size = new System.Drawing.Size(121, 97);
            this.EveList.TabIndex = 1;
            this.EveList.UseCompatibleStateImageBehavior = false;
            // 
            // RamLamList
            // 
            this.RamLamList.HideSelection = false;
            this.RamLamList.Location = new System.Drawing.Point(323, 163);
            this.RamLamList.Name = "RamLamList";
            this.RamLamList.Size = new System.Drawing.Size(121, 97);
            this.RamLamList.TabIndex = 2;
            this.RamLamList.UseCompatibleStateImageBehavior = false;
            // 
            // EveLambList
            // 
            this.EveLambList.HideSelection = false;
            this.EveLambList.Location = new System.Drawing.Point(613, 163);
            this.EveLambList.Name = "EveLambList";
            this.EveLambList.Size = new System.Drawing.Size(121, 97);
            this.EveLambList.TabIndex = 3;
            this.EveLambList.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ær";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vedur lomb";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(611, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gimbur lomb";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // AddRamLam
            // 
            this.AddRamLam.Location = new System.Drawing.Point(347, 316);
            this.AddRamLam.Name = "AddRamLam";
            this.AddRamLam.Size = new System.Drawing.Size(75, 23);
            this.AddRamLam.TabIndex = 7;
            this.AddRamLam.Text = "Add";
            this.AddRamLam.UseVisualStyleBackColor = true;
            // 
            // AddEveLamb
            // 
            this.AddEveLamb.Location = new System.Drawing.Point(637, 316);
            this.AddEveLamb.Name = "AddEveLamb";
            this.AddEveLamb.Size = new System.Drawing.Size(75, 23);
            this.AddEveLamb.TabIndex = 8;
            this.AddEveLamb.Text = "Add";
            this.AddEveLamb.UseVisualStyleBackColor = true;
            // 
            // RemoveEve
            // 
            this.RemoveEve.Location = new System.Drawing.Point(69, 355);
            this.RemoveEve.Name = "RemoveEve";
            this.RemoveEve.Size = new System.Drawing.Size(75, 23);
            this.RemoveEve.TabIndex = 9;
            this.RemoveEve.Text = "Remove";
            this.RemoveEve.UseVisualStyleBackColor = true;
            this.RemoveEve.Click += new System.EventHandler(this.RemoveEve_Click);
            // 
            // RemoveRamLam
            // 
            this.RemoveRamLam.Location = new System.Drawing.Point(347, 355);
            this.RemoveRamLam.Name = "RemoveRamLam";
            this.RemoveRamLam.Size = new System.Drawing.Size(75, 23);
            this.RemoveRamLam.TabIndex = 10;
            this.RemoveRamLam.Text = "Remove";
            this.RemoveRamLam.UseVisualStyleBackColor = true;
            this.RemoveRamLam.Click += new System.EventHandler(this.RemoveRamLam_Click);
            // 
            // RemoveEveLam
            // 
            this.RemoveEveLam.Location = new System.Drawing.Point(638, 355);
            this.RemoveEveLam.Name = "RemoveEveLam";
            this.RemoveEveLam.Size = new System.Drawing.Size(75, 23);
            this.RemoveEveLam.TabIndex = 11;
            this.RemoveEveLam.Text = "Remove";
            this.RemoveEveLam.UseVisualStyleBackColor = true;
            this.RemoveEveLam.Click += new System.EventHandler(this.button6_Click);
            // 
            // EveWeight
            // 
            this.EveWeight.DecimalPlaces = 1;
            this.EveWeight.Location = new System.Drawing.Point(49, 281);
            this.EveWeight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.EveWeight.Name = "EveWeight";
            this.EveWeight.Size = new System.Drawing.Size(120, 20);
            this.EveWeight.TabIndex = 12;
            // 
            // RamLamWeight
            // 
            this.RamLamWeight.DecimalPlaces = 1;
            this.RamLamWeight.Location = new System.Drawing.Point(324, 281);
            this.RamLamWeight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.RamLamWeight.Name = "RamLamWeight";
            this.RamLamWeight.Size = new System.Drawing.Size(120, 20);
            this.RamLamWeight.TabIndex = 13;
            // 
            // EveLambWeight
            // 
            this.EveLambWeight.DecimalPlaces = 1;
            this.EveLambWeight.Location = new System.Drawing.Point(614, 281);
            this.EveLambWeight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.EveLambWeight.Name = "EveLambWeight";
            this.EveLambWeight.Size = new System.Drawing.Size(120, 20);
            this.EveLambWeight.TabIndex = 14;
            this.EveLambWeight.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // OwnerName
            // 
            this.OwnerName.Location = new System.Drawing.Point(200, 53);
            this.OwnerName.Name = "OwnerName";
            this.OwnerName.Size = new System.Drawing.Size(100, 20);
            this.OwnerName.TabIndex = 15;
            // 
            // OwnerList
            // 
            this.OwnerList.HideSelection = false;
            this.OwnerList.Location = new System.Drawing.Point(451, 34);
            this.OwnerList.Name = "OwnerList";
            this.OwnerList.Size = new System.Drawing.Size(121, 97);
            this.OwnerList.TabIndex = 16;
            this.OwnerList.UseCompatibleStateImageBehavior = false;
            this.OwnerList.SelectedIndexChanged += new System.EventHandler(this.OwnerList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Eigarar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Navn";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // OwnedPortion
            // 
            this.OwnedPortion.DecimalPlaces = 2;
            this.OwnedPortion.Location = new System.Drawing.Point(200, 102);
            this.OwnedPortion.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.OwnedPortion.Name = "OwnedPortion";
            this.OwnedPortion.Size = new System.Drawing.Size(120, 20);
            this.OwnedPortion.TabIndex = 19;
            this.OwnedPortion.ThousandsSeparator = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Partur (% ella skinn ella...)";
            // 
            // AddOwner
            // 
            this.AddOwner.Location = new System.Drawing.Point(345, 66);
            this.AddOwner.Name = "AddOwner";
            this.AddOwner.Size = new System.Drawing.Size(75, 23);
            this.AddOwner.TabIndex = 21;
            this.AddOwner.Text = "Add";
            this.AddOwner.UseVisualStyleBackColor = true;
            this.AddOwner.Click += new System.EventHandler(this.button7_Click);
            // 
            // RemoveOwner
            // 
            this.RemoveOwner.Location = new System.Drawing.Point(345, 99);
            this.RemoveOwner.Name = "RemoveOwner";
            this.RemoveOwner.Size = new System.Drawing.Size(75, 23);
            this.RemoveOwner.TabIndex = 22;
            this.RemoveOwner.Text = "Remove";
            this.RemoveOwner.UseVisualStyleBackColor = true;
            this.RemoveOwner.Click += new System.EventHandler(this.button8_Click);
            // 
            // Solve
            // 
            this.Solve.Location = new System.Drawing.Point(309, 400);
            this.Solve.Name = "Solve";
            this.Solve.Size = new System.Drawing.Size(151, 41);
            this.Solve.TabIndex = 23;
            this.Solve.Text = "Run solver";
            this.Solve.UseVisualStyleBackColor = true;
            this.Solve.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 474);
            this.Controls.Add(this.Solve);
            this.Controls.Add(this.RemoveOwner);
            this.Controls.Add(this.AddOwner);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OwnedPortion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OwnerList);
            this.Controls.Add(this.OwnerName);
            this.Controls.Add(this.EveLambWeight);
            this.Controls.Add(this.RamLamWeight);
            this.Controls.Add(this.EveWeight);
            this.Controls.Add(this.RemoveEveLam);
            this.Controls.Add(this.RemoveRamLam);
            this.Controls.Add(this.RemoveEve);
            this.Controls.Add(this.AddEveLamb);
            this.Controls.Add(this.AddRamLam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EveLambList);
            this.Controls.Add(this.RamLamList);
            this.Controls.Add(this.EveList);
            this.Controls.Add(this.AddEve);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.EveWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RamLamWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EveLambWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OwnedPortion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddEve;
        private System.Windows.Forms.ListView EveList;
        private System.Windows.Forms.ListView RamLamList;
        private System.Windows.Forms.ListView EveLambList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddRamLam;
        private System.Windows.Forms.Button AddEveLamb;
        private System.Windows.Forms.Button RemoveEve;
        private System.Windows.Forms.Button RemoveRamLam;
        private System.Windows.Forms.Button RemoveEveLam;
        private System.Windows.Forms.NumericUpDown EveWeight;
        private System.Windows.Forms.NumericUpDown RamLamWeight;
        private System.Windows.Forms.NumericUpDown EveLambWeight;
        private System.Windows.Forms.TextBox OwnerName;
        private System.Windows.Forms.ListView OwnerList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown OwnedPortion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddOwner;
        private System.Windows.Forms.Button RemoveOwner;
        private System.Windows.Forms.Button Solve;
    }
}

