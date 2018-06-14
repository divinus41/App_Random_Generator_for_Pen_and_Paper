namespace RandomGenerator
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ComboBoxDiceSides = new System.Windows.Forms.ComboBox();
            this.TextboxDiceAmount = new System.Windows.Forms.TextBox();
            this.ListboxResultOutput = new System.Windows.Forms.ListBox();
            this.ButtonAddDiceType = new System.Windows.Forms.Button();
            this.ButtonResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Decide = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.OptionsListBox = new System.Windows.Forms.ListBox();
            this.DecisionResultLabel = new System.Windows.Forms.Label();
            this.CoinflipResultLabel = new System.Windows.Forms.Label();
            this.EnterOptionTextbox = new System.Windows.Forms.TextBox();
            this.ButtonRemoveDiceType = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LabelVersionNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboBoxDiceSides
            // 
            this.ComboBoxDiceSides.BackColor = System.Drawing.Color.PeachPuff;
            this.ComboBoxDiceSides.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboBoxDiceSides.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDiceSides.Items.AddRange(new object[] {
            "4",
            "6",
            "12",
            "20"});
            this.ComboBoxDiceSides.Location = new System.Drawing.Point(12, 58);
            this.ComboBoxDiceSides.Name = "ComboBoxDiceSides";
            this.ComboBoxDiceSides.Size = new System.Drawing.Size(121, 28);
            this.ComboBoxDiceSides.TabIndex = 0;
            this.ComboBoxDiceSides.Text = "Dice side";
            // 
            // TextboxDiceAmount
            // 
            this.TextboxDiceAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextboxDiceAmount.BackColor = System.Drawing.Color.PeachPuff;
            this.TextboxDiceAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxDiceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxDiceAmount.Location = new System.Drawing.Point(139, 58);
            this.TextboxDiceAmount.Name = "TextboxDiceAmount";
            this.TextboxDiceAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextboxDiceAmount.Size = new System.Drawing.Size(117, 25);
            this.TextboxDiceAmount.TabIndex = 1;
            this.TextboxDiceAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ListboxResultOutput
            // 
            this.ListboxResultOutput.BackColor = System.Drawing.Color.Maroon;
            this.ListboxResultOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListboxResultOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListboxResultOutput.ForeColor = System.Drawing.Color.Gold;
            this.ListboxResultOutput.FormattingEnabled = true;
            this.ListboxResultOutput.HorizontalScrollbar = true;
            this.ListboxResultOutput.ItemHeight = 25;
            this.ListboxResultOutput.Location = new System.Drawing.Point(262, 58);
            this.ListboxResultOutput.Name = "ListboxResultOutput";
            this.ListboxResultOutput.Size = new System.Drawing.Size(416, 25);
            this.ListboxResultOutput.TabIndex = 20;
            // 
            // ButtonAddDiceType
            // 
            this.ButtonAddDiceType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonAddDiceType.FlatAppearance.BorderSize = 0;
            this.ButtonAddDiceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddDiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddDiceType.ForeColor = System.Drawing.Color.PeachPuff;
            this.ButtonAddDiceType.Image = global::RandomGenerator.Properties.Resources._8357a3f1824f652;
            this.ButtonAddDiceType.Location = new System.Drawing.Point(13, 93);
            this.ButtonAddDiceType.Name = "ButtonAddDiceType";
            this.ButtonAddDiceType.Size = new System.Drawing.Size(120, 27);
            this.ButtonAddDiceType.TabIndex = 15;
            this.ButtonAddDiceType.TabStop = false;
            this.ButtonAddDiceType.Text = "Add dice type";
            this.ButtonAddDiceType.UseMnemonic = false;
            this.ButtonAddDiceType.UseVisualStyleBackColor = false;
            this.ButtonAddDiceType.Click += new System.EventHandler(this.ButtonAddDiceType_Click);
            // 
            // ButtonResult
            // 
            this.ButtonResult.BackColor = System.Drawing.Color.Transparent;
            this.ButtonResult.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonResult.FlatAppearance.BorderSize = 0;
            this.ButtonResult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.ButtonResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonResult.ForeColor = System.Drawing.Color.PeachPuff;
            this.ButtonResult.Image = global::RandomGenerator.Properties.Resources._8357a3f1824f652;
            this.ButtonResult.Location = new System.Drawing.Point(562, 93);
            this.ButtonResult.Name = "ButtonResult";
            this.ButtonResult.Size = new System.Drawing.Size(116, 27);
            this.ButtonResult.TabIndex = 2;
            this.ButtonResult.TabStop = false;
            this.ButtonResult.Text = "Result";
            this.ButtonResult.UseMnemonic = false;
            this.ButtonResult.UseVisualStyleBackColor = false;
            this.ButtonResult.Click += new System.EventHandler(this.ButtonResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(133, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Decision helper";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.PeachPuff;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(21, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add option";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Decide
            // 
            this.Decide.FlatAppearance.BorderSize = 0;
            this.Decide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decide.ForeColor = System.Drawing.Color.PeachPuff;
            this.Decide.Image = ((System.Drawing.Image)(resources.GetObject("Decide.Image")));
            this.Decide.Location = new System.Drawing.Point(318, 415);
            this.Decide.Name = "Decide";
            this.Decide.Size = new System.Drawing.Size(103, 29);
            this.Decide.TabIndex = 5;
            this.Decide.Text = "Decide";
            this.Decide.UseVisualStyleBackColor = true;
            this.Decide.Click += new System.EventHandler(this.Decide_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.PeachPuff;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(160, 462);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "Clear options";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.PeachPuff;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(318, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "Simple coinflip";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OptionsListBox
            // 
            this.OptionsListBox.BackColor = System.Drawing.Color.Maroon;
            this.OptionsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OptionsListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.OptionsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsListBox.ForeColor = System.Drawing.Color.Gold;
            this.OptionsListBox.FormattingEnabled = true;
            this.OptionsListBox.ItemHeight = 16;
            this.OptionsListBox.Location = new System.Drawing.Point(160, 415);
            this.OptionsListBox.Name = "OptionsListBox";
            this.OptionsListBox.Size = new System.Drawing.Size(113, 32);
            this.OptionsListBox.TabIndex = 8;
            this.OptionsListBox.TabStop = false;
            this.OptionsListBox.UseTabStops = false;
            // 
            // DecisionResultLabel
            // 
            this.DecisionResultLabel.AutoSize = true;
            this.DecisionResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.DecisionResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecisionResultLabel.Location = new System.Drawing.Point(437, 418);
            this.DecisionResultLabel.Name = "DecisionResultLabel";
            this.DecisionResultLabel.Size = new System.Drawing.Size(24, 26);
            this.DecisionResultLabel.TabIndex = 9;
            this.DecisionResultLabel.Text = "0";
            // 
            // CoinflipResultLabel
            // 
            this.CoinflipResultLabel.AutoSize = true;
            this.CoinflipResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.CoinflipResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoinflipResultLabel.Location = new System.Drawing.Point(437, 458);
            this.CoinflipResultLabel.Name = "CoinflipResultLabel";
            this.CoinflipResultLabel.Size = new System.Drawing.Size(24, 26);
            this.CoinflipResultLabel.TabIndex = 10;
            this.CoinflipResultLabel.Text = "0";
            // 
            // EnterOptionTextbox
            // 
            this.EnterOptionTextbox.BackColor = System.Drawing.Color.PeachPuff;
            this.EnterOptionTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnterOptionTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterOptionTextbox.Location = new System.Drawing.Point(19, 414);
            this.EnterOptionTextbox.Name = "EnterOptionTextbox";
            this.EnterOptionTextbox.Size = new System.Drawing.Size(114, 24);
            this.EnterOptionTextbox.TabIndex = 3;
            this.EnterOptionTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterOptionTextbox_KeyDown);
            // 
            // ButtonRemoveDiceType
            // 
            this.ButtonRemoveDiceType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonRemoveDiceType.Enabled = false;
            this.ButtonRemoveDiceType.FlatAppearance.BorderSize = 0;
            this.ButtonRemoveDiceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRemoveDiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRemoveDiceType.ForeColor = System.Drawing.Color.PeachPuff;
            this.ButtonRemoveDiceType.Image = global::RandomGenerator.Properties.Resources._8357a3f1824f652;
            this.ButtonRemoveDiceType.Location = new System.Drawing.Point(139, 93);
            this.ButtonRemoveDiceType.Name = "ButtonRemoveDiceType";
            this.ButtonRemoveDiceType.Size = new System.Drawing.Size(120, 27);
            this.ButtonRemoveDiceType.TabIndex = 16;
            this.ButtonRemoveDiceType.TabStop = false;
            this.ButtonRemoveDiceType.Text = "Remove dice type";
            this.ButtonRemoveDiceType.UseMnemonic = false;
            this.ButtonRemoveDiceType.UseVisualStyleBackColor = false;
            this.ButtonRemoveDiceType.Click += new System.EventHandler(this.ButtonRemoveDiceType_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.BackColor = System.Drawing.Color.Transparent;
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(401, 15);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(77, 26);
            this.Output.TabIndex = 19;
            this.Output.Text = "Output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 52);
            this.label2.TabIndex = 18;
            this.label2.Text = "Amount of\r\n    dices";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Dice type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Enter options";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Option List";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(344, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Go!";
            // 
            // LabelVersionNumber
            // 
            this.LabelVersionNumber.AutoSize = true;
            this.LabelVersionNumber.BackColor = System.Drawing.Color.Transparent;
            this.LabelVersionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVersionNumber.Location = new System.Drawing.Point(652, 485);
            this.LabelVersionNumber.Name = "LabelVersionNumber";
            this.LabelVersionNumber.Size = new System.Drawing.Size(37, 16);
            this.LabelVersionNumber.TabIndex = 21;
            this.LabelVersionNumber.Text = "V 1.0";
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::RandomGenerator.Properties.Resources.mystic_background_by_lirdrak_d712xh4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(690, 501);
            this.Controls.Add(this.LabelVersionNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonRemoveDiceType);
            this.Controls.Add(this.EnterOptionTextbox);
            this.Controls.Add(this.CoinflipResultLabel);
            this.Controls.Add(this.DecisionResultLabel);
            this.Controls.Add(this.OptionsListBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Decide);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.ButtonResult);
            this.Controls.Add(this.ButtonAddDiceType);
            this.Controls.Add(this.ListboxResultOutput);
            this.Controls.Add(this.TextboxDiceAmount);
            this.Controls.Add(this.ComboBoxDiceSides);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Generator for Pen & Paper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextboxDiceAmount;
        private System.Windows.Forms.ListBox ListboxResultOutput;
        private System.Windows.Forms.Button ButtonAddDiceType;
        private System.Windows.Forms.Button ButtonResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Decide;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox OptionsListBox;
        private System.Windows.Forms.Label DecisionResultLabel;
        private System.Windows.Forms.Label CoinflipResultLabel;
        private System.Windows.Forms.TextBox EnterOptionTextbox;
        private System.Windows.Forms.Button ButtonRemoveDiceType;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboBoxDiceSides;
        private System.Windows.Forms.Label LabelVersionNumber;
    }
}

