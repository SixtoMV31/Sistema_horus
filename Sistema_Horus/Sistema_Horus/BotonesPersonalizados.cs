using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Horus
{
    internal class BotonesPersonalizados: Button
    {
        private int borderSize = 0;
        private int BorderRadius = 40;
        private Color BorderColor = Color.PaleVioletRed;

        public int BorderSize
        {
            get => borderSize; set
            {
                borderSize = value;
                Invalidate();
            }
        }
        public int BorderRadius1
        {
            get => BorderRadius; set
            {
                BorderRadius = value;
                Invalidate();
            }
        }
        public Color BorderColor1
        {
            get => BorderColor; set
            {
                BorderColor = value;
                Invalidate();
            }
        }


        public Color BackgroundColor
        {
            get { return BackColor; }
            set { BackColor = value; }
        }
        public Color TextColor
        {
            get { return ForeColor; }
            set { ForeColor = value; }
        }
        //constructor
        public BotonesPersonalizados()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Size = new Size(150, 40);
            BackColor = Color.MediumSlateBlue;
            ForeColor = Color.White;
        }

        //Método privado
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;

        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, Width, Height);
            RectangleF rectBoder = new RectangleF(1, 1, Width - 0, Height - 1);

            if (BorderRadius > 2) // Boton redondeado
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, BorderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBoder, BorderRadius - 1F))
                using (Pen penSurface = new Pen(Parent.BackColor, 2))
                using (Pen penBorder = new Pen(BorderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    //Superficie del botón
                    Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    // Border del botón
                    if (borderSize >= 1)
                    {
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                    }

                }
                //Para una buena calidad del boton en hd por decirlo de tal forma

            }
            else // Normal Boton
            {
                Region = new Region(rectSurface);
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(BorderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }
        //Si quiero cambiar el color en tiempo de ejecución puedo eliminar esta condición
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (DesignMode)
                Invalidate();
        }
    }
}
