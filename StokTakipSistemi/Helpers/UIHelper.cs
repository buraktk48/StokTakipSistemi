using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace StokTakipSistemi.Helpers
{
    public static class UIHelper
    {
        /// <summary>
        /// DataGridView tablolarını modern zebra desenli, koyu lacivert başlıklı tasarıma dönüştürür.
        /// </summary>
        public static void ModernizeDataGridView(DataGridView dgv)
        {
            if (dgv == null) return;

            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(226, 232, 240);
            dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(15, 23, 42);
            dgv.BackgroundColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 38;
            dgv.RowTemplate.Height = 32;
        }

        /// <summary>
        /// İstenen herhangi bir bileşenin (Buton, Panel vb.) köşelerini ovalleştirir.
        /// </summary>
        public static void SetRoundedRegion(Control control, int radius)
        {
            if (control == null || control.Width <= 0 || control.Height <= 0) return;

            Rectangle rect = new Rectangle(0, 0, control.Width, control.Height);
            using (GraphicsPath path = GetRoundedPath(rect, radius))
            {
                control.Region = new Region(path);
            }
        }

        /// <summary>
        /// Ovalleştirilmiş kavisli grafik yolu oluşturur.
        /// </summary>
        public static GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float diameter = radius * 2F;
            RectangleF arc = new RectangleF(rect.X, rect.Y, diameter, diameter);

            path.AddArc(arc, 180, 90);
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = rect.X;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        /// <summary>
        /// Panellerin etraflarına pürüzsüz kavisli gri çerçeve çizer (Paint olayı içinde çağrılır).
        /// </summary>
        public static void DrawCardBorder(object? sender, PaintEventArgs e, int radius = 12, float strokeWidth = 1.5f)
        {
            if (sender is Panel p)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Rectangle rect = new Rectangle(0, 0, p.Width - 1, p.Height - 1);
                using (GraphicsPath path = GetRoundedPath(rect, radius))
                {
                    using (Pen borderPen = new Pen(Color.FromArgb(226, 232, 240), strokeWidth))
                    {
                        e.Graphics.DrawPath(borderPen, path);
                    }
                }
            }
        }

        /// <summary>
        /// Bir kontrolü (panel, kart vb.) formun hem dikey hem yatay olarak tam göbeğine hizalar.
        /// </summary>
        public static void CenterControl(Form form, Control control, int topOffset = 15)
        {
            if (form == null || control == null || form.ClientSize.Width <= 0) return;

            control.Left = (form.ClientSize.Width - control.Width) / 2;
            control.Top = System.Math.Max(90, (form.ClientSize.Height - control.Height) / 2 + topOffset);
        }
    }
}
