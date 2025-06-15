using PaintingApp.Forms;
using PaintingApp.Helpers;
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

namespace PaintingApp.Forms
{
    public partial class MainForm: Form
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

        public MainForm()
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



        private void btn_upload_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openDialog = new OpenFileDialog())
                {
                    openDialog.Filter = "Paint Files (*.paint)|*.paint|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                    openDialog.FilterIndex = 1; 
                    openDialog.DefaultExt = "paint";
                    openDialog.Title = "Çizim Dosyası Seç";
                    openDialog.CheckFileExists = true;
                    openDialog.CheckPathExists = true;

                    if (openDialog.ShowDialog() == DialogResult.OK)
                    {
                        //dosyayi yukle
                        shapes = ShapeSerializer.Load(openDialog.FileName);

                        // formu yeniden ciz
                        panelDraw.Invalidate();
                        panelDraw.Refresh();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Dosya yüklenirken hata oluştu:\n{ex.Message}",
                              "Yükleme Hatası",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                //cizim yoksa uyar
                if (shapes == null || shapes.Count == 0)
                {
                    MessageBox.Show("Kaydedilecek şekil bulunamadı!",
                                  "Uyarı",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }

                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                  
                    saveDialog.Filter = "Paint Files (*.paint)|*.paint|Text Files (*.txt)|*.txt";
                    saveDialog.FilterIndex = 1; // default olarak paint ayarla
                    saveDialog.DefaultExt = "paint";
                    saveDialog.AddExtension = true;
                    saveDialog.Title = "Çizimi Kaydet";
                    saveDialog.FileName = "MyDrawing"; // default dosya adi

                    
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Dosyayı kaydet
                        ShapeSerializer.Save(shapes, saveDialog.FileName);

                        MessageBox.Show($"Çizim başarıyla kaydedildi!\nDosya: {saveDialog.FileName}",
                                      "Kaydetme Başarılı",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Dosya kaydedilirken hata oluştu:\n{ex.Message}",
                              "Kaydetme Hatası",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
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

        private void panelDraw_Click(object sender, EventArgs e)
        {

        }
    }
}
