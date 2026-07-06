namespace pryCalculadoraDivisas
{
    partial class frmDivisas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDivisas));
            cmbMonedas = new ComboBox();
            txtCantidad = new TextBox();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            lblResultado = new Label();
            btnConvertir = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbMonedas
            // 
            cmbMonedas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMonedas.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            cmbMonedas.FormattingEnabled = true;
            cmbMonedas.Location = new Point(385, 220);
            cmbMonedas.Margin = new Padding(3, 2, 3, 2);
            cmbMonedas.Name = "cmbMonedas";
            cmbMonedas.Size = new Size(342, 38);
            cmbMonedas.TabIndex = 1;
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            txtCantidad.Location = new Point(88, 222);
            txtCantidad.Margin = new Padding(3, 2, 3, 2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.PlaceholderText = "0.00";
            txtCantidad.Size = new Size(225, 35);
            txtCantidad.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(721, 22);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = SystemColors.ButtonHighlight;
            lblTitulo.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold);
            lblTitulo.Location = new Point(311, 70);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(362, 45);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Calculadora de divisas";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblResultado.Location = new Point(372, 304);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(116, 30);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "Resultado:";
            // 
            // btnConvertir
            // 
            btnConvertir.BackColor = Color.DodgerBlue;
            btnConvertir.FlatStyle = FlatStyle.Flat;
            btnConvertir.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnConvertir.ForeColor = Color.White;
            btnConvertir.Location = new Point(808, 214);
            btnConvertir.Margin = new Padding(3, 2, 3, 2);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(158, 44);
            btnConvertir.TabIndex = 8;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = false;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.Location = new Point(88, 178);
            label1.Name = "label1";
            label1.Size = new Size(205, 30);
            label1.TabIndex = 9;
            label1.Text = "Ingrese la cantidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label2.Location = new Point(378, 178);
            label2.Name = "label2";
            label2.Size = new Size(231, 30);
            label2.TabIndex = 10;
            label2.Text = "Seleccione la moneda:";
            // 
            // frmDivisas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1066, 544);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConvertir);
            Controls.Add(lblResultado);
            Controls.Add(lblTitulo);
            Controls.Add(pictureBox1);
            Controls.Add(txtCantidad);
            Controls.Add(cmbMonedas);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmDivisas";
            Text = "frmCalculadoraDivisas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMonedas;
        private TextBox txtCantidad;
        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Label lblResultado;
        private Button btnConvertir;
        private Label label1;
        private Label label2;
    }
}
