using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Drawing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;


namespace ProyectoFinalProgramacion1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
          
        }
        
        private void lblCodigoArticulo_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            double Total = 0;//Creamos una variable para el subtotal de la compra de productos

            //Evaluamos la condicion si todos los campos estan completados
            if (nudCodArticulo.Text != "" && txtDescripcion.Text != "" && nudCantidad.Text != "" && nudPrecio.Text != "" && nudDescuento.Text != "" && nudFactura.Text !="" && txtRazonSocial.Text != "")
            {
                //Definimos el numero de fila del DataGridView
                int NumeroDeFila = dbView.Rows.Add();
                //Creamos un archivo en donde escribiremos el detalle y la cabeza de la factura
                FileStream ArchivoFactura = new FileStream("C:/Users/guido/OneDrive/Desktop/UAI/Segundo Cuatrimestre/PROGRAMACION I/Proyecto Final/PEDIDOS/ArchivoFactura.txt", FileMode.Append);
                StreamWriter EscritorArchivoFactura = new StreamWriter(ArchivoFactura);
                FileStream ArchivoDetalle = new FileStream("C:/Users/guido/OneDrive/Desktop/UAI/Segundo Cuatrimestre/PROGRAMACION I/Proyecto Final/PEDIDOS/ArchivoDetalle.txt", FileMode.Append);
                StreamWriter EscritorDetalle = new StreamWriter(ArchivoDetalle);

                String[] VectorRegistros = new String[0];
                string RegistroDetalle = "";
                                                                //Creamos las variables necesarias para guardar los datos en un archivo
                String[] VectorRegistroCabeza = new string[0];
                string RegistroCabeza = "";

                // Definimos los registros y los spliteamos
                RegistroDetalle = nudFactura.Value + ";"+nudCodArticulo.Value + ";" + txtDescripcion.Text + ";" + nudCantidad.Value + ";" + nudPrecio.Value + ";" + nudDescuento.Value;
                VectorRegistros = RegistroDetalle.Split(';');
               
                RegistroCabeza = nudFactura.Value + ";" + txtRazonSocial.Text;
                VectorRegistroCabeza = RegistroCabeza.Split(';');


                double Cantidad = Convert.ToDouble((string)VectorRegistros[3]);
                double Precio = Convert.ToDouble((string)VectorRegistros[4]); //Calculamos el subtotal de la compra de los productos
                double Descuento = Convert.ToDouble((string)VectorRegistros[5]);
                Total =  Precio*Cantidad-( Precio*Descuento / 100) *Cantidad;
             

                dbView.Rows[NumeroDeFila].Cells[0].Value = VectorRegistros[1];
                dbView.Rows[NumeroDeFila].Cells[1].Value = VectorRegistros[2];
                dbView.Rows[NumeroDeFila].Cells[2].Value = VectorRegistros[3];//Insertamos los datos a la grid view
                dbView.Rows[NumeroDeFila].Cells[3].Value = VectorRegistros[4];
                dbView.Rows[NumeroDeFila].Cells[4].Value = VectorRegistros[5];
                dbView.Rows[NumeroDeFila].Cells[5].Value = Total;

                RegistroDetalle = nudFactura.Value + ";" + nudCodArticulo.Value + ";" + txtDescripcion.Text + ";" + nudCantidad.Value + ";" + nudPrecio.Value + ";" + nudDescuento.Value + ";" + Total;
                // modificamos el registro de factura para poder guardar el subtotal
                
                nudCodArticulo.Value = 0;
                nudCantidad.Value = 0;
                txtDescripcion.Text = ""; //Limpiamos los campos
                nudCantidad.Value = 0;
                nudPrecio.Value = 0;
                nudDescuento.Value = 0;

                EscritorDetalle.WriteLine(RegistroDetalle);
                EscritorArchivoFactura.WriteLine(RegistroCabeza); //Guardamos en archivo txt los datos


                EscritorDetalle.Close();
                ArchivoDetalle.Close();
                EscritorArchivoFactura.Close();
                ArchivoFactura.Close();

            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            SaveFileDialog Guardar = new SaveFileDialog();
            Guardar.FileName = "Factura n° " + nudFactura.Value + ".pdf";
            Guardar.ShowDialog();

            string TextoArchivoImprimir = Properties.Resources.Plantilla.ToString();

            if(Guardar.ShowDialog() == DialogResult.OK) //si el dialogo que queremos guardar resulta ok ingresa aca
            {
                FileStream pdf = new FileStream(Guardar.FileName, FileMode.Append);
                Document documentPdf = new Document(PageSize.A4,25,25,25,25);
                PdfWriter escritorPdf = PdfWriter.GetInstance(documentPdf, pdf);

                documentPdf.Open();
                documentPdf.Add(new Phrase(TextoArchivoImprimir));

                StreamReader LecturaPdfaHTML = new StreamReader(pdf); // Creamos un SR para poder leer lo que dice el string texto
                XMLWorkerHelper.GetInstance().ParseXHtml(escritorPdf, documentPdf,LecturaPdfaHTML); //Para despues poder escribirlo en un formato html en un documento pdf mediante un lector

                documentPdf.Close();
                pdf.Close();

                
            }

        }
    }
}
