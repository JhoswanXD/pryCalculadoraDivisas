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
            btnConvertir = new Button();
            lblResultado = new Label();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbTipoCambio
            // 
            cmbTipoCambio.Font = new Font("Segoe UI", 12F);
            cmbTipoCambio.FormattingEnabled = true;
            cmbTipoCambio.Items.AddRange(new object[] { "Peso Mexicano a Dolar", "Dolar a Peso Mexicano", "Peso Mexicano a Euro", "Euro a Peso Mexicano" });
            cmbTipoCambio.Location = new Point(654, 229);
            cmbTipoCambio.Name = "cmbTipoCambio";
            cmbTipoCambio.Size = new Size(223, 36);
            cmbTipoCambio.TabIndex = 1;
            cmbTipoCambio.Text = "Seleccione la moneda";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 12F);
            txtCantidad.Location = new Point(210, 231);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.PlaceholderText = "Ingrese la cantidad";
            txtCantidad.Size = new Size(223, 34);
            txtCantidad.TabIndex = 2;
            // 
            // btnConvertir
            // 
            btnConvertir.Font = new Font("Segoe UI", 12F);
            btnConvertir.Location = new Point(465, 391);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(144, 46);
            btnConvertir.TabIndex = 3;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F);
            lblResultado.Location = new Point(490, 317);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(98, 28);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Resultado";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonFace;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(925, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold);
            lblTitulo.Location = new Point(313, 113);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(463, 57);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Calculadora de divisas";
            // 
            // frmCalculadoraDivisas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1051, 620);
            Controls.Add(lblTitulo);
            Controls.Add(pictureBox1);
            Controls.Add(lblResultado);
            Controls.Add(btnConvertir);
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
        private Button btnConvertir;
        private Label lblResultado;
        private PictureBox pictureBox1;
        private Label lblTitulo;
    }
}
