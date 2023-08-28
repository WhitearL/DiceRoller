namespace DiceRoller
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbDieCount = new ComboBox();
            lblD = new Label();
            cmbDieSize = new ComboBox();
            lblPlus = new Label();
            cmbRollBonus = new ComboBox();
            btnRollDamage = new Button();
            lblDamageResult = new Label();
            pnlDamage = new Panel();
            cmbAbilityScore = new ComboBox();
            rbAdv = new RadioButton();
            rbNone = new RadioButton();
            rbDisadv = new RadioButton();
            cmbCheckBonus = new ComboBox();
            btnRollCheck = new Button();
            lblCheckResult = new Label();
            lblAbilityScore = new Label();
            lblCheckBonus = new Label();
            panel1 = new Panel();
            lblWorkings = new Label();
            label1 = new Label();
            label2 = new Label();
            pnlDamage.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbDieCount
            // 
            cmbDieCount.FormattingEnabled = true;
            cmbDieCount.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            cmbDieCount.Location = new Point(1, 2);
            cmbDieCount.Name = "cmbDieCount";
            cmbDieCount.Size = new Size(65, 23);
            cmbDieCount.TabIndex = 0;
            // 
            // lblD
            // 
            lblD.AutoSize = true;
            lblD.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblD.Location = new Point(72, 0);
            lblD.Name = "lblD";
            lblD.Size = new Size(23, 25);
            lblD.TabIndex = 1;
            lblD.Text = "d";
            // 
            // cmbDieSize
            // 
            cmbDieSize.FormattingEnabled = true;
            cmbDieSize.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            cmbDieSize.Location = new Point(101, 2);
            cmbDieSize.Name = "cmbDieSize";
            cmbDieSize.Size = new Size(65, 23);
            cmbDieSize.TabIndex = 2;
            // 
            // lblPlus
            // 
            lblPlus.AutoSize = true;
            lblPlus.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlus.Location = new Point(172, 0);
            lblPlus.Name = "lblPlus";
            lblPlus.Size = new Size(24, 25);
            lblPlus.TabIndex = 3;
            lblPlus.Text = "+";
            // 
            // cmbRollBonus
            // 
            cmbRollBonus.FormattingEnabled = true;
            cmbRollBonus.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            cmbRollBonus.Location = new Point(202, 3);
            cmbRollBonus.Name = "cmbRollBonus";
            cmbRollBonus.Size = new Size(65, 23);
            cmbRollBonus.TabIndex = 4;
            // 
            // btnRollDamage
            // 
            btnRollDamage.Location = new Point(1, 31);
            btnRollDamage.Name = "btnRollDamage";
            btnRollDamage.Size = new Size(266, 23);
            btnRollDamage.TabIndex = 5;
            btnRollDamage.Text = "Roll";
            btnRollDamage.UseVisualStyleBackColor = true;
            btnRollDamage.Click += btnRollDamage_Click;
            // 
            // lblDamageResult
            // 
            lblDamageResult.AutoSize = true;
            lblDamageResult.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblDamageResult.Location = new Point(273, 3);
            lblDamageResult.MaximumSize = new Size(200, 0);
            lblDamageResult.Name = "lblDamageResult";
            lblDamageResult.Size = new Size(153, 37);
            lblDamageResult.TabIndex = 6;
            lblDamageResult.Text = "Roll Result";
            // 
            // pnlDamage
            // 
            pnlDamage.Controls.Add(cmbRollBonus);
            pnlDamage.Controls.Add(lblDamageResult);
            pnlDamage.Controls.Add(cmbDieCount);
            pnlDamage.Controls.Add(btnRollDamage);
            pnlDamage.Controls.Add(lblD);
            pnlDamage.Controls.Add(cmbDieSize);
            pnlDamage.Controls.Add(lblPlus);
            pnlDamage.Location = new Point(12, 43);
            pnlDamage.Name = "pnlDamage";
            pnlDamage.Size = new Size(524, 56);
            pnlDamage.TabIndex = 7;
            // 
            // cmbAbilityScore
            // 
            cmbAbilityScore.FormattingEnabled = true;
            cmbAbilityScore.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            cmbAbilityScore.Location = new Point(3, 3);
            cmbAbilityScore.Name = "cmbAbilityScore";
            cmbAbilityScore.Size = new Size(90, 23);
            cmbAbilityScore.TabIndex = 8;
            // 
            // rbAdv
            // 
            rbAdv.AutoSize = true;
            rbAdv.Location = new Point(184, 66);
            rbAdv.Name = "rbAdv";
            rbAdv.Size = new Size(82, 19);
            rbAdv.TabIndex = 9;
            rbAdv.TabStop = true;
            rbAdv.Text = "Advantage";
            rbAdv.UseVisualStyleBackColor = true;
            rbAdv.CheckedChanged += rbAdv_CheckedChanged;
            // 
            // rbNone
            // 
            rbNone.AutoSize = true;
            rbNone.Location = new Point(3, 65);
            rbNone.Name = "rbNone";
            rbNone.Size = new Size(54, 19);
            rbNone.TabIndex = 10;
            rbNone.TabStop = true;
            rbNone.Text = "None";
            rbNone.UseVisualStyleBackColor = true;
            rbNone.CheckedChanged += rbNone_CheckedChanged;
            // 
            // rbDisadv
            // 
            rbDisadv.AutoSize = true;
            rbDisadv.Location = new Point(70, 67);
            rbDisadv.Name = "rbDisadv";
            rbDisadv.Size = new Size(96, 19);
            rbDisadv.TabIndex = 11;
            rbDisadv.TabStop = true;
            rbDisadv.Text = "Disadvantage";
            rbDisadv.UseVisualStyleBackColor = true;
            rbDisadv.CheckedChanged += rbDisadv_CheckedChanged;
            // 
            // cmbCheckBonus
            // 
            cmbCheckBonus.FormattingEnabled = true;
            cmbCheckBonus.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            cmbCheckBonus.Location = new Point(3, 32);
            cmbCheckBonus.Name = "cmbCheckBonus";
            cmbCheckBonus.Size = new Size(90, 23);
            cmbCheckBonus.TabIndex = 7;
            // 
            // btnRollCheck
            // 
            btnRollCheck.Location = new Point(0, 91);
            btnRollCheck.Name = "btnRollCheck";
            btnRollCheck.Size = new Size(266, 31);
            btnRollCheck.TabIndex = 7;
            btnRollCheck.Text = "Roll";
            btnRollCheck.UseVisualStyleBackColor = true;
            btnRollCheck.Click += btnRollCheck_Click;
            // 
            // lblCheckResult
            // 
            lblCheckResult.AutoSize = true;
            lblCheckResult.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblCheckResult.Location = new Point(273, 6);
            lblCheckResult.MaximumSize = new Size(200, 0);
            lblCheckResult.Name = "lblCheckResult";
            lblCheckResult.Size = new Size(179, 37);
            lblCheckResult.TabIndex = 7;
            lblCheckResult.Text = "Check Result";
            // 
            // lblAbilityScore
            // 
            lblAbilityScore.AutoSize = true;
            lblAbilityScore.Location = new Point(99, 6);
            lblAbilityScore.Name = "lblAbilityScore";
            lblAbilityScore.Size = new Size(73, 15);
            lblAbilityScore.TabIndex = 13;
            lblAbilityScore.Text = "Ability Score";
            // 
            // lblCheckBonus
            // 
            lblCheckBonus.AutoSize = true;
            lblCheckBonus.Location = new Point(99, 35);
            lblCheckBonus.Name = "lblCheckBonus";
            lblCheckBonus.Size = new Size(40, 15);
            lblCheckBonus.TabIndex = 14;
            lblCheckBonus.Text = "Bonus";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblWorkings);
            panel1.Controls.Add(btnRollCheck);
            panel1.Controls.Add(lblCheckBonus);
            panel1.Controls.Add(lblAbilityScore);
            panel1.Controls.Add(cmbAbilityScore);
            panel1.Controls.Add(rbAdv);
            panel1.Controls.Add(lblCheckResult);
            panel1.Controls.Add(rbNone);
            panel1.Controls.Add(rbDisadv);
            panel1.Controls.Add(cmbCheckBonus);
            panel1.Location = new Point(12, 153);
            panel1.Name = "panel1";
            panel1.Size = new Size(524, 125);
            panel1.TabIndex = 15;
            // 
            // lblWorkings
            // 
            lblWorkings.AutoSize = true;
            lblWorkings.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblWorkings.Location = new Point(274, 62);
            lblWorkings.MaximumSize = new Size(250, 0);
            lblWorkings.Name = "lblWorkings";
            lblWorkings.Size = new Size(152, 21);
            lblWorkings.TabIndex = 15;
            lblWorkings.Text = "Workings show here";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(156, 28);
            label1.TabIndex = 16;
            label1.Text = "Damage / Bonus";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 122);
            label2.Name = "label2";
            label2.Size = new Size(72, 28);
            label2.TabIndex = 17;
            label2.Text = "Checks";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 290);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pnlDamage);
            Name = "frmMain";
            Text = "Dice Roller";
            Load += frmMain_Load;
            pnlDamage.ResumeLayout(false);
            pnlDamage.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDieCount;
        private Label lblD;
        private ComboBox cmbDieSize;
        private Label lblPlus;
        private ComboBox cmbRollBonus;
        private Button btnRollDamage;
        private Label lblDamageResult;
        private Panel pnlDamage;
        private ComboBox cmbAbilityScore;
        private RadioButton rbAdv;
        private RadioButton rbNone;
        private RadioButton rbDisadv;
        private ComboBox cmbCheckBonus;
        private Button btnRollCheck;
        private Label lblCheckResult;
        private Label lblAbilityScore;
        private Label lblCheckBonus;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label lblWorkings;
    }
}