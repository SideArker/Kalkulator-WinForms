
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.QuoteText = new System.Windows.Forms.Label();
            this.CalcNum1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CalcCE = new System.Windows.Forms.Button();
            this.CalcEq = new System.Windows.Forms.Button();
            this.CalcAdd = new System.Windows.Forms.Button();
            this.CalcSub = new System.Windows.Forms.Button();
            this.CalcDiv = new System.Windows.Forms.Button();
            this.CalcMult = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CalcNum9 = new System.Windows.Forms.Button();
            this.CalcNum7 = new System.Windows.Forms.Button();
            this.CalcNum6 = new System.Windows.Forms.Button();
            this.CalcNum5 = new System.Windows.Forms.Button();
            this.CalcNum4 = new System.Windows.Forms.Button();
            this.CalcNum3 = new System.Windows.Forms.Button();
            this.CalcNum2 = new System.Windows.Forms.Button();
            this.CalcSqrt = new System.Windows.Forms.Button();
            this.CalcC = new System.Windows.Forms.Button();
            this.CalcBck = new System.Windows.Forms.Button();
            this.CalcNum8 = new System.Windows.Forms.Button();
            this.CalcLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(40, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(430, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your quote for the day";
            // 
            // QuoteText
            // 
            this.QuoteText.BackColor = System.Drawing.Color.Transparent;
            this.QuoteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QuoteText.Location = new System.Drawing.Point(48, 81);
            this.QuoteText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuoteText.Name = "QuoteText";
            this.QuoteText.Size = new System.Drawing.Size(422, 449);
            this.QuoteText.TabIndex = 4;
            // 
            // CalcNum1
            // 
            this.CalcNum1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CalcNum1.CausesValidation = false;
            this.CalcNum1.Location = new System.Drawing.Point(6, 154);
            this.CalcNum1.Margin = new System.Windows.Forms.Padding(4);
            this.CalcNum1.Name = "CalcNum1";
            this.CalcNum1.Size = new System.Drawing.Size(72, 64);
            this.CalcNum1.TabIndex = 5;
            this.CalcNum1.Text = "1";
            this.CalcNum1.UseVisualStyleBackColor = false;
            this.CalcNum1.Click += new System.EventHandler(this.onCalcBtnClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.CalcCE, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.CalcEq, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.CalcAdd, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.CalcSub, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.CalcDiv, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.CalcMult, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.CalcNum9, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.CalcNum7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.CalcNum6, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.CalcNum5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.CalcNum4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.CalcNum3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.CalcNum2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CalcNum1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CalcSqrt, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.CalcC, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CalcBck, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.CalcNum8, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(140, 113);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(336, 449);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // CalcCE
            // 
            this.CalcCE.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CalcCE.Location = new System.Drawing.Point(172, 6);
            this.CalcCE.Margin = new System.Windows.Forms.Padding(4);
            this.CalcCE.Name = "CalcCE";
            this.CalcCE.Size = new System.Drawing.Size(72, 64);
            this.CalcCE.TabIndex = 19;
            this.CalcCE.Text = "CE";
            this.CalcCE.UseVisualStyleBackColor = false;
            this.CalcCE.Click += new System.EventHandler(this.onCalcBtnClick);
            // 
            // CalcEq
            // 
            this.CalcEq.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CalcEq.Location = new System.Drawing.Point(255, 376);
            this.CalcEq.Margin = new System.Windows.Forms.Padding(4);
            this.CalcEq.Name = "CalcEq";
            this.CalcEq.Size = new System.Drawing.Size(75, 67);
            this.CalcEq.TabIndex = 1;
            this.CalcEq.Text = "=";
            this.CalcEq.UseVisualStyleBackColor = false;
            this.CalcEq.Click += new System.EventHandler(this.onCalcBtnClick);
            // 
            // CalcAdd
            // 
            this.CalcAdd.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CalcAdd.Location = new System.Drawing.Point(255, 302);
            this.CalcAdd.Margin = new System.Windows.Forms.Padding(4);
            this.CalcAdd.Name = "CalcAdd";
            this.CalcAdd.Size = new System.Drawing.Size(75, 64);
            this.CalcAdd.TabIndex = 14;
            this.CalcAdd.Text = "+";
            this.CalcAdd.UseVisualStyleBackColor = false;
            this.CalcAdd.Click += new System.EventHandler(this.onCalcBtnClick);
            // 
            // CalcSub
            // 
            this.CalcSub.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CalcSub.Location = new System.Drawing.Point(255, 228);
            this.CalcSub.Margin = new System.Windows.Forms.Padding(4);
            this.CalcSub.Name = "CalcSub";
            this.CalcSub.Size = new System.Drawing.Size(75, 64);
            this.CalcSub.TabIndex = 15;
            this.CalcSub.Text = "-";
            this.CalcSub.UseVisualStyleBackColor = false;
            this.CalcSub.Click += new System.EventHandler(this.onCalcBtnClick);
            // 
            // CalcDiv
            // 
            this.CalcDiv.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CalcDiv.Location = new System.Drawing.Point(255, 154);
            this.CalcDiv.Margin = new System.Windows.Forms.Padding(4);
            this.CalcDiv.Name = "CalcDiv";
            this.CalcDiv.Size = new System.Drawing.Size(75, 64);
            this.CalcDiv.TabIndex = 17;
            this.CalcDiv.Text = "/";
            this.CalcDiv.UseVisualStyleBackColor = false;
            this.CalcDiv.Click += new System.EventHandler(this.onCalcBtnClick);
            // 
            // CalcMult
            // 
            this.CalcMult.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CalcMult.Location = new System.Drawing.Point(255, 80);
            this.CalcMult.Margin = new System.Windows.Forms.Padding(4);
            this.CalcMult.Name = "CalcMult";
            this.CalcMult.Size = new System.Drawing.Size(75, 64);
            this.CalcMult.TabIndex = 16;
            this.CalcMult.Text = "x";
            this.CalcMult.UseVisualStyleBackColor = false;
            this.CalcMult.Click += new System.EventHandler(this.onCalcBtnClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(89, 376);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 67);
            this.button2.TabIndex = 21;
            this.button2.Text = "0";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.onCalcBtnClick);
            // 
            // CalcNum9
            // 
            this.CalcNum9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CalcNum9.Location = new System.Drawing.Point(172, 302);
            this.CalcNum9.Margin = new System.Windows.Forms.Padding(4);
            this.CalcNum9.Name = "CalcNum9";
            this.CalcNum9.Size = new System.Drawing.Size(72, 64);
            this.CalcNum9.TabIndex = 13;
            this.CalcNum9.Text = "9";
            this.CalcNum9.UseVisualStyleBackColor = false;
            this.CalcNum9.Click += new System.EventHandler(this.onCalcBtnClick);
            // 
            // CalcNum7
            // 
            this.CalcNum7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CalcNum7.Location = new System.Drawing.Point(6, 302);
            this.CalcNum7.Margin = new System.Windows.Forms.Padding(4);
            this.CalcNum7.Name = "CalcNum7";
            this.CalcNum7.Size = new System.Drawing.Size(72, 64);
            this.CalcNum7.TabIndex = 11;
            this.CalcNum7.Text = "7";
            this.CalcNum7.UseVisualStyleBackColor = false;
            this.CalcNum7.Click += new System.EventHandler(this.onCalcBtnClick);
            // 
            // CalcNum6
            // 
            this.CalcNum6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CalcNum6.Location = new System.Drawing.Point(172, 228);
            this.CalcNum6.Margin = new System.Windows.Forms.Padding(4);
            this.CalcNum6.Name = "CalcNum6";
            this.CalcNum6.Size = new System.Drawing.Size(72, 64);
            this.CalcNum6.TabIndex = 10;
            this.CalcNum6.Text = "6";
            this.CalcNum6.UseVisualStyleBackColor = false;
            this.CalcNum6.Click += new System.EventHandler(this.onCalcBtnClick);
            // 
            // CalcNum5
            // 
            this.CalcNum5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CalcNum5.Location = new System.Drawing.Point(89, 228);
            this.CalcNum5.Margin = new System.Windows.Forms.Padding(4);
            this.CalcNum5.Name = "CalcNum5";
            this.CalcNum5.Size = new System.Drawing.Size(72, 64);
            this.CalcNum5.TabIndex = 9;
            this.CalcNum5.Text = "5";
            this.CalcNum5.UseVisualStyleBackColor = false;
            this.CalcNum5.Click += new System.EventHandler(this.onCalcBtnClick);
            // 
            // CalcNum4
            // 
            this.CalcNum4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CalcNum4.Location = new System.Drawing.Point(6, 228);
            this.CalcNum4.Margin = new System.Windows.Forms.Padding(4);
            this.CalcNum4.Name = "CalcNum4";
            this.CalcNum4.Size = new System.Drawing.Size(72, 64);
            this.CalcNum4.TabIndex = 8;
            this.CalcNum4.Text = "4";
            this.CalcNum4.UseVisualStyleBackColor = false;
            this.CalcNum4.Click += new System.EventHandler(this.onCalcBtnClick);
            // 
            // CalcNum3
            // 
            this.CalcNum3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CalcNum3.Location = new System.Drawing.Point(172, 154);
            this.CalcNum3.Margin = new System.Windows.Forms.Padding(4);
            this.CalcNum3.Name = "CalcNum3";
            this.CalcNum3.Size = new System.Drawing.Size(72, 64);
            this.CalcNum3.TabIndex = 7;
            this.CalcNum3.Text = "3";
            this.CalcNum3.UseVisualStyleBackColor = false;
            this.CalcNum3.Click += new System.EventHandler(this.onCalcBtnClick);
            // 
            // CalcNum2
            // 
            this.CalcNum2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CalcNum2.Location = new System.Drawing.Point(89, 154);
            this.CalcNum2.Margin = new System.Windows.Forms.Padding(4);
            this.CalcNum2.Name = "CalcNum2";
            this.CalcNum2.Size = new System.Drawing.Size(72, 64);
            this.CalcNum2.TabIndex = 6;
            this.CalcNum2.Text = "2";
            this.CalcNum2.UseVisualStyleBackColor = false;
            this.CalcNum2.Click += new System.EventHandler(this.onCalcBtnClick);
            // 
            // CalcSqrt
            // 
            this.CalcSqrt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CalcSqrt.Location = new System.Drawing.Point(172, 80);
            this.CalcSqrt.Margin = new System.Windows.Forms.Padding(4);
            this.CalcSqrt.Name = "CalcSqrt";
            this.CalcSqrt.Size = new System.Drawing.Size(72, 64);
            this.CalcSqrt.TabIndex = 22;
            this.CalcSqrt.Text = "√";
            this.CalcSqrt.UseVisualStyleBackColor = false;
            this.CalcSqrt.Click += new System.EventHandler(this.onCalcBtnClick);
            // 
            // CalcC
            // 
            this.CalcC.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CalcC.Location = new System.Drawing.Point(89, 6);
            this.CalcC.Margin = new System.Windows.Forms.Padding(4);
            this.CalcC.Name = "CalcC";
            this.CalcC.Size = new System.Drawing.Size(72, 64);
            this.CalcC.TabIndex = 20;
            this.CalcC.Text = "C";
            this.CalcC.UseVisualStyleBackColor = false;
            this.CalcC.Click += new System.EventHandler(this.onCalcBtnClick);
            // 
            // CalcBck
            // 
            this.CalcBck.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CalcBck.Location = new System.Drawing.Point(255, 6);
            this.CalcBck.Margin = new System.Windows.Forms.Padding(4);
            this.CalcBck.Name = "CalcBck";
            this.CalcBck.Size = new System.Drawing.Size(75, 64);
            this.CalcBck.TabIndex = 23;
            this.CalcBck.Text = "←";
            this.CalcBck.UseVisualStyleBackColor = false;
            this.CalcBck.Click += new System.EventHandler(this.onCalcBtnClick);
            // 
            // CalcNum8
            // 
            this.CalcNum8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CalcNum8.Location = new System.Drawing.Point(89, 302);
            this.CalcNum8.Margin = new System.Windows.Forms.Padding(4);
            this.CalcNum8.Name = "CalcNum8";
            this.CalcNum8.Size = new System.Drawing.Size(72, 64);
            this.CalcNum8.TabIndex = 12;
            this.CalcNum8.Text = "8";
            this.CalcNum8.UseVisualStyleBackColor = false;
            this.CalcNum8.Click += new System.EventHandler(this.onCalcBtnClick);
            // 
            // CalcLabel
            // 
            this.CalcLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CalcLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CalcLabel.Location = new System.Drawing.Point(140, 81);
            this.CalcLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CalcLabel.Name = "CalcLabel";
            this.CalcLabel.Size = new System.Drawing.Size(335, 28);
            this.CalcLabel.TabIndex = 7;
            this.CalcLabel.Text = "Enter number:";
            this.CalcLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.CalcLabel);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 692);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.QuoteText);
            this.panel2.Location = new System.Drawing.Point(716, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(515, 714);
            this.panel2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 714);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label QuoteText;
        private System.Windows.Forms.Button CalcNum1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button CalcNum6;
        private System.Windows.Forms.Button CalcNum5;
        private System.Windows.Forms.Button CalcNum4;
        private System.Windows.Forms.Button CalcNum3;
        private System.Windows.Forms.Button CalcNum2;
        private System.Windows.Forms.Button CalcNum9;
        private System.Windows.Forms.Button CalcNum8;
        private System.Windows.Forms.Button CalcNum7;
        private System.Windows.Forms.Button CalcAdd;
        private System.Windows.Forms.Button CalcSub;
        private System.Windows.Forms.Button CalcMult;
        private System.Windows.Forms.Button CalcDiv;
        private System.Windows.Forms.Button CalcEq;
        private System.Windows.Forms.Button CalcC;
        private System.Windows.Forms.Button CalcCE;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button CalcSqrt;
        private System.Windows.Forms.Button CalcBck;
        private System.Windows.Forms.Label CalcLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

