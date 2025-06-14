using PaintingApp.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintingApp
{
    public partial class Form1: Form
    {
        List<Shape> shapes = new List<Shape>();
        Shape currentShape = null;
        Shape selectedShape = null;
        Color selectedColor = Color.Red;
        string selectedShapeType = "Rectangle";

        bool isDrawing = false;
        bool isSelecting = false;

        Point lastMousePosition;
        bool isDragging = false; //sürükleme islemi yapmak icin
        bool isMoveMode = false; 

        public Form1()
        {
            InitializeComponent();
        }


        private void btn_select_Click(object sender, EventArgs e)
        {
            isMoveMode = !isMoveMode;

            //butuon aktif mi??
            btn_select.BackColor = isMoveMode ? Color.LightGray : SystemColors.Control;

            //mod degisirse secili seklikapat
            selectedShape = null;
            isDragging = false;
            isDrawing = false;
            currentShape = null;

            foreach (var shape in shapes)
            {
                shape.IsSelected = false;
            }
            panelDraw.Invalidate();
        }

        private void btn_trash_Click(object sender, EventArgs e)
        {
            if (selectedShape != null)
            {
                shapes.Remove(selectedShape);
                selectedShape = null;
                panelDraw.Invalidate();
            }
        }

        private void btn_deleteAll_Click(object sender, EventArgs e)
        {
            shapes.Clear();
            currentShape = null;
            selectedShape=null;
            panelDraw.Invalidate();
        }

     

        //private void btn_file_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    openFileDialog.Filter = "Jpeg Image|*.jpg|Bitmap Image|*.bmp|All Files|*.*";
        //    openFileDialog.Title = "Open an image file";

        //    if (openFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        try
        //        {
        //            // Seçilen resmi Image olarak yükle
        //            Image img = Image.FromFile(openFileDialog.FileName);

        //            // board kontrolündeki resmi güncelle
        //            panelDraw.Image = new Bitmap(img);

        //            // Panel ya da board'u tekrar çiz
        //            panelDraw.Invalidate();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Dosya açılamadı: " + ex.Message);
        //        }
        //    }
        //}

        //private void btn_save_Click(object sender, EventArgs e)
        //{
        //    SaveFileDialog sdf = new SaveFileDialog();
        //    sdf.Filter = "Png Image|*.Png|Bitmap Image| *.bmp";
        //    sdf.Title = "Save an image file";
        //    sdf.ShowDialog();

        //    if (sdf.FileName != " ")
        //    {
        //        System.IO.FileStream fs = (System.IO.FileStream)sdf.OpenFile();
        //        switch (sdf.FilterIndex)
        //        {
        //            case 1:
        //                this.panelDraw.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
        //                break;
        //            case 2:
        //                this.panelDraw.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
        //                break;
        //        }

        //        fs.Close();
        //    }


        //    MessageBox.Show("Drawing saved succesfully!", "Save",
        //                    MessageBoxButtons.OK, MessageBoxIcon.Information);

        //}

        private void btn_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                shapes.Clear(); // Mevcut çizimleri temizle

                string[] lines = File.ReadAllLines(ofd.FileName);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 6)
                    {
                        string type = parts[0];
                        int x1 = int.Parse(parts[1]);
                        int y1 = int.Parse(parts[2]);
                        int x2 = int.Parse(parts[3]);
                        int y2 = int.Parse(parts[4]);
                        Color color = Color.FromArgb(int.Parse(parts[5]));

                        Shape shape = null;

                        switch (type)
                        {
                            case "RectangleShape":
                                shape = new RectangleShape();
                                break;
                            case "CircleShape":
                                shape = new CircleShape();
                                break;
                            case "TriangleShape":
                                shape = new TriangleShape();
                                break;
                            case "HexagonShape":
                                shape = new HexagonShape();
                                break;
                        }

                        if (shape != null)
                        {
                            shape.StartPoint = new Point(x1, y1);
                            shape.EndPoint = new Point(x2, y2);
                            shape.Color = color;
                            shapes.Add(shape);
                        }
                    }
                }

                panelDraw.Invalidate(); // Paneli yeniden çiz
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Text Dosyası|*.txt|Tüm Dosyalar|*.*";
                saveDialog.DefaultExt = "txt";
                saveDialog.Title = "Çizimi Kaydet";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    var lines = shapes.Select(s => s.Serialize()).ToList();
                    File.WriteAllLines(saveDialog.FileName, lines, Encoding.UTF8);

                    MessageBox.Show("Dosya başarıyla kaydedildi!", "Başarılı",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kaydetme hatası: {ex.Message}", "Hata",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DisableMoveMode()
        {
            if (isMoveMode)
            {
                isMoveMode = false;
                btn_select.BackColor = SystemColors.Control;

                selectedShape = null;
                isDragging = false;
                isDrawing = false;
                currentShape = null;

                foreach (var shape in shapes)
                {
                    shape.IsSelected = false;
                }
                panelDraw.Invalidate();
            }
        }

        private void ShapeButton_Click(object sender, EventArgs e)
        {
            DisableMoveMode();

            Button btn = sender as Button;
            if (btn != null)
                selectedShapeType = btn.Tag.ToString();
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            DisableMoveMode();
            Button btn = sender as Button;
            selectedColor = btn.BackColor;
        }

        private void panelDraw_MouseDown(object sender, MouseEventArgs e)
        {

            // tasima modu aktifse sekil sec ve surukle
            if (isMoveMode)
            {

                foreach (var shape in shapes)
                {
                    shape.IsSelected = false;
                }


                selectedShape = null;
                isDragging = false;

                for (int i = shapes.Count - 1; i >= 0; i--) //ustteki sekilleri önce kontrol etsin diye sondan basa dogru kontrol ediyorum.(stack gibi davranıyor)
                {
                    if (shapes[i].Contains(e.Location))
                    {
                        selectedShape = shapes[i];
                        shapes[i].IsSelected = true;
                        isDragging = true;
                        lastMousePosition = e.Location;
                        break;
                    }
                }

                panelDraw.Invalidate();
                return; // tasima modu aktifse cizim yapma
            }

            //taşıma modu kapalı sadece çizim yap
            if (!isMoveMode)
            {
                isDrawing = true;

                if (selectedShapeType == "Rectangle")
                    currentShape = new RectangleShape();
                else if (selectedShapeType == "Circle")
                    currentShape = new CircleShape();
                else if (selectedShapeType == "Triangle")
                    currentShape = new TriangleShape();
                else
                    currentShape = new HexagonShape();

                    currentShape.Color = selectedColor;
                currentShape.StartPoint = currentShape.EndPoint = e.Location;
            }
        }

        private void panelDraw_MouseMove(object sender, MouseEventArgs e)
        {
            // sekli surukleme islemi burda yapılır
            if (isMoveMode && isDragging && selectedShape != null)
            {
                int dx = e.X - lastMousePosition.X;
                int dy = e.Y - lastMousePosition.Y;

                selectedShape.Move(dx, dy);
                lastMousePosition = e.Location;
                panelDraw.Invalidate();
                return;
            }

            // cizim modu aktif
            if (!isMoveMode && isDrawing && currentShape != null)
            {
                currentShape.EndPoint = e.Location;
                panelDraw.Invalidate();
            }
        }

        private void panelDraw_MouseUp(object sender, MouseEventArgs e)
        {
            // tasımayı dudur
            if (isMoveMode && isDragging)
            {
                isDragging = false;
                return;
            }

            // cizimi durdur
            if (!isMoveMode && isDrawing && currentShape != null)
            {
                currentShape.EndPoint = e.Location;
                shapes.Add(currentShape);
                currentShape = null;
                isDrawing = false;
                panelDraw.Invalidate();
            }
        }

        private void panelDraw_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (var shape in shapes)
                shape.Draw(g);

            if (!isMoveMode && isDrawing && currentShape != null)
                currentShape.Draw(g);
        }
    }
}
