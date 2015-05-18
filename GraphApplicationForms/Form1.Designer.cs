namespace GraphApplicationForms
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_minStops = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4_to = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.TxtBox_lessThanDist = new System.Windows.Forms.TextBox();
            this.textBox4_from = new System.Windows.Forms.TextBox();
            this.textBox2_noOfTrips = new System.Windows.Forms.TextBox();
            this.textBox1_add = new System.Windows.Forms.TextBox();
            this.button_calcResult = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton4_noOfRoutes = new System.Windows.Forms.RadioButton();
            this.radioButton3_shortestRoute = new System.Windows.Forms.RadioButton();
            this.radioButton2_NoOfTrips = new System.Windows.Forms.RadioButton();
            this.radioButton1_add = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ExceptionLabel = new System.Windows.Forms.Label();
            this.btn_LoadTextFile = new System.Windows.Forms.Button();
            this.btn_open_file_dialog = new System.Windows.Forms.Button();
            this.textBox_GetTextFile = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBox_minStops);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.textBox4_to);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label_result);
            this.tabPage2.Controls.Add(this.TxtBox_lessThanDist);
            this.tabPage2.Controls.Add(this.textBox4_from);
            this.tabPage2.Controls.Add(this.textBox2_noOfTrips);
            this.tabPage2.Controls.Add(this.textBox1_add);
            this.tabPage2.Controls.Add(this.button_calcResult);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.radioButton4_noOfRoutes);
            this.tabPage2.Controls.Add(this.radioButton3_shortestRoute);
            this.tabPage2.Controls.Add(this.radioButton2_NoOfTrips);
            this.tabPage2.Controls.Add(this.radioButton1_add);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage2.Size = new System.Drawing.Size(715, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Display Graph Details";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Minimum Number Of Stops";
            // 
            // textBox_minStops
            // 
            this.textBox_minStops.Location = new System.Drawing.Point(101, 46);
            this.textBox_minStops.Name = "textBox_minStops";
            this.textBox_minStops.Size = new System.Drawing.Size(100, 20);
            this.textBox_minStops.TabIndex = 23;
            this.textBox_minStops.Text = "0";
            this.textBox_minStops.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(361, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "To";
            // 
            // textBox4_to
            // 
            this.textBox4_to.Location = new System.Drawing.Point(361, 155);
            this.textBox4_to.Name = "textBox4_to";
            this.textBox4_to.Size = new System.Drawing.Size(32, 20);
            this.textBox4_to.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(297, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Add Path Nodes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Maximum Stops";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Distance Less Than ";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(524, 96);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(86, 13);
            this.label_result.TabIndex = 14;
            this.label_result.Text = "RESULT LABEL";
            this.label_result.Click += new System.EventHandler(this.label_result_Click);
            // 
            // TxtBox_lessThanDist
            // 
            this.TxtBox_lessThanDist.Location = new System.Drawing.Point(524, 46);
            this.TxtBox_lessThanDist.Name = "TxtBox_lessThanDist";
            this.TxtBox_lessThanDist.Size = new System.Drawing.Size(113, 20);
            this.TxtBox_lessThanDist.TabIndex = 13;
            this.TxtBox_lessThanDist.TextChanged += new System.EventHandler(this.TxtBox_lessThanDist_TextChanged);
            // 
            // textBox4_from
            // 
            this.textBox4_from.Location = new System.Drawing.Point(297, 155);
            this.textBox4_from.Name = "textBox4_from";
            this.textBox4_from.Size = new System.Drawing.Size(32, 20);
            this.textBox4_from.TabIndex = 11;
            // 
            // textBox2_noOfTrips
            // 
            this.textBox2_noOfTrips.Location = new System.Drawing.Point(101, 96);
            this.textBox2_noOfTrips.Name = "textBox2_noOfTrips";
            this.textBox2_noOfTrips.Size = new System.Drawing.Size(102, 20);
            this.textBox2_noOfTrips.TabIndex = 24;
            // 
            // textBox1_add
            // 
            this.textBox1_add.Location = new System.Drawing.Point(250, 50);
            this.textBox1_add.Name = "textBox1_add";
            this.textBox1_add.Size = new System.Drawing.Size(100, 20);
            this.textBox1_add.TabIndex = 8;
            // 
            // button_calcResult
            // 
            this.button_calcResult.Location = new System.Drawing.Point(264, 203);
            this.button_calcResult.Name = "button_calcResult";
            this.button_calcResult.Size = new System.Drawing.Size(158, 71);
            this.button_calcResult.TabIndex = 7;
            this.button_calcResult.Text = "CALCULATE RESULT";
            this.button_calcResult.UseCompatibleTextRendering = true;
            this.button_calcResult.UseVisualStyleBackColor = true;
            this.button_calcResult.Click += new System.EventHandler(this.button_calcResult_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "RESULT";
            // 
            // radioButton4_noOfRoutes
            // 
            this.radioButton4_noOfRoutes.AutoSize = true;
            this.radioButton4_noOfRoutes.Location = new System.Drawing.Point(524, 20);
            this.radioButton4_noOfRoutes.Name = "radioButton4_noOfRoutes";
            this.radioButton4_noOfRoutes.Size = new System.Drawing.Size(113, 17);
            this.radioButton4_noOfRoutes.TabIndex = 5;
            this.radioButton4_noOfRoutes.Text = "Number Of Routes";
            this.radioButton4_noOfRoutes.UseVisualStyleBackColor = true;
            // 
            // radioButton3_shortestRoute
            // 
            this.radioButton3_shortestRoute.AutoSize = true;
            this.radioButton3_shortestRoute.Location = new System.Drawing.Point(387, 20);
            this.radioButton3_shortestRoute.Name = "radioButton3_shortestRoute";
            this.radioButton3_shortestRoute.Size = new System.Drawing.Size(96, 17);
            this.radioButton3_shortestRoute.TabIndex = 4;
            this.radioButton3_shortestRoute.Text = "Shortest Route";
            this.radioButton3_shortestRoute.UseVisualStyleBackColor = true;
            // 
            // radioButton2_NoOfTrips
            // 
            this.radioButton2_NoOfTrips.AutoSize = true;
            this.radioButton2_NoOfTrips.Location = new System.Drawing.Point(101, 18);
            this.radioButton2_NoOfTrips.Name = "radioButton2_NoOfTrips";
            this.radioButton2_NoOfTrips.Size = new System.Drawing.Size(102, 17);
            this.radioButton2_NoOfTrips.TabIndex = 3;
            this.radioButton2_NoOfTrips.Text = "Number Of Trips";
            this.radioButton2_NoOfTrips.UseVisualStyleBackColor = true;
            // 
            // radioButton1_add
            // 
            this.radioButton1_add.AutoSize = true;
            this.radioButton1_add.Checked = true;
            this.radioButton1_add.Location = new System.Drawing.Point(250, 18);
            this.radioButton1_add.Name = "radioButton1_add";
            this.radioButton1_add.Size = new System.Drawing.Size(96, 17);
            this.radioButton1_add.TabIndex = 2;
            this.radioButton1_add.TabStop = true;
            this.radioButton1_add.Text = "Add Total Path";
            this.radioButton1_add.UseVisualStyleBackColor = true;
            this.radioButton1_add.CheckedChanged += new System.EventHandler(this.radioButton1_add_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.ExceptionLabel);
            this.tabPage1.Controls.Add(this.btn_LoadTextFile);
            this.tabPage1.Controls.Add(this.btn_open_file_dialog);
            this.tabPage1.Controls.Add(this.textBox_GetTextFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(715, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Load Graph Text File";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // ExceptionLabel
            // 
            this.ExceptionLabel.AutoSize = true;
            this.ExceptionLabel.BackColor = System.Drawing.Color.Maroon;
            this.ExceptionLabel.Location = new System.Drawing.Point(69, 180);
            this.ExceptionLabel.Name = "ExceptionLabel";
            this.ExceptionLabel.Size = new System.Drawing.Size(35, 13);
            this.ExceptionLabel.TabIndex = 3;
            this.ExceptionLabel.Text = "label1";
            // 
            // btn_LoadTextFile
            // 
            this.btn_LoadTextFile.Location = new System.Drawing.Point(463, 73);
            this.btn_LoadTextFile.Name = "btn_LoadTextFile";
            this.btn_LoadTextFile.Size = new System.Drawing.Size(168, 78);
            this.btn_LoadTextFile.TabIndex = 2;
            this.btn_LoadTextFile.Text = "Load Text File";
            this.btn_LoadTextFile.UseVisualStyleBackColor = true;
            this.btn_LoadTextFile.Click += new System.EventHandler(this.btn_LoadTextFile_Click);
            // 
            // btn_open_file_dialog
            // 
            this.btn_open_file_dialog.Location = new System.Drawing.Point(72, 73);
            this.btn_open_file_dialog.Name = "btn_open_file_dialog";
            this.btn_open_file_dialog.Size = new System.Drawing.Size(168, 78);
            this.btn_open_file_dialog.TabIndex = 1;
            this.btn_open_file_dialog.Text = "Browse For Text File";
            this.btn_open_file_dialog.UseVisualStyleBackColor = true;
            this.btn_open_file_dialog.Click += new System.EventHandler(this.btn_open_file_dialog_Click);
            // 
            // textBox_GetTextFile
            // 
            this.textBox_GetTextFile.Location = new System.Drawing.Point(72, 32);
            this.textBox_GetTextFile.Name = "textBox_GetTextFile";
            this.textBox_GetTextFile.ReadOnly = true;
            this.textBox_GetTextFile.Size = new System.Drawing.Size(559, 20);
            this.textBox_GetTextFile.TabIndex = 0;
            this.textBox_GetTextFile.TextChanged += new System.EventHandler(this.textBox_GetTextFile_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(32, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(723, 417);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 517);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton radioButton4_noOfRoutes;
        private System.Windows.Forms.RadioButton radioButton3_shortestRoute;
        private System.Windows.Forms.RadioButton radioButton2_NoOfTrips;
        private System.Windows.Forms.RadioButton radioButton1_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label ExceptionLabel;
        private System.Windows.Forms.Button btn_LoadTextFile;
        private System.Windows.Forms.Button btn_open_file_dialog;
        private System.Windows.Forms.TextBox textBox_GetTextFile;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button_calcResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBox_lessThanDist;
        private System.Windows.Forms.TextBox textBox4_from;
        private System.Windows.Forms.TextBox textBox2_noOfTrips;
        private System.Windows.Forms.TextBox textBox1_add;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4_to;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_minStops;

    }
}

