using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazlab1_GoruntuIslemeEditoru
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        bool validData;
        string path;
        Thread getImageThread;
        Bitmap bmpFirstImage;
        Bitmap bmpOperation;
        int counterOperation = -1;
        int counterFirstImage = 0;
        int closeCount = 0;
        bool darkTheme = false;
        bool isSave = false;
        LinkedList<Bitmap> OperationsList = new LinkedList<Bitmap>();
        int[] histogramR = new int[256];
        int[] histogramG = new int[256];
        int[] histogramB = new int[256];
        int[] histogramGray = new int[256];
        
        public void AddOperation(Bitmap bmp)
        {
            counterOperation++;
            if(counterOperation>10)
            {
                counterOperation--;
                OperationsList.RemoveFirst();
                OperationsList.AddLast(bmp);
            }
            else
                OperationsList.AddLast(bmp);
        }
        public bool HasMainImage()
        {
            if (PictureBoxMain.Image != null)
                return true;
            return false;
        }
        public bool ControlScalingTxt()
        {
            if (TxtScalingX.Text != null && TxtScalingY.Text != null)
                return true;
            return false;
        }
        public Bitmap GetMainImage()
        {
            Bitmap bmp = new Bitmap(PictureBoxMain.Image);
            return bmp;
        }
        public Bitmap GetChannelImage()
        {
            return bmpOperation;
        }
        public void SetResultImage(Bitmap bmp)
        {
            PictureBoxMain.Image = bmp;
            isSave = false;
        }
        public void SetOperationImage(Bitmap bmp)
        {
            bmpOperation = bmp;
        }
        public void SetDisabledUndoRedo()
        {
            if (counterOperation == -1)
            {
                BtnDoUndo.Enabled = false;
                MenuUndo.Enabled = false;
                BtnDoRedo.Enabled = true;
                MenuRedo.Enabled = true;
            }
            else if(counterOperation == OperationsList.Count()-1)
            {
                BtnDoUndo.Enabled = true;
                MenuUndo.Enabled = true;
                BtnDoRedo.Enabled = false;
                MenuRedo.Enabled = false;
            }
            else
            {
                BtnDoUndo.Enabled = true;
                BtnDoRedo.Enabled = true;
                MenuRedo.Enabled = true;
                MenuUndo.Enabled = true;
            }
        }
        public Bitmap GetFirstImage()
        {
            return bmpFirstImage;
        }
        public void SetFirstImage()
        {
            bmpFirstImage = new Bitmap(PictureBoxMain.Image);
        }
        public void SetWaitCursor()
        {
            Cursor.Current = Cursors.WaitCursor;
        }
        public void ClearCursor()
        {
            Cursor.Current = Cursors.Default;
        }
        public Bitmap GetGrayScale()
        {
            Bitmap bmp = GetMainImage();
            for (int i = 0; i < bmp.Height - 1; i++)
            {
                for (int j = 0; j < bmp.Width - 1; j++)
                {
                    double valGray = Convert.ToDouble(bmp.GetPixel(j, i).R) * (0.299) + Convert.ToDouble(bmp.GetPixel(j, i).G) * (0.547) + Convert.ToDouble(bmp.GetPixel(j, i).B) * (0.114);
                    Color valColor = Color.FromArgb((int)valGray, (int)valGray, (int)valGray);
                    bmp.SetPixel(j, i, valColor);
                }
            }
            AddOperation(bmp);
            return bmp;
        }
        public Bitmap GetRotateRight()
        {
            int temp = 0;
            Bitmap bmp = GetMainImage();
            Bitmap rotate = new Bitmap(bmp.Height, bmp.Width);
            temp = rotate.Width;
            for (int i = 0; i < bmp.Height; i++)
            {
                temp--;
                for (int j = 0; j < bmp.Width; j++)
                    rotate.SetPixel(temp, j, bmp.GetPixel(j, i));
            }
            AddOperation(rotate);
            return rotate;
        }
        public Bitmap GetRotateLeft()
        {
            Bitmap bmp = GetMainImage();
            Bitmap rotate = new Bitmap(bmp.Height, bmp.Width);
            for (int i = 0; i < rotate.Height - 1; i++)
                for (int j = 0; j < rotate.Width - 1; j++)
                    rotate.SetPixel(j, rotate.Height - 1 - i, bmp.GetPixel(i, j));
            AddOperation(rotate);
            return rotate;
        }
        public Bitmap GetMirroringLeft()
        {
            Bitmap bmp = GetMainImage();
            Bitmap mirror = new Bitmap(bmp.Width, bmp.Height);
            int satir = bmp.Height - 1, sutun = bmp.Width - 1;
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    mirror.SetPixel(sutun - j, i, bmp.GetPixel(j, i));
                }
            }
            AddOperation(mirror);
            return mirror;
        }
        public Bitmap GetMirroringRight()
        {
            Bitmap bmp = GetMainImage();
            Bitmap mirror = new Bitmap(bmp.Width, bmp.Height);
            int satir = bmp.Height - 1, sutun = bmp.Width - 1;
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    mirror.SetPixel(sutun - j, i, bmp.GetPixel(j, i));
                }
            }
            AddOperation(mirror);
            return mirror;
        }
        public Bitmap GetNegative()
        {
            Bitmap bmp = GetMainImage();
            Bitmap negative = new Bitmap(bmp.Width, bmp.Height);
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color col = bmp.GetPixel(x, y);
                    int A = col.A;
                    int R = col.R;
                    int G = col.G;
                    int B = col.B;
                    R = 255 - R;
                    G = 255 - G;
                    B = 255 - B;
                    negative.SetPixel(x, y, Color.FromArgb(A, R, G, B));
                }
            }
            AddOperation(negative);
            return negative;
        }
        public Bitmap GetZoom(int width, int height)
        {
            Bitmap bmp = GetMainImage();
            if (bmp.Width > width && bmp.Height > height)
            {
                bmp = GetZoomOut(width, height, bmp);
            }
            else if (width > bmp.Width && height == bmp.Height)
            {
                bmp = GetZoomIn(width, bmp.Height, bmp);
                bmp = GetZoomIn(bmp.Width, height, bmp);
            }
            else if (width == bmp.Width && height < bmp.Height)
            {
                bmp = GetZoomOut(bmp.Width, height, bmp);
            }
            else
            {
                bmp = GetZoomIn(width, height, bmp);
            }
            return bmp;
        }
        public Bitmap GetZoomOut(int inputWidth, int inputHeight, Bitmap bmp)
        {
            float ratioX = (float)bmp.Width / (float)inputWidth;
            float ratioY = (float)bmp.Height / (float)inputHeight;
            Bitmap scale = new Bitmap(inputWidth, inputHeight);
            Color col;
            List<Color> renkListesi = new List<Color>();
            for (float i = 0; i < bmp.Width - ratioX + 1; i += ratioX)
            {
                for (float j = 0; j < bmp.Height - ratioY + 1; j += ratioY)
                {
                    if (i < bmp.Width && j < bmp.Height)
                    {
                        col = bmp.GetPixel(Convert.ToInt32(Math.Floor(i)), Convert.ToInt32(Math.Floor(j)));
                        renkListesi.Add(col);
                    }
                    else
                    {
                        col = bmp.GetPixel(bmp.Width - 1, bmp.Height - 1);
                        renkListesi.Add(col);
                    }
                }
            }
            int sayac = 0;
            for (float i = 0; i < scale.Width; i++)
            {
                for (float j = 0; j < scale.Height; j++)
                {
                    scale.SetPixel(Convert.ToInt32(i), Convert.ToInt32(j), renkListesi[sayac]);
                    sayac++;
                }
            }
            renkListesi.Clear();
            AddOperation(scale);
            return scale;
        }
        public Bitmap GetZoomIn(int inputWidth, int inputHeight, Bitmap bmp)
        {
            float ratioX = (float)inputWidth / (float)bmp.Size.Width;
            float ratioY = (float)inputHeight / (float)bmp.Size.Height;
            Bitmap scale = new Bitmap(inputWidth, inputHeight);
            Color col;
            List<Color> renkListesi = new List<Color>();
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    col = bmp.GetPixel(i, j);
                    renkListesi.Add(col);
                }
            }
            int sayac = 0;
            for (float i = 0; i < scale.Width - ratioX + 1; i += ratioX)
            {
                for (float j = 0; j < scale.Height - ratioY + 1; j += ratioY)
                {
                    for (float x = 0; x < ratioX; x++)
                    {
                        for (float y = 0; y < ratioY; y++)
                        {
                            if (sayac < renkListesi.Count && Convert.ToInt32(j + y) < inputHeight && Convert.ToInt32(i + x) < inputWidth)
                            {
                                scale.SetPixel(Convert.ToInt32(i + x), Convert.ToInt32(j + y), renkListesi[sayac]);
                                if (i != Math.Floor(i) || j != Math.Floor(j))
                                    if (Math.Ceiling(i + x) < inputWidth && Math.Ceiling(j + y) < inputHeight)
                                        scale.SetPixel(Convert.ToInt32(Math.Ceiling(i + x)), Convert.ToInt32(Math.Ceiling(j + y)), renkListesi[sayac]);
                            }
                        }
                    }
                    sayac++;
                }
            }
            renkListesi.Clear();
            AddOperation(scale);
            return scale;
        }
        public Bitmap GetChannelRed()
        {
            Bitmap bmp = GetChannelImage();
            Bitmap channel = new Bitmap(bmp.Width, bmp.Height);
            for (int j = 0; j < bmp.Height; j++)
                for (int i = 0; i < bmp.Width; i++)
                    channel.SetPixel(i, j, Color.FromArgb(bmp.GetPixel(i, j).R, 0, 0));
            AddOperation(channel);
            return channel;
        }
        public Bitmap GetChannelGreen()
        {
            Bitmap bmp = GetChannelImage();
            Bitmap channel = new Bitmap(bmp.Width, bmp.Height);
            for (int j = 0; j < bmp.Height; j++)
                for (int i = 0; i < bmp.Width; i++)
                    channel.SetPixel(i, j, Color.FromArgb(0, bmp.GetPixel(i, j).G, 0));
            AddOperation(channel);
            return channel;
        }
        public Bitmap GetChannelBlue()
        {
            Bitmap bmp = GetChannelImage();
            Bitmap channel = new Bitmap(bmp.Width, bmp.Height);
            for (int j = 0; j < bmp.Height; j++)
                for (int i = 0; i < bmp.Width; i++)
                    channel.SetPixel(i, j, Color.FromArgb(0, 0, bmp.GetPixel(i, j).B));
            AddOperation(channel);
            return channel;
        }
        public Bitmap GetMirroringUp()
        {
            Bitmap bmp = GetMainImage();
            Bitmap mirror = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color col = bmp.GetPixel(i, j);
                    mirror.SetPixel(i, bmp.Height - j - 1, col);
                }
            }
            AddOperation(mirror);
            return mirror;
        }
        public Bitmap GetMirroringDown()
        {
            Bitmap bmp = GetMainImage();
            Bitmap mirror = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color col = bmp.GetPixel(i, j);
                    mirror.SetPixel(i, bmp.Height - j - 1, col);
                }
            }
            AddOperation(mirror);
            return mirror;
        }
        public void GetHistogram()
        {
            Bitmap bmp = GetMainImage();
            Array.Clear(histogramR, 0, histogramR.Length);
            Array.Clear(histogramG, 0, histogramG.Length);
            Array.Clear(histogramB, 0, histogramB.Length);
            Array.Clear(histogramGray, 0, histogramGray.Length);
            for (int i = 0; i < bmp.Size.Height; i++)
            {
                for (int j = 0; j < bmp.Size.Width; j++)
                {
                    Color col = bmp.GetPixel(j, i);
                    int gCol = Convert.ToInt32(bmp.GetPixel(j, i).R + bmp.GetPixel(j, i).G + bmp.GetPixel(j, i).B) / 3;
                    histogramR[col.R]++;
                    histogramG[col.G]++;
                    histogramB[col.B]++;
                    histogramGray[gCol]++;
                }
            }
        }
        public bool GetFileName(out string fileName, DragEventArgs e)
        {
            bool ret = false;
            fileName = string.Empty;
            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                Array data = ((IDataObject)e.Data).GetData("FileDrop") as Array;
                if (data != null)
                {
                    if ((data.Length == 1) && (data.GetValue(0) is String))
                    {
                        fileName = ((string[])data)[0];
                        string ext = Path.GetExtension(fileName).ToLower();
                        if ((ext == ".jpg") || (ext == ".png") || (ext == ".bmp") || (ext == ".jpeg"))
                        {
                            ret = true;
                        }
                    }
                }
            }
            return ret;
        }
        public void DarkThemeGroupBox()
        {
            foreach (Control item in this.Controls)
            {
                if (item is GroupBox)
                {
                    item.ForeColor = Color.Gainsboro;
                    item.BackColor = Color.FromArgb(20, 20, 20);
                }
            }
        }
        public void LightThemeGroupBox()
        {
            foreach (Control item in this.Controls)
            {
                if (item is GroupBox)
                {
                    item.ForeColor = Color.Black;
                    item.BackColor = Color.White;

                }
            }
        }
        public void DarkThemeButton()
        {
            BtnHistogram.FlatStyle = FlatStyle.Flat;
            BtnHistogram.FlatAppearance.BorderColor = Color.Gainsboro;
            BtnHistogram.FlatAppearance.BorderSize = 1;
            BtnHistogram.ForeColor = Color.Gainsboro;
            BtnHistogram.BackColor = Color.FromArgb(20, 20, 20);
            BtnHistogram.Image = ((System.Drawing.Image)(Properties.Resources.ico_ok_gray));

            BtnColorChannels.FlatStyle = FlatStyle.Flat;
            BtnColorChannels.FlatAppearance.BorderColor = Color.Gainsboro;
            BtnColorChannels.FlatAppearance.BorderSize = 1;
            BtnColorChannels.ForeColor = Color.Gainsboro;
            BtnColorChannels.BackColor = Color.FromArgb(20, 20, 20);
            BtnColorChannels.Image = ((System.Drawing.Image)(Properties.Resources.ico_ok_gray));

            BtnDoRedo.FlatStyle = FlatStyle.Flat;
            BtnDoRedo.FlatAppearance.BorderColor = Color.Gainsboro;
            BtnDoRedo.FlatAppearance.BorderSize = 1;
            BtnDoRedo.ForeColor = Color.Gainsboro;
            BtnDoRedo.BackColor = Color.FromArgb(20, 20, 20);
            BtnDoRedo.Image = ((System.Drawing.Image)(Properties.Resources.ico_redo_gray));

            BtnDoUndo.FlatStyle = FlatStyle.Flat;
            BtnDoUndo.FlatAppearance.BorderColor = Color.Gainsboro;
            BtnDoUndo.FlatAppearance.BorderSize = 1;
            BtnDoUndo.ForeColor = Color.Gainsboro;
            BtnDoUndo.BackColor = Color.FromArgb(20, 20, 20);
            BtnDoUndo.Image = ((System.Drawing.Image)(Properties.Resources.ico_undo_gray));

            BtnGrayScale.FlatStyle = FlatStyle.Flat;
            BtnGrayScale.FlatAppearance.BorderColor = Color.Gainsboro;
            BtnGrayScale.FlatAppearance.BorderSize = 1;
            BtnGrayScale.ForeColor = Color.Gainsboro;
            BtnGrayScale.BackColor = Color.FromArgb(20, 20, 20);
            BtnGrayScale.Image = ((System.Drawing.Image)(Properties.Resources.ico_grayscale));

            BtnMirroringHor.FlatStyle = FlatStyle.Flat;
            BtnMirroringHor.FlatAppearance.BorderColor = Color.Gainsboro;
            BtnMirroringHor.FlatAppearance.BorderSize = 1;
            BtnMirroringHor.ForeColor = Color.Gainsboro;
            BtnMirroringHor.BackColor = Color.FromArgb(20, 20, 20);
            BtnMirroringHor.Image = ((System.Drawing.Image)(Properties.Resources.ico_mirror_horizontal_gray));

            BtnMirroringVer.FlatStyle = FlatStyle.Flat;
            BtnMirroringVer.FlatAppearance.BorderColor = Color.Gainsboro;
            BtnMirroringVer.FlatAppearance.BorderSize = 1;
            BtnMirroringVer.ForeColor = Color.Gainsboro;
            BtnMirroringVer.BackColor = Color.FromArgb(20, 20, 20);
            BtnMirroringVer.Image = ((System.Drawing.Image)(Properties.Resources.ico_mirror_vertical_gray));

            BtnNegative.FlatStyle = FlatStyle.Flat;
            BtnNegative.FlatAppearance.BorderColor = Color.Gainsboro;
            BtnNegative.FlatAppearance.BorderSize = 1;
            BtnNegative.ForeColor = Color.Gainsboro;
            BtnNegative.BackColor = Color.FromArgb(20, 20, 20);
            BtnNegative.Image = ((System.Drawing.Image)(Properties.Resources.ico_negative));

            BtnReOpen.FlatStyle = FlatStyle.Flat;
            BtnReOpen.FlatAppearance.BorderColor = Color.Gainsboro;
            BtnReOpen.FlatAppearance.BorderSize = 1;
            BtnReOpen.ForeColor = Color.Gainsboro;
            BtnReOpen.BackColor = Color.FromArgb(20, 20, 20);
            BtnReOpen.Image = ((System.Drawing.Image)(Properties.Resources.ico_reopen_gray));

            BtnRotateLeft.FlatStyle = FlatStyle.Flat;
            BtnRotateLeft.FlatAppearance.BorderColor = Color.Gainsboro;
            BtnRotateLeft.FlatAppearance.BorderSize = 1;
            BtnRotateLeft.ForeColor = Color.Gainsboro;
            BtnRotateLeft.BackColor = Color.FromArgb(20, 20, 20);
            BtnRotateLeft.Image = ((System.Drawing.Image)(Properties.Resources.ico_rotate_left_gray));

            BtnRotateRight.FlatStyle = FlatStyle.Flat;
            BtnRotateRight.FlatAppearance.BorderColor = Color.Gainsboro;
            BtnRotateRight.FlatAppearance.BorderSize = 1;
            BtnRotateRight.ForeColor = Color.Gainsboro;
            BtnRotateRight.BackColor = Color.FromArgb(20, 20, 20);
            BtnRotateRight.Image = ((System.Drawing.Image)(Properties.Resources.ico_rotate_right_gray));

            BtnSave.FlatStyle = FlatStyle.Flat;
            BtnSave.FlatAppearance.BorderColor = Color.Gainsboro;
            BtnSave.FlatAppearance.BorderSize = 1;
            BtnSave.ForeColor = Color.Gainsboro;
            BtnSave.BackColor = Color.FromArgb(20, 20, 20);
            BtnSave.Image = ((System.Drawing.Image)(Properties.Resources.ico_save_gray));

            BtnScale.FlatStyle = FlatStyle.Flat;
            BtnScale.FlatAppearance.BorderColor = Color.Gainsboro;
            BtnScale.FlatAppearance.BorderSize = 1;
            BtnScale.ForeColor = Color.Gainsboro;
            BtnScale.BackColor = Color.FromArgb(20, 20, 20);
            BtnScale.Image = ((System.Drawing.Image)(Properties.Resources.ico_ok_gray));
        }
        public void LightThemeButton()
        {
            BtnHistogram.FlatStyle = FlatStyle.Flat;
            BtnHistogram.FlatAppearance.BorderColor = Color.Gray;
            BtnHistogram.FlatAppearance.BorderSize = 1;
            BtnHistogram.ForeColor = Color.Black;
            BtnHistogram.BackColor = Color.Gainsboro;
            BtnHistogram.Image = ((System.Drawing.Image)(Properties.Resources.ico_ok));

            BtnColorChannels.FlatStyle = FlatStyle.Flat;
            BtnColorChannels.FlatAppearance.BorderColor = Color.Gray;
            BtnColorChannels.FlatAppearance.BorderSize = 1;
            BtnColorChannels.ForeColor = Color.Black;
            BtnColorChannels.BackColor = Color.Gainsboro;
            BtnColorChannels.Image = ((System.Drawing.Image)(Properties.Resources.ico_ok));

            BtnDoRedo.FlatStyle = FlatStyle.Flat;
            BtnDoRedo.FlatAppearance.BorderColor = Color.Gray;
            BtnDoRedo.FlatAppearance.BorderSize = 1;
            BtnDoRedo.ForeColor = Color.Black;
            BtnDoRedo.BackColor = Color.Gainsboro;
            BtnDoRedo.Image = ((System.Drawing.Image)(Properties.Resources.ico_redo));

            BtnDoUndo.FlatStyle = FlatStyle.Flat;
            BtnDoUndo.FlatAppearance.BorderColor = Color.Gray;
            BtnDoUndo.FlatAppearance.BorderSize = 1;
            BtnDoUndo.ForeColor = Color.Black;
            BtnDoUndo.BackColor = Color.Gainsboro;
            BtnDoUndo.Image = ((System.Drawing.Image)(Properties.Resources.ico_undo));

            BtnGrayScale.FlatStyle = FlatStyle.Flat;
            BtnGrayScale.FlatAppearance.BorderColor = Color.Gray;
            BtnGrayScale.FlatAppearance.BorderSize = 1;
            BtnGrayScale.ForeColor = Color.Black;
            BtnGrayScale.BackColor = Color.Gainsboro;
            BtnGrayScale.Image = ((System.Drawing.Image)(Properties.Resources.ico_grayscale));

            BtnMirroringHor.FlatStyle = FlatStyle.Flat;
            BtnMirroringHor.FlatAppearance.BorderColor = Color.Gray;
            BtnMirroringHor.FlatAppearance.BorderSize = 1;
            BtnMirroringHor.ForeColor = Color.Black;
            BtnMirroringHor.BackColor = Color.Gainsboro;
            BtnMirroringHor.Image = ((System.Drawing.Image)(Properties.Resources.ico_mirror_horizontal));

            BtnMirroringVer.FlatStyle = FlatStyle.Flat;
            BtnMirroringVer.FlatAppearance.BorderColor = Color.Gray;
            BtnMirroringVer.FlatAppearance.BorderSize = 1;
            BtnMirroringVer.ForeColor = Color.Black;
            BtnMirroringVer.BackColor = Color.Gainsboro;
            BtnMirroringVer.Image = ((System.Drawing.Image)(Properties.Resources.ico_mirror_vertical));

            BtnNegative.FlatStyle = FlatStyle.Flat;
            BtnNegative.FlatAppearance.BorderColor = Color.Gray;
            BtnNegative.FlatAppearance.BorderSize = 1;
            BtnNegative.ForeColor = Color.Black;
            BtnNegative.BackColor = Color.Gainsboro;

            BtnReOpen.FlatStyle = FlatStyle.Flat;
            BtnReOpen.FlatAppearance.BorderColor = Color.Gray;
            BtnReOpen.FlatAppearance.BorderSize = 1;
            BtnReOpen.ForeColor = Color.Black;
            BtnReOpen.BackColor = Color.Gainsboro;
            BtnReOpen.Image = ((System.Drawing.Image)(Properties.Resources.ico_reopen));

            BtnRotateLeft.FlatStyle = FlatStyle.Flat;
            BtnRotateLeft.FlatAppearance.BorderColor = Color.Gray;
            BtnRotateLeft.FlatAppearance.BorderSize = 1;
            BtnRotateLeft.ForeColor = Color.Black;
            BtnRotateLeft.BackColor = Color.Gainsboro;
            BtnRotateLeft.Image = ((System.Drawing.Image)(Properties.Resources.ico_rotate_left));

            BtnRotateRight.FlatStyle = FlatStyle.Flat;
            BtnRotateRight.FlatAppearance.BorderColor = Color.Gray;
            BtnRotateRight.FlatAppearance.BorderSize = 1;
            BtnRotateRight.ForeColor = Color.Black;
            BtnRotateRight.BackColor = Color.Gainsboro;
            BtnRotateRight.Image = ((System.Drawing.Image)(Properties.Resources.ico_rotate_right));

            BtnSave.FlatStyle = FlatStyle.Flat;
            BtnSave.FlatAppearance.BorderColor = Color.Gray;
            BtnSave.FlatAppearance.BorderSize = 1;
            BtnSave.ForeColor = Color.Black;
            BtnSave.BackColor = Color.Gainsboro;
            BtnSave.Image = ((System.Drawing.Image)(Properties.Resources.ico_save));

            BtnScale.FlatStyle = FlatStyle.Flat;
            BtnScale.FlatAppearance.BorderColor = Color.Gray;
            BtnScale.FlatAppearance.BorderSize = 1;
            BtnScale.ForeColor = Color.Black;
            BtnScale.BackColor = Color.Gainsboro;
            BtnScale.Image = ((System.Drawing.Image)(Properties.Resources.ico_ok));
        }
        public void DarkThemePicture()
        {
            PictureBoxMainIco.Image = ((System.Drawing.Image)(Properties.Resources.ico_main_gray));
            PictureBoxMain.BackColor = Color.FromArgb(20, 20, 20);
            PictureBoxMainIco.BackColor = Color.FromArgb(20, 20, 20);
        }
        public void LightThemePicture()
        {
            PictureBoxMainIco.Image = ((System.Drawing.Image)(Properties.Resources.ico_main));
            PictureBoxMain.BackColor = Color.White;
            PictureBoxMainIco.BackColor = Color.White;
        }
        public void DarkThemeLabel()
        {
            LabelMainImage.ForeColor = Color.Gainsboro;
            LabelMainImage.BackColor = Color.FromArgb(20, 20, 20);
            label2.BackColor = Color.FromArgb(20, 20, 20);
            label2.ForeColor = Color.Gainsboro;
            label3.ForeColor = Color.Gainsboro;
            label3.BackColor = Color.FromArgb(20, 20, 20);
        }
        public void LightThemeLabel()
        {
            LabelMainImage.ForeColor = Color.FromArgb(64, 64, 64);
            LabelMainImage.BackColor = Color.White;
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.BackColor = Color.White;
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.BackColor = Color.White;
        }
        public void DarkThemeMenu()
        {
            MenuStripMain.ForeColor = Color.Gainsboro;
        }
        public void LightThemeMenu()
        {
            MenuStripMain.ForeColor = Color.Black;
        }
        public void LoadImage()
        {
            bmpFirstImage = new Bitmap(path);
        }
        public void SaveImage()
        {
            Bitmap bmp = GetMainImage();
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpeg dosyası(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp|png(*.png)|*.png";
            sfd.Title = "Kaydet";
            sfd.FileName = "resim";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                PictureBoxMain.Image.Save(sfd.FileName);
                isSave = true;
            }
        }
        public void ErrorMessage(string errorMessage)
        {
            MessageBox.Show(errorMessage);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.StyleManager = FrMetroStyleManager;
            LightThemeButton();
        }

        private void BtnColorChannels_Click(object sender, EventArgs e)
        {
            if (!HasMainImage())
            {
                ErrorMessage("Henüz ana resim seçilmedi!");
                return;
            }
            SetWaitCursor();
            Bitmap img;
            if (RadioChannelRed.Checked)
                img = GetChannelRed();
            else if (RadioChannelGreen.Checked)
                img = GetChannelGreen();
            else if (RadioChannelBlue.Checked)
                img = GetChannelBlue();
            else
            {
                MessageBox.Show("Herhangi bir renk kanalı seçmediniz!");
                return;
            }
            SetResultImage(img);
            SetDisabledUndoRedo();
            ClearCursor();
        }

        private void BtnRotateLeft_Click(object sender, EventArgs e)
        {
            if (!HasMainImage())
            {
                ErrorMessage("Henüz ana resim seçilmedi!");
                return;
            }
            SetWaitCursor();
            Bitmap img = GetRotateLeft();
            SetResultImage(img);
            SetOperationImage(img);
            SetDisabledUndoRedo();
            ClearCursor();
        }

        private void BtnRotateRight_Click(object sender, EventArgs e)
        {
            if (!HasMainImage())
            {
                ErrorMessage("Henüz ana resim seçilmedi!");
                return;
            }
            SetWaitCursor();
            Bitmap img = GetRotateRight();
            SetResultImage(img);
            SetOperationImage(img);
            SetDisabledUndoRedo();
            ClearCursor();
        }

        private void BtnMirroringVer_Click(object sender, EventArgs e)
        {
            if (!HasMainImage())
            {
                ErrorMessage("Henüz ana resim seçilmedi!");
                return;
            }
            SetWaitCursor();
            Bitmap img = GetMirroringRight();
            SetResultImage(img);
            SetOperationImage(img);
            SetDisabledUndoRedo();
            ClearCursor();
        }

        private void BtnMirroringHor_Click(object sender, EventArgs e)
        {
            if (!HasMainImage())
            {
                ErrorMessage("Henüz ana resim seçilmedi!");
                return;
            }
            SetWaitCursor();
            Bitmap img = GetMirroringDown();
            SetResultImage(img);
            SetOperationImage(img);
            SetDisabledUndoRedo();
            ClearCursor();
        }

        private void BtnScale_Click(object sender, EventArgs e)
        {
            if (!HasMainImage())
            {
                ErrorMessage("Henüz ana resim seçilmedi!");
                return;
            }
            SetWaitCursor();
            int scalX = Convert.ToInt32(TxtScalingX.Text);
            int scalY = Convert.ToInt32(TxtScalingY.Text);
            if (scalX <= 0 || scalY <= 0)
                MessageBox.Show("Sıfır veya daha küçük değer girilemez!");
            else
            {
                Bitmap img = GetZoom(scalX, scalY);
                SetResultImage(img);
                SetOperationImage(img);
                SetDisabledUndoRedo();
            }
            ClearCursor();
        }

        private void BtnGrayScale_Click(object sender, EventArgs e)
        {
            if (!HasMainImage())
            {
                ErrorMessage("Henüz ana resim seçilmedi!");
                return;
            }
            SetWaitCursor();
            Bitmap img = GetGrayScale();
            SetResultImage(img);
            SetOperationImage(img);
            SetDisabledUndoRedo();
            ClearCursor();
        }

        private void BtnNegative_Click(object sender, EventArgs e)
        {
            if (!HasMainImage())
            {
                ErrorMessage("Henüz ana resim seçilmedi!");
                return;
            }
            SetWaitCursor();
            Bitmap img = GetNegative();
            SetResultImage(img);
            SetOperationImage(img);
            SetDisabledUndoRedo();
            ClearCursor();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(!HasMainImage())
            {
                ErrorMessage("Henüz ana resim seçilmedi!");
                return;
            }
            SaveImage();
        }

        private void PictureBoxMain_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Pictures|*.bmp;*.jpg;*.png;*.jpeg;";
            if (file.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            PictureBoxMainIco.Hide();
            LabelMainImage.Hide();
            PictureBoxMain.ImageLocation = file.FileName;
            counterFirstImage++;
        }

        private void PictureBoxMainIco_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Pictures|*.bmp;*.jpg;*.png;*.jpeg;";
            if (file.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            PictureBoxMainIco.Hide();
            LabelMainImage.Hide();
            PictureBoxMain.ImageLocation = file.FileName;
            counterFirstImage++;
        }

        private void BtnReOpen_Click(object sender, EventArgs e)
        {
            if (!HasMainImage())
            {
                ErrorMessage("Henüz ana resim seçilmedi!");
                return;
            }
            SetWaitCursor();
            SetResultImage(bmpFirstImage);
            SetOperationImage(bmpFirstImage);
            ClearCursor();
        }

        private void PictureBoxMain_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            SetFirstImage();
            SetOperationImage(new Bitmap(PictureBoxMain.Image));
            AddOperation(new Bitmap(PictureBoxMain.Image));
        }

        private void PictureBoxMain_BackgroundImageChanged(object sender, EventArgs e)
        {

        }

        private void BtnDoRedo_Click(object sender, EventArgs e)
        {
            if (counterOperation == -1) counterOperation = 0;
            if (counterOperation < OperationsList.Count()-1 && counterOperation >= 0)
            {
                Bitmap bmp = GetMainImage();
                counterOperation++;
                bmp = OperationsList.ElementAt(counterOperation);
                SetResultImage(bmp);
            }
            SetDisabledUndoRedo();
        }

        private void BtnDoUndo_Click(object sender, EventArgs e)
        {
            counterOperation--;
            if (counterOperation >= 0)
            {
                Bitmap bmp = GetMainImage();
                bmp = OperationsList.ElementAt(counterOperation);
                SetResultImage(bmp);
            }
            if(counterOperation <= 0)
                counterOperation = -1;
            SetDisabledUndoRedo();
        }

        private void BtnHistogram_Click(object sender, EventArgs e)
        {
            if (!HasMainImage())
            {
                ErrorMessage("Henüz ana resim seçilmedi!");
                return;
            }
            SetWaitCursor();
            FormHistogram frm = new FormHistogram();
            frm.histogramR = this.histogramR;
            frm.histogramG = this.histogramG;
            frm.histogramB = this.histogramB;
            frm.histogramGray = this.histogramGray;
            if (RadioHistogramR.Checked)
                frm.activeHistogram = 0;
            else if (RadioHistogramG.Checked)
                frm.activeHistogram = 1;
            else if (RadioHistogramB.Checked)
                frm.activeHistogram = 2;
            else if (RadioHistogramGray.Checked)
                frm.activeHistogram = 3;
            else
            {
                MessageBox.Show("Histogram için herhangi bir renk seçmediniz!");
                return;
            }
            GetHistogram();
            frm.Show();
            ClearCursor();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void MenuAboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Emeği geçenler\n150201181 - Emre Kızıltepe\n150201199 - Murat Karakoç", "Hakkımızda", MessageBoxButtons.OK);
        }

        private void MenuUndo_Click(object sender, EventArgs e)
        {
            counterOperation--;
            if (counterOperation >= 0)
            {
                Bitmap bmp = GetMainImage();
                bmp = OperationsList.ElementAt(counterOperation);
                SetResultImage(bmp);
            }
            if (counterOperation <= 0)
                counterOperation = -1;
            SetDisabledUndoRedo();
        }

        private void MenuRedo_Click(object sender, EventArgs e)
        {
            if (counterOperation == -1) counterOperation = 0;
            if (counterOperation < OperationsList.Count() - 1 && counterOperation >= 0)
            {
                Bitmap bmp = GetMainImage();
                counterOperation++;
                bmp = OperationsList.ElementAt(counterOperation);
                SetResultImage(bmp);
            }
            SetDisabledUndoRedo();
        }

        private void MenuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Pictures|*.bmp;*.jpg;*.png;*.jpeg;";
            if (file.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            PictureBoxMainIco.Hide();
            LabelMainImage.Hide();
            PictureBoxMain.ImageLocation = file.FileName;
            counterFirstImage++;
        }

        private void MenuSave_Click(object sender, EventArgs e)
        {
            if (!HasMainImage())
            {
                ErrorMessage("Henüz ana resim seçilmedi!");
                return;
            }
            SaveImage();
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBoxMain_DragDrop(object sender, DragEventArgs e)
        {
            if (validData)
            {
                while (getImageThread.IsAlive)
                {
                    Application.DoEvents();
                    Thread.Sleep(0);
                }
                PictureBoxMain.Image = bmpFirstImage;
            }
        }

        private void PictureBoxMain_DragEnter(object sender, DragEventArgs e)
        {
            string fileName;
            validData = GetFileName(out fileName, e);
            if (validData)
            {
                path = fileName;
                getImageThread = new Thread(new ThreadStart(LoadImage));
                getImageThread.Start();
                e.Effect = DragDropEffects.Copy;
            }
            else
                e.Effect = DragDropEffects.Copy;
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            string fileName;
            validData = GetFileName(out fileName, e);
            if (validData)
            {
                path = fileName;
                getImageThread = new Thread(new ThreadStart(LoadImage));
                getImageThread.Start();
                e.Effect = DragDropEffects.Copy;
            }
            else
                e.Effect = DragDropEffects.Copy;
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            if (validData)
            {
                while (getImageThread.IsAlive)
                {
                    Application.DoEvents();
                    Thread.Sleep(0);
                }
                PictureBoxMainIco.Hide();
                LabelMainImage.Hide();
                counterFirstImage++;
                PictureBoxMain.ImageLocation = path;
            }
        }

        private void MainForm_DragOver(object sender, DragEventArgs e)
        {
            PictureBoxMain.Tag = "red";
            PictureBoxMain.Refresh();
        }

        private void TxtScalingX_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtScalingY_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.Y)
            {
                BtnDoRedo.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.Z)
            {
                BtnDoUndo.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                BtnSave.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.O)
            {
                MenuOpen.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.E)
            {
                MenuExit.PerformClick();
            }
        }

        private void MenuHelp_Click(object sender, EventArgs e)
        {
            string mainHead = "---------------------YARDIM--------------------\n\n";
            string head1 = "1.RENK KANALLARI\n";
            string desc1 = "Kırmızı, yeşil ve mavi renk kanallarını kullanarak kırmızı, mavi ve yeşil renk bileşenlerini görebilirsiniz.\n\n";
            string head2 = "2.HİSTOGRAM\n";
            string desc2 = "Gri seviye veya renkli bir görüntünün ayrı ayrı histogramını görebilirsiniz.\n\n";
            string head3 = "3.DÖNDÜRME\n";
            string desc3 = "Görüntüyü 90 derece sağa veya sola olmak üzere iki farklı döndürme işlemi yapabilirsiniz.\n\n";
            string head4 = "4.AYNALAMA\n";
            string desc4 = "Görüntüyü yatay eksene göre veya düşey eksene göre aynalama yapabilirsiniz.\n\n";
            string head5 = "5.ÖLÇEKLENDİRME\n";
            string desc5 = "Belirlediğiniz genişlik ve yükseklik değerlerine göre görüntüyü ölçeklendirebilirsiniz. Girdiğiniz genişlik ve yükseklik değelerinde sıfır veya daha küçük sayılar kabul edilmemektedir.\n\n";
            string head6 = "6.NEGATİF\n";
            string desc6 = "Görüntünün terslenmiş halini alabilirsiniz..\n\n";
            string head7 = "7.GRİ TONLAMA\n";
            string desc7 = "Renkli görüntüyü gri tonlu görüntüye dönüştürebilirsiniz.\n\n";
            string head8 = "8.GERİ ALMA\n";
            string desc8 = "Görüntü üzerinde yaptığınız işlemleri geri alabilirsiniz. Yaptığınız en fazla 10 değişiklik kaydedilmektedir.\n\n";
            string head9 = "9.İLERİ ALMA\n";
            string desc9 = "Görüntü üzerinde yaptığınız işlemleri geri alabilirsiniz. Yaptığınız en fazla 10 değişiklik kaydedilmektedir.\n\n";
            string head10 = "10.KAYDETME\n";
            string desc10 = "Görüntüyü bilgisayarınıza kaydedebilirsiniz.\n\n";
            string head11 = "11.TEKRAR AÇMA\n";
            string desc11 = "Üzerinde değişilikler yaptığınız görüntünün ilk halini tekrar aç diyerek görebilirsiniz.\n\n";
            MessageBox.Show(mainHead + head1 + desc1 + head2 + desc2 + head3 + desc3 + head4 + desc4 + head5 + desc5 + head6 + desc6 + head7 + desc7 + head8 + desc8 + head9 + desc9 + head10 + desc10 + head11 + desc11);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bmpFirstImage == null)
            {
                closeCount++;
                if (closeCount < 2)
                {
                    DialogResult dr;
                    dr = MessageBox.Show(this, "Kapatmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
            else
            {
                if (isSave)
                {
                    closeCount++;
                    if (closeCount < 2)
                    {
                        DialogResult dr;
                        dr = MessageBox.Show(this, "Kaydedilmemiş resminiz var. Yine de çıkış yapmak istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.No)
                        {
                            e.Cancel = true;
                        }
                        else
                        {
                            Application.Exit();
                        }
                    }
                }
                else
                {
                    closeCount++;
                    if (closeCount < 2)
                    {
                        DialogResult dr;
                        dr = MessageBox.Show(this, "Kaydedilmemiş resminiz var. Yine de çıkış yapmak istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.No)
                        {
                            e.Cancel = true;
                        }
                        else
                        {
                            Application.Exit();
                        }
                    }
                }
            }
        }

        private void LabelMainImage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Pictures|*.bmp;*.jpg;*.png;*.jpeg;";
            if (file.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            PictureBoxMainIco.Hide();
            LabelMainImage.Hide();
            PictureBoxMain.ImageLocation = file.FileName;
            counterFirstImage++;
        }

        private void BtnColorChannels_MouseEnter(object sender, EventArgs e)
        {
            if (!darkTheme)
            {
                BtnColorChannels.FlatStyle = FlatStyle.Flat;
                BtnColorChannels.FlatAppearance.BorderColor = Color.Gray;
                BtnColorChannels.FlatAppearance.BorderSize = 1;
                BtnColorChannels.BackColor = Color.FromArgb(66, 133, 234);
                BtnColorChannels.ForeColor = Color.White;
            }
            else
            {
                BtnColorChannels.FlatAppearance.BorderColor = Color.FromArgb(1, 169, 223);
                BtnColorChannels.ForeColor = Color.FromArgb(1, 169, 223);
                BtnColorChannels.Image = ((System.Drawing.Image)(Properties.Resources.ico_ok_hover));
            }
        }

        private void BtnHistogram_MouseEnter(object sender, EventArgs e)
        {
            if (!darkTheme)
            {
                BtnHistogram.FlatStyle = FlatStyle.Flat;
                BtnHistogram.FlatAppearance.BorderColor = Color.Gray;
                BtnHistogram.FlatAppearance.BorderSize = 1;
                BtnHistogram.BackColor = Color.FromArgb(66, 133, 234);
                BtnHistogram.ForeColor = Color.White;
            }
            else
            {
                BtnHistogram.FlatAppearance.BorderColor = Color.FromArgb(1, 169, 223);
                BtnHistogram.ForeColor = Color.FromArgb(1, 169, 223);
                BtnHistogram.Image = ((System.Drawing.Image)(Properties.Resources.ico_ok_hover));
            }
        }

        private void BtnRotateLeft_MouseEnter(object sender, EventArgs e)
        {
            if (!darkTheme)
            {
                BtnRotateLeft.FlatStyle = FlatStyle.Flat;
                BtnRotateLeft.FlatAppearance.BorderColor = Color.Gray;
                BtnRotateLeft.FlatAppearance.BorderSize = 1;
                BtnRotateLeft.BackColor = Color.FromArgb(66, 133, 234);
                BtnRotateLeft.ForeColor = Color.White;
            }
            else
            {
                BtnRotateLeft.FlatAppearance.BorderColor = Color.FromArgb(1, 169, 223);
                BtnRotateLeft.ForeColor = Color.FromArgb(1, 169, 223);
                BtnRotateLeft.Image = ((System.Drawing.Image)(Properties.Resources.ico_rotate_left_hover));
            }
        }

        private void BtnRotateRight_MouseEnter(object sender, EventArgs e)
        {
            if (!darkTheme)
            {
                BtnRotateRight.FlatStyle = FlatStyle.Flat;
                BtnRotateRight.FlatAppearance.BorderColor = Color.Gray;
                BtnRotateRight.FlatAppearance.BorderSize = 1;
                BtnRotateRight.BackColor = Color.FromArgb(66, 133, 234);
                BtnRotateRight.ForeColor = Color.White;
            }
            else
            {
                BtnRotateRight.FlatAppearance.BorderColor = Color.FromArgb(1, 169, 223);
                BtnRotateRight.ForeColor = Color.FromArgb(1, 169, 223);
                BtnRotateRight.Image = ((System.Drawing.Image)(Properties.Resources.ico_rotate_right_hover));
            }
        }

        private void BtnMirroringVer_MouseEnter(object sender, EventArgs e)
        {
            if (!darkTheme)
            {
                BtnMirroringVer.FlatStyle = FlatStyle.Flat;
                BtnMirroringVer.FlatAppearance.BorderColor = Color.Gray;
                BtnMirroringVer.FlatAppearance.BorderSize = 1;
                BtnMirroringVer.BackColor = Color.FromArgb(66, 133, 234);
                BtnMirroringVer.ForeColor = Color.White;
            }
            else
            {
                BtnMirroringVer.FlatAppearance.BorderColor = Color.FromArgb(1, 169, 223);
                BtnMirroringVer.ForeColor = Color.FromArgb(1, 169, 223);
                BtnMirroringVer.Image = ((System.Drawing.Image)(Properties.Resources.ico_mirror_vertical_hover1));
            }
        }

        private void BtnMirroringHor_MouseEnter(object sender, EventArgs e)
        {
            if (!darkTheme)
            {
                BtnMirroringHor.FlatStyle = FlatStyle.Flat;
                BtnMirroringHor.FlatAppearance.BorderColor = Color.Gray;
                BtnMirroringHor.FlatAppearance.BorderSize = 1;
                BtnMirroringHor.BackColor = Color.FromArgb(66, 133, 234);
                BtnMirroringHor.ForeColor = Color.White;
            }
            else
            {
                BtnMirroringHor.FlatAppearance.BorderColor = Color.FromArgb(1, 169, 223);
                BtnMirroringHor.ForeColor = Color.FromArgb(1, 169, 223);
                BtnMirroringHor.Image = ((System.Drawing.Image)(Properties.Resources.ico_mirror_horizontal1));
            }
        }

        private void BtnGrayScale_MouseEnter(object sender, EventArgs e)
        {
            if (!darkTheme)
            {
                BtnGrayScale.FlatStyle = FlatStyle.Flat;
                BtnGrayScale.FlatAppearance.BorderColor = Color.Gray;
                BtnGrayScale.FlatAppearance.BorderSize = 1;
                BtnGrayScale.BackColor = Color.FromArgb(66, 133, 234);
                BtnGrayScale.ForeColor = Color.White;
            }
            else
            {
                BtnGrayScale.FlatAppearance.BorderColor = Color.FromArgb(1, 169, 223);
                BtnGrayScale.ForeColor = Color.FromArgb(1, 169, 223);
            }
        }

        private void BtnNegative_MouseEnter(object sender, EventArgs e)
        {
            if (!darkTheme)
            {
                BtnNegative.FlatStyle = FlatStyle.Flat;
                BtnNegative.FlatAppearance.BorderColor = Color.Gray;
                BtnNegative.FlatAppearance.BorderSize = 1;
                BtnNegative.BackColor = Color.FromArgb(66, 133, 234);
                BtnNegative.ForeColor = Color.White;
            }
            else
            {
                BtnNegative.FlatAppearance.BorderColor = Color.FromArgb(1, 169, 223);
                BtnNegative.ForeColor = Color.FromArgb(1, 169, 223);
            }
        }

        private void BtnSave_MouseEnter(object sender, EventArgs e)
        {
            if (!darkTheme)
            {
                BtnSave.FlatStyle = FlatStyle.Flat;
                BtnSave.FlatAppearance.BorderColor = Color.Gray;
                BtnSave.FlatAppearance.BorderSize = 1;
                BtnSave.BackColor = Color.FromArgb(66, 133, 234);
                BtnSave.ForeColor = Color.White;
            }
            else
            {
                BtnSave.FlatAppearance.BorderColor = Color.FromArgb(1, 169, 223);
                BtnSave.ForeColor = Color.FromArgb(1, 169, 223);
                BtnSave.Image = ((System.Drawing.Image)(Properties.Resources.ico_save_hover));
            }
        }

        private void BtnReOpen_MouseEnter(object sender, EventArgs e)
        {
            if (!darkTheme)
            {
                BtnReOpen.FlatStyle = FlatStyle.Flat;
                BtnReOpen.FlatAppearance.BorderColor = Color.Gray;
                BtnReOpen.FlatAppearance.BorderSize = 1;
                BtnReOpen.BackColor = Color.FromArgb(66, 133, 234);
                BtnReOpen.ForeColor = Color.White;
            }
            else
            {
                BtnReOpen.FlatAppearance.BorderColor = Color.FromArgb(1, 169, 223);
                BtnReOpen.ForeColor = Color.FromArgb(1, 169, 223);
                BtnReOpen.Image = ((System.Drawing.Image)(Properties.Resources.ico_reopen_hover));
            }
        }

        private void BtnDoUndo_MouseEnter(object sender, EventArgs e)
        {
            if (!darkTheme)
            {
                BtnDoUndo.FlatStyle = FlatStyle.Flat;
                BtnDoUndo.FlatAppearance.BorderColor = Color.Gray;
                BtnDoUndo.FlatAppearance.BorderSize = 1;
                BtnDoUndo.BackColor = Color.FromArgb(66, 133, 234);
                BtnDoUndo.ForeColor = Color.White;
            }
            else
            {
                BtnDoUndo.FlatAppearance.BorderColor = Color.FromArgb(1, 169, 223);
                BtnDoUndo.ForeColor = Color.FromArgb(1, 169, 223);
                BtnDoUndo.Image = ((System.Drawing.Image)(Properties.Resources.ico_undo_hover));
            }
        }

        private void BtnDoRedo_MouseEnter(object sender, EventArgs e)
        {
            if (!darkTheme)
            {
                BtnDoRedo.FlatStyle = FlatStyle.Flat;
                BtnDoRedo.FlatAppearance.BorderColor = Color.Gray;
                BtnDoRedo.FlatAppearance.BorderSize = 1;
                BtnDoRedo.BackColor = Color.FromArgb(66, 133, 234);
                BtnDoRedo.ForeColor = Color.White;
            }
            else
            {
                BtnDoRedo.FlatAppearance.BorderColor = Color.FromArgb(1, 169, 223);
                BtnDoRedo.ForeColor = Color.FromArgb(1, 169, 223);
                BtnDoRedo.Image = ((System.Drawing.Image)(Properties.Resources.ico_redo_hover));
            }
        }

        private void BtnScale_MouseEnter(object sender, EventArgs e)
        {
            if (!darkTheme)
            {
                BtnScale.FlatStyle = FlatStyle.Flat;
                BtnScale.FlatAppearance.BorderColor = Color.Gray;
                BtnScale.FlatAppearance.BorderSize = 1;
                BtnScale.BackColor = Color.FromArgb(66, 133, 234);
                BtnScale.ForeColor = Color.White;
            }
            else
            {
                BtnScale.FlatAppearance.BorderColor = Color.FromArgb(1, 169, 223);
                BtnScale.ForeColor = Color.FromArgb(1, 169, 223);
                BtnScale.Image = ((System.Drawing.Image)(Properties.Resources.ico_ok_hover));
            }
        }

        private void BtnScale_MouseLeave(object sender, EventArgs e)
        {
            if (!darkTheme)
            {
                BtnScale.BackColor = Color.FromArgb(224, 224, 224);
                BtnScale.ForeColor = Color.Black;
            }
            else
            {
                BtnScale.FlatAppearance.BorderColor = Color.Gainsboro;
                BtnScale.ForeColor = Color.Gainsboro;
                BtnScale.Image = ((System.Drawing.Image)(Properties.Resources.ico_ok_gray));
            }
        }

        private void BtnReOpen_MouseLeave(object sender, EventArgs e)
        {
            if (!darkTheme)
            {
                BtnReOpen.BackColor = Color.FromArgb(224, 224, 224);
                BtnReOpen.ForeColor = Color.Black;
            }
            else
            {
                BtnReOpen.FlatAppearance.BorderColor = Color.Gainsboro;
                BtnReOpen.ForeColor = Color.Gainsboro;
                BtnReOpen.Image = ((System.Drawing.Image)(Properties.Resources.ico_reopen_gray));
            }
        }

        private void BtnDoUndo_MouseLeave(object sender, EventArgs e)
        {
            if (!darkTheme)
            {
                BtnDoUndo.BackColor = Color.FromArgb(224, 224, 224);
                BtnDoUndo.ForeColor = Color.Black;
            }
            else
            {
                BtnDoUndo.FlatAppearance.BorderColor = Color.Gainsboro;
                BtnDoUndo.ForeColor = Color.Gainsboro;
                BtnDoUndo.Image = ((System.Drawing.Image)(Properties.Resources.ico_undo_gray));
            }
        }

        private void BtnDoRedo_MouseLeave(object sender, EventArgs e)
        {
            if (!darkTheme)
            {
                BtnDoRedo.BackColor = Color.FromArgb(224, 224, 224);
                BtnDoRedo.ForeColor = Color.Black;
            }
            else
            {
                BtnDoRedo.FlatAppearance.BorderColor = Color.Gainsboro;
                BtnDoRedo.ForeColor = Color.Gainsboro;
                BtnDoRedo.Image = ((System.Drawing.Image)(Properties.Resources.ico_redo_gray));
            }
        }

        private void BtnSave_MouseLeave(object sender, EventArgs e)
        {
            if (!darkTheme)
            {
                BtnSave.BackColor = Color.FromArgb(224, 224, 224);
                BtnSave.ForeColor = Color.Black;
            }
            else
            {
                BtnSave.FlatAppearance.BorderColor = Color.Gainsboro;
                BtnSave.ForeColor = Color.Gainsboro;
                BtnSave.Image = ((System.Drawing.Image)(Properties.Resources.ico_save_gray));
            }
        }

        private void BtnNegative_MouseLeave(object sender, EventArgs e)
        {
            if (!darkTheme)
            {
                BtnNegative.BackColor = Color.FromArgb(224, 224, 224);
                BtnNegative.ForeColor = Color.Black;
            }
            else
            {
                BtnNegative.FlatAppearance.BorderColor = Color.Gainsboro;
                BtnNegative.ForeColor = Color.Gainsboro;
            }
        }

        private void BtnGrayScale_MouseLeave(object sender, EventArgs e)
        {
            if (!darkTheme)
            {
                BtnGrayScale.BackColor = Color.FromArgb(224, 224, 224);
                BtnGrayScale.ForeColor = Color.Black;
            }
            else
            {
                BtnGrayScale.FlatAppearance.BorderColor = Color.Gainsboro;
                BtnGrayScale.ForeColor = Color.Gainsboro;
                BtnGrayScale.Image = ((System.Drawing.Image)(Properties.Resources.ico_grayscale));
            }
        }

        private void BtnMirroringHor_MouseLeave(object sender, EventArgs e)
        {
            if (!darkTheme)
            {
                BtnMirroringHor.BackColor = Color.FromArgb(224, 224, 224);
                BtnMirroringHor.ForeColor = Color.Black;
            }
            else
            {
                BtnMirroringHor.FlatAppearance.BorderColor = Color.Gainsboro;
                BtnMirroringHor.ForeColor = Color.Gainsboro;
                BtnMirroringHor.Image = ((System.Drawing.Image)(Properties.Resources.ico_mirror_horizontal_gray));
            }
        }

        private void BtnMirroringVer_MouseLeave(object sender, EventArgs e)
        {
            if (!darkTheme)
            {
                BtnMirroringVer.BackColor = Color.FromArgb(224, 224, 224);
                BtnMirroringVer.ForeColor = Color.Black;
            }
            else
            {
                BtnMirroringVer.FlatAppearance.BorderColor = Color.Gainsboro;
                BtnMirroringVer.ForeColor = Color.Gainsboro;
                BtnMirroringVer.Image = ((System.Drawing.Image)(Properties.Resources.ico_mirror_vertical_gray));
            }
        }

        private void BtnRotateRight_MouseLeave(object sender, EventArgs e)
        {
            if (!darkTheme)
            {
                BtnRotateRight.BackColor = Color.FromArgb(224, 224, 224);
                BtnRotateRight.ForeColor = Color.Black;
            }
            else
            {
                BtnRotateRight.FlatAppearance.BorderColor = Color.Gainsboro;
                BtnRotateRight.ForeColor = Color.Gainsboro;
                BtnRotateRight.Image = ((System.Drawing.Image)(Properties.Resources.ico_rotate_right_gray));
            }
        }

        private void BtnRotateLeft_MouseLeave(object sender, EventArgs e)
        {
            if (!darkTheme)
            {
                BtnRotateLeft.BackColor = Color.FromArgb(224, 224, 224);
                BtnRotateLeft.ForeColor = Color.Black;
            }
            else
            {
                BtnRotateLeft.FlatAppearance.BorderColor = Color.Gainsboro;
                BtnRotateLeft.ForeColor = Color.Gainsboro;
                BtnRotateLeft.Image = ((System.Drawing.Image)(Properties.Resources.ico_rotate_left_gray));
            }
        }

        private void BtnHistogram_MouseLeave(object sender, EventArgs e)
        {
            if (!darkTheme)
            {
                BtnHistogram.BackColor = Color.FromArgb(224, 224, 224);
                BtnHistogram.ForeColor = Color.Black;
            }
            else
            {
                BtnHistogram.FlatAppearance.BorderColor = Color.Gainsboro;
                BtnHistogram.ForeColor = Color.Gainsboro;
                BtnHistogram.Image = ((System.Drawing.Image)(Properties.Resources.ico_ok_gray));
            }
        }

        private void BtnColorChannels_MouseLeave(object sender, EventArgs e)
        {
            if (!darkTheme)
            {
                BtnColorChannels.BackColor = Color.FromArgb(224, 224, 224);
                BtnColorChannels.ForeColor = Color.Black;
            }
            else
            {
                BtnColorChannels.FlatAppearance.BorderColor = Color.Gainsboro;
                BtnColorChannels.ForeColor = Color.Gainsboro;
                BtnColorChannels.Image = ((System.Drawing.Image)(Properties.Resources.ico_ok_gray));
            }
        }

        private void ToggleTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (darkTheme)
            {
                darkTheme = false;
                LightThemeGroupBox();
                LightThemeButton();
                LightThemeLabel();
                LightThemePicture();
                LightThemeMenu();
                FrMetroStyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
            }
            else
            {
                darkTheme = true;
                DarkThemeGroupBox();
                DarkThemeButton();
                DarkThemeLabel();
                DarkThemePicture();
                DarkThemeMenu();
                FrMetroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
        }

        private void PictureBoxMain_MouseEnter(object sender, EventArgs e)
        {
            if (darkTheme)
            {
                PictureBoxMainIco.Image = ((System.Drawing.Image)(Properties.Resources.ico_main_hover));
            }
            else
            {
                PictureBoxMainIco.Image = ((System.Drawing.Image)(Properties.Resources.ico_main_hover));
            }
        }

        private void PictureBoxMain_MouseLeave(object sender, EventArgs e)
        {
            if (darkTheme)
            {
                PictureBoxMainIco.Image = ((System.Drawing.Image)(Properties.Resources.ico_main_gray));
            }
            else
            {
                PictureBoxMainIco.Image = ((System.Drawing.Image)(Properties.Resources.ico_main));
            }
        }

        private void LabelMainImage_MouseEnter(object sender, EventArgs e)
        {
            if (darkTheme)
            {
                PictureBoxMainIco.Image = ((System.Drawing.Image)(Properties.Resources.ico_main_hover));
            }
            else
            {
                PictureBoxMainIco.Image = ((System.Drawing.Image)(Properties.Resources.ico_main_hover));
            }
        }

        private void LabelMainImage_MouseLeave(object sender, EventArgs e)
        {
            if (darkTheme)
            {
                PictureBoxMainIco.Image = ((System.Drawing.Image)(Properties.Resources.ico_main_gray));
            }
            else
            {
                PictureBoxMainIco.Image = ((System.Drawing.Image)(Properties.Resources.ico_main));
            }
        }

        private void PictureBoxMainIco_MouseEnter(object sender, EventArgs e)
        {
            if (darkTheme)
            {
                PictureBoxMainIco.Image = ((System.Drawing.Image)(Properties.Resources.ico_main_hover));
            }
            else
            {
                PictureBoxMainIco.Image = ((System.Drawing.Image)(Properties.Resources.ico_main_hover));
            }
        }

        private void PictureBoxMainIco_MouseLeave(object sender, EventArgs e)
        {
            if (darkTheme)
            {
                PictureBoxMainIco.Image = ((System.Drawing.Image)(Properties.Resources.ico_main_gray));
            }
            else
            {
                PictureBoxMainIco.Image = ((System.Drawing.Image)(Properties.Resources.ico_main));
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox11_Enter(object sender, EventArgs e)
        {

        }
    }
}
