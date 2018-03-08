using System;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Export;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors;
using System.IO;
using System.Drawing.Imaging;

namespace Presentacion
{
    public class exportarArchivos
    {
        public void ExportarExcel(GridControl g, string Titulo)
        {
            try
            {
                SaveFileDialog o = new SaveFileDialog();
                o.Filter = "Libro Excel|*.xlsx";
                o.ShowDialog();
                g.ExportToXlsx(o.FileName);
                MessageBox.Show(Titulo + " " + "exportados con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ExportarPDF(GridControl g, string Titulo)
        {
            try
            {
                SaveFileDialog o = new SaveFileDialog();
                o.Filter = "PDF|*.PDF";
                o.ShowDialog();
                g.ExportToPdf(o.FileName);
                MessageBox.Show(Titulo + " " + "exportados con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //public void ConvertirImagen(PictureEdit picture )
        //{
        //    try
        //    {
        //        MemoryStream ms = new MemoryStream();
        //        picture.Image.Save(ms, ImageFormat.Png);
        //        byte[] arregloFoto = ms.GetBuffer();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

    }
}
