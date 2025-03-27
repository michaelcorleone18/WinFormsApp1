namespace WinFormsApp1
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
            button1 = new Button();
            lbl_sonuc = new Label();
            kullanıcı_veri = new TextBox();
            cocombo = new ComboBox();
            kullanıcı_veri2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(636, 318);
            button1.Name = "button1";
            button1.Size = new Size(152, 130);
            button1.TabIndex = 0;
            button1.Text = "buton1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbl_sonuc
            // 
            lbl_sonuc.Font = new Font("Calibri", 25.8000011F, FontStyle.Italic, GraphicsUnit.Point, 162);
            lbl_sonuc.Location = new Point(3, 9);
            lbl_sonuc.Name = "lbl_sonuc";
            lbl_sonuc.Size = new Size(564, 57);
            lbl_sonuc.TabIndex = 1;
            lbl_sonuc.Text = "manuş babaya koydum yar";
            // 
            // kullanıcı_veri
            // 
            kullanıcı_veri.Location = new Point(21, 139);
            kullanıcı_veri.Name = "kullanıcı_veri";
            kullanıcı_veri.Size = new Size(302, 27);
            kullanıcı_veri.TabIndex = 2;
            // 
            // cocombo
            // 
            cocombo.FormattingEnabled = true;
            cocombo.Items.AddRange(new object[] { "+", "-", "x", "/" });
            cocombo.Location = new Point(317, 257);
            cocombo.Name = "cocombo";
            cocombo.Size = new Size(151, 28);
            cocombo.TabIndex = 3;
            // 
            // kullanıcı_veri2
            // 
            kullanıcı_veri2.Location = new Point(371, 139);
            kullanıcı_veri2.Name = "kullanıcı_veri2";
            kullanıcı_veri2.ScrollBars = ScrollBars.Vertical;
            kullanıcı_veri2.Size = new Size(302, 27);
            kullanıcı_veri2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(kullanıcı_veri2);
            Controls.Add(cocombo);
            Controls.Add(kullanıcı_veri);
            Controls.Add(lbl_sonuc);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lbl_sonuc;
        private TextBox kullanıcı_veri;
        private ComboBox cocombo;
        private TextBox kullanıcı_veri2;
    }
}
