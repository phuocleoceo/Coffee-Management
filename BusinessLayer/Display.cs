using System.Windows.Forms;
using System.Drawing;
namespace BusinessLayer
{
    public class Display
    {
        //Make DataGridView Beautiful (Form Admin)
        public static void FormatTable(DataGridView dgv)
        {
            //dgv.RowTemplate.Height = 30;
            dgv.DefaultCellStyle.Font = new Font("Cambria", 12);
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightPink;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 12);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        //Make DataGridView Beautiful (Form Table)
        public static void FormatMiniTable(DataGridView dgv)
        {
            //dgv.RowTemplate.Height = 30;
            dgv.DefaultCellStyle.Font = new Font("Cambria", 12);
            //dgv.DefaultCellStyle.ForeColor = Color.Blue;
            //dgv.DefaultCellStyle.BackColor = Color.Beige;   //Beige
            //dgv.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            //dgv.DefaultCellStyle.SelectionBackColor = Color.Black;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 12);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Aqua;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Azure;
        }
        public static void FormatListViewTable(ListView lsv)
        {
            //lsv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lsv.Font = new Font("Cambria", 20);
            lsv.BackColor = System.Drawing.Color.WhiteSmoke;
            lsv.ForeColor = System.Drawing.Color.DarkOrange;
        }
    }
}
