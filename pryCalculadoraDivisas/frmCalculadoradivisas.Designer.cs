namespace pryCalculadoraDivisas
{
    partial class frmCalculadoraDivisas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadoraDivisas));
            cmbTipoCambio = new ComboBox();
            txtCantidad = new TextBox();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            lblResultado = new Label();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbTipoCambio
            // 
            cmbTipoCambio.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            cmbTipoCambio.FormattingEnabled = true;
            cmbTipoCambio.Items.AddRange(new object[] { "Peso Mexicano a Dolar", "Dolar a Peso Mexicano", "Peso Mexicano a Euro", "Euro a Peso Mexicano" });
            cmbTipoCambio.Location = new Point(738, 301);
            cmbTipoCambio.Name = "cmbTipoCambio";
            cmbTipoCambio.Size = new Size(312, 44);
            cmbTipoCambio.TabIndex = 1;
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            txtCantidad.Location = new Point(265, 303);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.PlaceholderText = "0.00";
            txtCantidad.Size = new Size(257, 42);
            txtCantidad.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1011, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = SystemColors.ButtonHighlight;
            lblTitulo.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold);
            lblTitulo.Location = new Point(412, 124);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(463, 57);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Calculadora de divisas";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblResultado.Location = new Point(556, 414);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(152, 37);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "Resultado:";
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(541, 476);
            button1.Name = "button1";
            button1.Size = new Size(180, 59);
            button1.TabIndex = 8;
            button1.Text = "Convertir";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.Location = new Point(265, 236);
            label1.Name = "label1";
            label1.Size = new Size(268, 37);
            label1.TabIndex = 9;
            label1.Text = "Ingrese la cantidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label2.Location = new Point(738, 236);
            label2.Name = "label2";
            label2.Size = new Size(294, 37);
            label2.TabIndex = 10;
            label2.Text = "Seleccione la moneda";
            // 
            // frmCalculadoraDivisas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1218, 725);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(lblResultado);
            Controls.Add(lblTitulo);
            Controls.Add(pictureBox1);
            Controls.Add(txtCantidad);
            Controls.Add(cmbTipoCambio);
            DoubleBuffered = true;
            Name = "frmCalculadoraDivisas";
            Text = "frmCalculadoraDivisas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTipoCambio;
        private TextBox txtCantidad;
        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Label lblResultado;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}
