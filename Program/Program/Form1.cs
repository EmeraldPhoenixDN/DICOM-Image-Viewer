using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Program
{
   /* class Segment
    {
        public Pen Pen;
        public Point Point1, Point2;

        public Segment(Pen pen, Point point1, Point point2)
        {
            Pen = pen;
            Point1 = point1;
            Point2 = point2;
        }

        public void Draw(Graphics gr)
        {
            gr.DrawLine(Pen, Point1, Point2);
        }
    }*/

    public partial class Form1 : Form
    {
        Color CurrentColor = Color.Black;
        bool isPressed = false;
        bool Drow;
        Point lastPoint = Point.Empty;//Point.Empty represents null for a Point object
       /* private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isPressed = true;
            CurrentPoint = e.Location;
        }*/
        Point CurrentPoint;
        Point PrevPoint;
        private Bitmap RotatedBitmap;
        Graphics g;

       
        
        private void paint_simple()
        {
            Pen p = new Pen(CurrentColor);
            g.DrawLine(p, PrevPoint, CurrentPoint);
        }
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();

        }
        private bool SelectingArea = false;
        private Point StartPoint, EndPoint;

        // Start drawing.
      /*  private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = e.Location;
            EndPoint = e.Location;
            SelectingArea = true;
            pictureBox1.Cursor = Cursors.Cross;

            // Refresh.
            pictureBox1.Refresh();
        }
        */
        // Continue drawing.
       
        // Continue drawing.
     /*   private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            SelectingArea = false;
            pictureBox1.Cursor = Cursors.Default;

            // Do something with the selection rectangle.
            Rectangle rect = MakeRectangle(StartPoint, EndPoint);
            Console.WriteLine(rect.ToString());
        }
        */
        // Draw the selection rectangle.
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (SelectingArea)
            {
                using (Pen pen = new Pen(Color.Yellow, 2))
                {
                    e.Graphics.DrawRectangle(pen,
                        MakeRectangle(StartPoint, EndPoint));

                    pen.Color = Color.Red;
                    pen.DashPattern = new float[] { 5, 5 };
                    e.Graphics.DrawRectangle(pen,
                        MakeRectangle(StartPoint, EndPoint));
                }
            }
            
        }

        // Make a rectangle from two points.
        private Rectangle MakeRectangle(Point p1, Point p2)
        {
            int x = Math.Min(p1.X, p2.X);
            int y = Math.Min(p1.Y, p2.Y);
            int width = Math.Abs(p1.X - p2.X);
            int height = Math.Abs(p1.Y - p2.Y);
            return new Rectangle(x, y, width, height);
        }
      
        public static Bitmap image;
        public static string full_name_of_image = "\0";
        public static UInt32[,] pixel;

        //открытие изображения
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    full_name_of_image = open_dialog.FileName;
                    image = new Bitmap(open_dialog.FileName);
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    //  this.Width = image.Width*2 + 100;
                    // this.Height = image.Height*2 + 175;
                    // this.pictureBox1.Size = image.Size;

                    pictureBox1.Image = image;
                    pictureBox2.Image = image;

                    pictureBox1.Invalidate(); //????
                    //получение матрицы с пикселями
                    pixel = new UInt32[image.Height, image.Width];
                    for (int y = 0; y < image.Height; y++)
                        for (int x = 0; x < image.Width; x++)
                            pixel[y, x] = (UInt32)(image.GetPixel(x, y).ToArgb());
                    image = (Bitmap)Bitmap.FromFile(open_dialog.FileName);
                    btnRotate.Enabled = true;

                }
                catch
                {
                    full_name_of_image = "\0";
                    DialogResult rezult = MessageBox.Show("Неможливо відкрити обраний файл",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //сохранение изображения
        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                //string format = full_name_of_image.Substring(full_name_of_image.Length - 4, 4);
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Зберегти зображення як...";
                savedialog.OverwritePrompt = true;
                savedialog.CheckPathExists = true;
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Неможливо зберегти зображення", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

      


        //яркость контрастность
        private void яркостьконтрастностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 BrightnessForm = new Form2(this);
            BrightnessForm.ShowDialog(); //just 'Show' for the control Form1
        }

        //цветовой Баланс
        private void цветовойБалансToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 ColorBalanceForm = new Form3(this);
            ColorBalanceForm.ShowDialog();
        }

        //Повышение резкости
        private void повыситьРезкостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (full_name_of_image != "\0")
            {
                pixel = Filter.matrix_filtration(image.Width, image.Height, pixel, Filter.N1, Filter.sharpness);
                FromPixelToBitmap();
                FromBitmapToScreen();
            }
        }

        //размыть
        private void размытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (full_name_of_image != "\0")
            {
                pixel = Filter.matrix_filtration(image.Width, image.Height, pixel, Filter.N2, Filter.blur);
                FromPixelToBitmap();
                FromBitmapToScreen();
            }
        }

        //преобразование из UINT32 to Bitmap
        public static void FromPixelToBitmap()
        {
            for (int y = 0; y < image.Height; y++)
                for (int x = 0; x < image.Width; x++)
                    image.SetPixel(x, y, Color.FromArgb((int)pixel[y, x]));
        }

        //преобразование из UINT32 to Bitmap по одному пикселю
        public static void FromOnePixelToBitmap(int x, int y, UInt32 pixel)
        {
            image.SetPixel(y, x, Color.FromArgb((int)pixel));
        }

        //вывод на экран
        public void FromBitmapToScreen()
        {
            pictureBox1.Image = image;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Refresh();
        }

     
        
       

        public static Bitmap RotateImage(Image image, PointF offset, float angle)
        {
            if (image == null)
                throw new ArgumentNullException("image");

            //create a new empty bitmap to hold rotated image
            Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            //make a graphics object from the empty bitmap
            Graphics g = Graphics.FromImage(rotatedBmp);

            //Put the rotation point in the center of the image
            g.TranslateTransform(offset.X, offset.Y);

            //rotate the image
            g.RotateTransform(angle);

            //move the image back
            g.TranslateTransform(-offset.X, -offset.Y);

            //draw passed in image onto graphics object
            g.DrawImage(image, new PointF(0, 0));

            return rotatedBmp;
        }


      
       
       

      

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox1.Refresh();
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {

            // Get the angle.
            float angle = float.Parse(txtAngle.Text);

            // Rotate.
            RotatedBitmap = RotateBitmap(image, angle);

            // Display the result.
            pictureBox1.Image = RotatedBitmap;

            // Size the form to fit.
            SizeForm();
        }

        // Return a bitmap rotated around its center.
        private Bitmap RotateBitmap(Bitmap bm, float angle)
        {
            // Make a Matrix to represent rotation by this angle.
            Matrix rotate_at_origin = new Matrix();
            rotate_at_origin.Rotate(angle);

            // Rotate the image's corners to see how big
            // it will be after rotation.
            PointF[] points =
            {
                new PointF(0, 0),
                new PointF(bm.Width, 0),
                new PointF(bm.Width, bm.Height),
                new PointF(0, bm.Height),
            };
            rotate_at_origin.TransformPoints(points);
            float xmin, xmax, ymin, ymax;
            GetPointBounds(points, out xmin, out xmax, out ymin, out ymax);

            // Make a bitmap to hold the rotated result.
            int wid = (int)Math.Round(xmax - xmin);
            int hgt = (int)Math.Round(ymax - ymin);
            Bitmap result = new Bitmap(wid, hgt);

            // Create the real rotation transformation.
            Matrix rotate_at_center = new Matrix();
            rotate_at_center.RotateAt(angle,
                new PointF(wid / 2f, hgt / 2f));

            // Draw the image onto the new bitmap rotated.
            using (Graphics gr = Graphics.FromImage(result))
            {
                // Use smooth image interpolation.
                gr.InterpolationMode = InterpolationMode.High;

                // Clear with the color in the image's upper left corner.
                gr.Clear(bm.GetPixel(0, 0));

                //// For debugging. (Makes it easier to see the background.)
                //gr.Clear(Color.LightBlue);

                // Set up the transformation to rotate.
                gr.Transform = rotate_at_center;

                // Draw the image centered on the bitmap.
                int x = (wid - bm.Width) / 2;
                int y = (hgt - bm.Height) / 2;
                gr.DrawImage(bm, x, y);
            }

            // Return the result bitmap.
            return result;
        }

        // Find the bounding rectangle for an array of points.
        private void GetPointBounds(PointF[] points, out float xmin, out float xmax, out float ymin, out float ymax)
        {
            xmin = points[0].X;
            xmax = xmin;
            ymin = points[0].Y;
            ymax = ymin;
            foreach (PointF point in points)
            {
                if (xmin > point.X) xmin = point.X;
                if (xmax < point.X) xmax = point.X;
                if (ymin > point.Y) ymin = point.Y;
                if (ymax < point.Y) ymax = point.Y;
            }
        }

        // Make sure the form is big enough to show the rotated image.
        private void SizeForm()
        {
            int wid = pictureBox1.Right + pictureBox1.Left;
            int hgt = pictureBox1.Bottom + pictureBox1.Left;
            this.ClientSize = new Size(
                Math.Max(wid, this.ClientSize.Width),
                Math.Max(hgt, this.ClientSize.Height));
        }
        [DllImport("User32.dll")]
        static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("User32.dll")]
        static extern int ReleaseDC(IntPtr hwnd, IntPtr dc);
        Color y = Color.Black;
        Boolean flag;
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            Pen p = new Pen(y, 2);
            SolidBrush br = new SolidBrush(y);
            Point prevLocMouse = new Point(e.X, e.Y);
            Graphics gr;
            if (flag)
            {
                pictureBox1.BackColor = Color.White;
                pictureBox1.Image = image;
                gr = Graphics.FromImage(pictureBox1.Image);
                //gr = pictureBox1.CreateGraphics();
                gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
              //  gr.FillRectangle(br, e.X, e.Y, trackBar1.Value, trackBar1.Value);
                Point mousePos = new Point(e.X, e.Y);
                gr.DrawLine(p, mousePos, prevLocMouse);
                prevLocMouse = mousePos;
                image= new Bitmap(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           

            /* IntPtr desktop = GetDC(IntPtr.Zero);
             using (Graphics g = Graphics.FromHdc(desktop))
             {
                 g.FillPath(Brushes.Red, pictureBox1);
             }
             ReleaseDC(IntPtr.Zero, desktop);*/
            /*  DialogResult D = colorDialog1.ShowDialog();
            if (D == System.Windows.Forms.DialogResult.OK)
                CurrentColor = colorDialog1.Color;*/
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Рисование кистью";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics Графика = pictureBox1.CreateGraphics();
            Графика.Clear(SystemColors.Window);
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics graf = pictureBox1.CreateGraphics();
            if (Drow == true)
            {
                graf.FillEllipse(Brushes.Violet, e.X, e.Y, 3, 3); // толщина кисти
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Drow = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Width = pictureBox1.Width /2;
            //pictureBox1.Height = pictureBox1.Height/2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
           // pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Width = pictureBox1.Width * 2;
        }

        private void гістограмаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (Process myProcess = new Process())
                {

                    Process.Start("howto_histogram_tooltips.exe");
                     myProcess.StartInfo.UseShellExecute = false;
                    // You can start any process, HelloWorld is a do-nothing example.
                     myProcess.StartInfo.FileName = "D:\\Учёба\\Диплом\\imagefilteringCODE\\Program\\Program\\bin\\Debug\\howto_histogram_tooltips.exe";
                   myProcess.StartInfo.CreateNoWindow = true;
                     myProcess.Start();
                    // This code assumes the process you are starting will terminate itself. 
                    // Given that is is started without a window so you cannot terminate it 
                    // on the desktop, it must terminate itself or you can do it programmatically
                    // from this application using the Kill method.
                }
            }
            catch (Exception w)
            {
                Console.WriteLine(w.Message);
            }
            /*
            //this.Hide();
            BrightGraph frm = new BrightGraph();
            frm.Show();*/
        }

        private void друкToolStripMenuItem_Click(object sender, EventArgs e)
        {
           PrintResult frm = new PrintResult();
           frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                using (Process myProcess = new Process())
                {

                  //  Process.Start("howto_histogram_tooltips.exe");
                    myProcess.StartInfo.UseShellExecute = false;
                    // You can start any process, HelloWorld is a do-nothing example.
                    myProcess.StartInfo.FileName = "D:\\Учёба\\Диплом\\imagefilteringCODE\\Program\\Program\\bin\\Debug\\howto_histogram_tooltips.exe";
                    myProcess.StartInfo.CreateNoWindow = true;
                    myProcess.Start();
                    
                    // This code assumes the process you are starting will terminate itself. 
                    // Given that is is started without a window so you cannot terminate it 
                    // on the desktop, it must terminate itself or you can do it programmatically
                    // from this application using the Kill method.
                }
            }
            catch (Exception w)
            {
                Console.WriteLine(w.Message);
            } }

        private void button8_Click(object sender, EventArgs e)
        {
            using (Process myProcess = new Process())
            {

                //  Process.Start("howto_histogram_tooltips.exe");
                myProcess.StartInfo.UseShellExecute = false;
                // You can start any process, HelloWorld is a do-nothing example.
                myProcess.StartInfo.FileName = "D:\\Учёба\\Диплом\\imagefilteringCODE\\Program\\Program\\bin\\Debug\\howto_histogram_tooltips.exe";
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.Start();

                // This code assumes the process you are starting will terminate itself. 
                // Given that is is started without a window so you cannot terminate it 
                // on the desktop, it must terminate itself or you can do it programmatically
                // from this application using the Kill method.
            }
        }



       
       /* private void button1_Click(object sender, EventArgs e)
        {

        }
        */


        }
   
 


}

