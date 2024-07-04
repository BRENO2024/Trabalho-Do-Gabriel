namespace Trabalho_Do_Gabriel
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.labelR = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxV = new System.Windows.Forms.TextBox();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.labelM = new System.Windows.Forms.Label();
            this.labelV = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.labelFeedback = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(199, 72);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(100, 23);
            this.textBoxR.TabIndex = 0;
            this.textBoxR.TextChanged += new System.EventHandler(this.textBoxR_TextChanged);
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.BackColor = System.Drawing.Color.Transparent;
            this.labelR.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelR.ForeColor = System.Drawing.SystemColors.Control;
            this.labelR.Location = new System.Drawing.Point(91, 72);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(72, 15);
            this.labelR.TabIndex = 1;
            this.labelR.Text = "Valor de R:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(198, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "ENVIAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxV
            // 
            this.textBoxV.Location = new System.Drawing.Point(199, 272);
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.Size = new System.Drawing.Size(100, 23);
            this.textBoxV.TabIndex = 3;
            // 
            // textBoxG
            // 
            this.textBoxG.Location = new System.Drawing.Point(199, 362);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(100, 23);
            this.textBoxG.TabIndex = 4;
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.BackColor = System.Drawing.Color.Transparent;
            this.labelM.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelM.ForeColor = System.Drawing.SystemColors.Control;
            this.labelM.Location = new System.Drawing.Point(91, 173);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(76, 15);
            this.labelM.TabIndex = 5;
            this.labelM.Text = "Valor de M:";
            // 
            // labelV
            // 
            this.labelV.AutoSize = true;
            this.labelV.BackColor = System.Drawing.Color.Transparent;
            this.labelV.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelV.ForeColor = System.Drawing.Color.Transparent;
            this.labelV.Location = new System.Drawing.Point(91, 272);
            this.labelV.Name = "labelV";
            this.labelV.Size = new System.Drawing.Size(72, 15);
            this.labelV.TabIndex = 6;
            this.labelV.Text = "Valor de V:";
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.BackColor = System.Drawing.Color.Transparent;
            this.labelG.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelG.ForeColor = System.Drawing.Color.Transparent;
            this.labelG.Location = new System.Drawing.Point(90, 365);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(73, 15);
            this.labelG.TabIndex = 7;
            this.labelG.Text = "Valor de G:";
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(199, 170);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(100, 23);
            this.textBoxM.TabIndex = 8;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelResultado.Font = new System.Drawing.Font("Sitka Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelResultado.ForeColor = System.Drawing.Color.White;
            this.labelResultado.Location = new System.Drawing.Point(25, 448);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 39);
            this.labelResultado.TabIndex = 9;
            // 
            // labelFeedback
            // 
            this.labelFeedback.AutoSize = true;
            this.labelFeedback.BackColor = System.Drawing.Color.Transparent;
            this.labelFeedback.Font = new System.Drawing.Font("Source Code Pro Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFeedback.ForeColor = System.Drawing.Color.White;
            this.labelFeedback.Location = new System.Drawing.Point(313, 365);
            this.labelFeedback.Name = "labelFeedback";
            this.labelFeedback.Size = new System.Drawing.Size(75, 20);
            this.labelFeedback.TabIndex = 11;
            this.labelFeedback.Text = "......";
            this.labelFeedback.Click += new System.EventHandler(this.labelFeedback_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox1.Location = new System.Drawing.Point(62, 418);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(286, 49);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Ative para Calcular a MASSA,  \r\n\r\nAtive e desative para calcular a DENSIDADE";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SuperFrench", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(369, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "\"Digite a MASSA apenas se for calcular a Densidade\"\r\n                            " +
    "                         ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(313, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "------->";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1117, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFeedback);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.labelG);
            this.Controls.Add(this.labelV);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.textBoxG);
            this.Controls.Add(this.textBoxV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.textBoxR);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxR;
        private Label labelR;
        private Button button1;
        private TextBox textBoxV;
        private TextBox textBoxG;
        private Label labelM;
        private Label labelV;
        private Label labelG;
        private TextBox textBoxM;
        private Label labelResultado;
        private Label labelFeedback;
        private CheckBox checkBox1;
        private Label label1;
        private Label label2;
    }
}