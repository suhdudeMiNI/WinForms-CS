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



namespace PrwSg_WinForms
{
    struct stroka
    {
        public Point cor;
        public string text;
        public SizeF sizeTxt;
        public int FontSizeAdd;
        public int alignusha;
        public bool cheked;
    }

    public partial class Form1 : Form
    {
        int shirina = 300;
        int wysota = 500;
        int SpShir = 30;
        Color cvetik = Color.Thistle;
        Color cvetTxt = Color.Black;
        int aligg;
        int FontSize = 16;
        string addText;
        bool MoveText = false;
        Point relat;
        List<stroka> tab = new List<stroka>();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        //https://docs.microsoft.com/en-us/dotnet/api/system.drawing.pen?view=net-5.0

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.DarkGray, 2);
            SolidBrush br = new SolidBrush(cvetik);
            p.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
            Rectangle rt = new Rectangle(pictureBox1.Width / 2 - shirina - SpShir/2, pictureBox1.Height / 2 - wysota / 2, shirina, wysota);
            Rectangle rc = new Rectangle(pictureBox1.Width / 2 - SpShir / 2, pictureBox1.Height / 2 - wysota / 2, SpShir, wysota);
            Rectangle ra = new Rectangle(pictureBox1.Width / 2 + SpShir / 2 , pictureBox1.Height / 2 - wysota / 2, shirina, wysota);
            e.Graphics.FillRectangle(br, rt);
            e.Graphics.FillRectangle(br, rc);
            e.Graphics.FillRectangle(br, ra);
            e.Graphics.DrawRectangle(p, rt);
            e.Graphics.DrawRectangle(p, rc);
            e.Graphics.DrawRectangle(p, ra);
            p.Dispose();
            br.Dispose();

            Point pon = new Point();
            SizeF txtSize = new SizeF();
            foreach (var el in tab)
            {
                SolidBrush sb = new SolidBrush(cvetTxt);
                Font f = new Font("Arial", el.FontSizeAdd);

                txtSize = e.Graphics.MeasureString(el.text, f);
                pon.X = el.cor.X + (pictureBox1.Width / 2 - shirina - SpShir / 2) - (int)(txtSize.Width / 2);
                pon.Y = el.cor.Y + (pictureBox1.Height / 2 - wysota/2) - (int)(txtSize.Height / 2);
                e.Graphics.DrawString(el.text, f, sb, pon);
                sb.Dispose();
                f.Dispose();
            }

            for(int i = 32; i > 0; i--)
            {
                
                SizeF chl = new SizeF();
                Font fn = new Font("Arial", i);
                SolidBrush sba = new SolidBrush(cvetTxt);
                Point poni = new Point();
                chl = e.Graphics.MeasureString(TitleBox.Text, fn);
                if(chl.Width < shirina && chl.Height < wysota/3)
                {
                    poni.X = pictureBox1.Width / 2 + SpShir / 2 + shirina / 2 - (int)chl.Width / 2;
                    poni.Y = pictureBox1.Height / 2 - wysota / 2 + wysota / 6 - (int)chl.Height / 2;
                    e.Graphics.DrawString(TitleBox.Text, fn, sba, poni);
                    break;
                }
                fn.Dispose();
                sba.Dispose();
            }

            for (int i = 24; i > 0; i--)
            {
                SizeF chle = new SizeF();
                Font fna = new Font("Arial", i);
                SolidBrush sbaA = new SolidBrush(cvetTxt);
                Point poniA = new Point();
                chle = e.Graphics.MeasureString(AuthorBox.Text, fna);
                if (chle.Width < shirina && chle.Height < wysota / 6)
                {
                    poniA.X = pictureBox1.Width / 2 + SpShir / 2 + shirina / 2 - (int)chle.Width / 2;
                    poniA.Y = pictureBox1.Height / 2 - wysota / 2 + wysota / 2;
                    e.Graphics.DrawString(AuthorBox.Text, fna, sbaA, poniA);
                    break;
                }
                fna.Dispose();
                sbaA.Dispose();
            }


            //https://docs.microsoft.com/en-us/dotnet/api/system.drawing.graphics.rotatetransform?view=net-5.0
            // Author
            for (int i = 24; i > 0; i--)
            {
                string aut = AuthorBox.Text;
                while (aut.Contains("  "))
                {
                    aut = aut.Replace("  ", " ");

                }
                SizeF chleSP = new SizeF();
                Font fna = new Font("Arial", i);
                SolidBrush sbaASP = new SolidBrush(cvetTxt);
                Point poniA = new Point();
                chleSP = e.Graphics.MeasureString(aut, fna);
                if (chleSP.Width < wysota/2 && chleSP.Height < SpShir)
                {
                    e.Graphics.TranslateTransform(pictureBox1.Width / 2 - (int)chleSP.Height / 2, pictureBox1.Height / 2 - wysota / 4 + (int)chleSP.Width / 2);
                    e.Graphics.RotateTransform(-90.0F);
                    while (aut.Contains("  "))
                    {
                        aut = aut.Replace("  ", " ");
                    }
                    e.Graphics.DrawString(aut, fna, sbaASP, poniA);
                    e.Graphics.ResetTransform();
                    break;
                }
                fna.Dispose();
                sbaASP.Dispose();
            }

            //Title
            for (int i = 32; i > 0; i--)
            {
                string tit = TitleBox.Text;
                while (tit.Contains("  ") || tit.Contains("\n"))
                {
                    tit = tit.Replace("  ", " ");
                    tit = tit.Replace("\n", " ");
                }
                SizeF chleSP = new SizeF();
                Font fna = new Font("Arial", i);
                SolidBrush sbaASP = new SolidBrush(cvetTxt);
                Point poniAsp = new Point();
                chleSP = e.Graphics.MeasureString(tit, fna);
                
                if (chleSP.Width < wysota / 2 && chleSP.Height < SpShir)
                {
                    
                    e.Graphics.TranslateTransform(pictureBox1.Width / 2 -(int)chleSP.Height / 2, pictureBox1.Height/2 + wysota / 4 + (int)chleSP.Width / 2);
                    e.Graphics.RotateTransform(-90.0F);


                    e.Graphics.DrawString(tit, fna, sbaASP, poniAsp);
                    e.Graphics.ResetTransform();
                    break;
                }
                fna.Dispose();
                sbaASP.Dispose();
            }

            foreach(var el in tab)
            {
                if(el.cheked == true)
                {
                    
                    Color newCvetik = Color.FromArgb(255 - cvetik.R, 255 - cvetik.G, 255 - cvetik.B);
                    Pen pp = new Pen(newCvetik, 2);
                    Rectangle rtp = new Rectangle(el.cor.X + (pictureBox1.Width / 2 - shirina - SpShir / 2) - (int)el.sizeTxt.Width / 2, el.cor.Y + (pictureBox1.Height / 2 - wysota / 2) - (int)el.sizeTxt.Height / 2, (int)el.sizeTxt.Width, (int)el.sizeTxt.Height);
                    e.Graphics.DrawRectangle(pp, rtp);
                    pp.Dispose();                   
                }
            }

        }

        private void AddTextButton_Click(object sender, EventArgs e)
        {

            using (Form3 dlg2 = new Form3())
            {
                if (dlg2.ShowDialog() == DialogResult.OK)
                {
                    aligg = dlg2.align;
                    FontSize = dlg2.FSize;
                    addText = dlg2.ADDtxt;
                    if (addText.Length > 0)
                    {
                        pictureBox1.Cursor = Cursors.Cross;
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Cursor == Cursors.Cross)
            {
                Font f = new Font("Arial", FontSize);
                Graphics gr = pictureBox1.CreateGraphics();
                Point pon = new Point();
                stroka strochka = new stroka();
                pon = pictureBox1.PointToClient(Cursor.Position);               
                strochka.cor.X = pon.X - (pictureBox1.Width / 2 - (shirina + SpShir / 2));
                strochka.cor.Y = pon.Y - (pictureBox1.Height / 2 - wysota / 2);
                strochka.text = addText;
                strochka.FontSizeAdd = FontSize;
                SizeF txtSize = gr.MeasureString(strochka.text, f);
                strochka.sizeTxt.Width = txtSize.Width;
                strochka.sizeTxt.Height = txtSize.Height;
                strochka.alignusha = aligg;
                tab.Add(strochka);
                pictureBox1.Cursor = Cursors.Default;
                pictureBox1.Invalidate();
                gr.Dispose();
                f.Dispose();
            }            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void EngLang_Click(object sender, EventArgs e)
        {
            EngLang.Checked = true;
            PolLang.Checked = false;
        }

        private void PolLang_Click(object sender, EventArgs e)
        {
            EngLang.Checked = false;
            PolLang.Checked = true;
        }

        private void NewFileItem_Click(object sender, EventArgs e)
        {
            using(Form2 dlg1 = new Form2())
            {
                if (dlg1.ShowDialog() == DialogResult.OK)
                {
                    shirina = dlg1.newWidth;
                    wysota = dlg1.newHeight;
                    SpShir = dlg1.newSpWidth;
                    cvetik = Color.Thistle;
                    cvetTxt = Color.Black;
                    TitleBox.Clear();
                    AuthorBox.Clear();
                    tab.Clear();
                    pictureBox1.Invalidate();
                    
                }
            }            
        }

        private void TitleBox_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void BackgroundColButton_Click(object sender, EventArgs e)
        {
            ColorDialog cvet = new ColorDialog();
            cvet.ShowDialog();
            cvetik = cvet.Color;            
            pictureBox1.Invalidate();
        }

        private void TxtColButton_Click(object sender, EventArgs e)
        {

            ColorDialog cvet = new ColorDialog();
            cvet.ShowDialog();
            cvetTxt = cvet.Color;
            pictureBox1.Invalidate();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            using(Form3 dlg3 = new Form3())
            {
                var relativePoint1 = pictureBox1.PointToClient(Cursor.Position);
                foreach (var el in tab)
                {

                    if (relativePoint1.X - (pictureBox1.Width / 2 - (shirina + SpShir / 2)) <= (el.cor.X + (int)el.sizeTxt.Width / 2) && 
                        relativePoint1.X - (pictureBox1.Width / 2 - (shirina + SpShir / 2)) >= (el.cor.X - (int)el.sizeTxt.Width/2) &&
                        relativePoint1.Y - (pictureBox1.Height / 2 - wysota / 2) <= (el.cor.Y + (int)el.sizeTxt.Height / 2) && 
                        relativePoint1.Y - (pictureBox1.Height / 2 - wysota / 2) >= (el.cor.Y - (int)el.sizeTxt.Height / 2))
                    {

                        stroka strochka = new stroka();
                        Graphics gr = pictureBox1.CreateGraphics();
                        SizeF si = new SizeF();
                        dlg3.SetText(el.text);
                        dlg3.SetFont(el.FontSizeAdd);
                        dlg3.SetAlign(el.alignusha);
                        if (dlg3.ShowDialog() == DialogResult.OK)
                        {
                            strochka.alignusha = dlg3.align;
                            strochka.text = dlg3.ADDtxt;
                            strochka.FontSizeAdd = dlg3.FSize;
                            si = gr.MeasureString(strochka.text, new Font("Arial", strochka.FontSizeAdd));
                            strochka.sizeTxt = si;
                            strochka.cor = el.cor;
                            tab.Remove(el);
                            tab.Add(strochka);
                            pictureBox1.Invalidate();
                        }
                        break;
                    }
                }
            }            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            var relativePoint1 = pictureBox1.PointToClient(Cursor.Position);

            switch (e.Button)
            {
            case MouseButtons.Right:
                {
                    foreach (var el in tab)
                    {
                        if (el.cheked == true)
                        {
                            stroka strochka = new stroka();
                            strochka.text = el.text;
                            strochka.sizeTxt = el.sizeTxt;
                            strochka.cor = el.cor;
                            strochka.cheked = false;
                            strochka.alignusha = el.alignusha;
                            strochka.FontSizeAdd = el.FontSizeAdd;
                            tab.Remove(el);
                            tab.Add(strochka);
                            pictureBox1.Invalidate();
                            break;
                        }
                    }

                    foreach (var el in tab)
                    {
                        if (relativePoint1.X - (pictureBox1.Width / 2 - (shirina + SpShir / 2)) <= (el.cor.X + (int)el.sizeTxt.Width / 2) &&
                            relativePoint1.X - (pictureBox1.Width / 2 - (shirina + SpShir / 2)) >= (el.cor.X - (int)el.sizeTxt.Width / 2) &&
                            relativePoint1.Y - (pictureBox1.Height / 2 - wysota / 2) <= (el.cor.Y + (int)el.sizeTxt.Height / 2) &&
                            relativePoint1.Y - (pictureBox1.Height / 2 - wysota / 2) >= (el.cor.Y - (int)el.sizeTxt.Height / 2))
                        {
                            stroka strochkap = new stroka();
                            strochkap.text = el.text;
                            strochkap.sizeTxt = el.sizeTxt;
                            strochkap.cor = el.cor;
                            strochkap.cheked = true;
                            strochkap.alignusha = el.alignusha;
                            strochkap.FontSizeAdd = el.FontSizeAdd;
                            tab.Remove(el);
                            tab.Add(strochkap);
                            pictureBox1.Invalidate();
                            break;
                        }
                    }
                    break;
                }
                case MouseButtons.Middle:
                    {
                        MoveText = false;
                        break;
                    }
            }                
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                foreach(var el in tab)
                {
                    if(el.cheked)
                    {
                        tab.Remove(el);
                        pictureBox1.Invalidate();
                        break;
                    }    
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            var relativePoint1 = pictureBox1.PointToClient(Cursor.Position);
           
            switch (e.Button)
            {
            case MouseButtons.Middle:
                {
                    MoveText = true;
                    foreach (var el in tab)
                    {
                        if (el.cheked)
                        {
                            relat.X = el.cor.X - relativePoint1.X;
                            relat.Y = el.cor.Y - relativePoint1.Y;
                            break;
                        }
                    }
                    break;
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            var relativePoint1 = pictureBox1.PointToClient(Cursor.Position);
            if (MoveText)
            {
                foreach(var el in tab)
                {
                    if(el.cheked)
                    {
                        stroka strochka = new stroka();
                        strochka.text = el.text;
                        strochka.sizeTxt = el.sizeTxt;
                        strochka.cor = el.cor;
                        strochka.cheked = el.cheked;
                        strochka.alignusha = el.alignusha;
                        strochka.FontSizeAdd = el.FontSizeAdd;
                        strochka.cor.X = relativePoint1.X + relat.X;
                        strochka.cor.Y = relativePoint1.Y + relat.Y;
                        tab.Remove(el);
                        tab.Add(strochka);
                       
                        pictureBox1.Invalidate();
                        break;
                    }
                }
            }
        }

        private void SaveFileItem_Click(object sender, EventArgs e)
        {
            Stream plik;
            SaveFileDialog dlg4 = new SaveFileDialog();
            dlg4.Filter = "txt files (*.txt)|*.txt";
            if(dlg4.ShowDialog() == DialogResult.OK)
            {
                if((plik = dlg4.OpenFile()) != null)
                {

                    using (StreamWriter pisar = new StreamWriter(plik, System.Text.Encoding.Default))
                    {
                        pisar.WriteLine(shirina);
                        pisar.WriteLine(wysota);
                        pisar.WriteLine(SpShir);
                        pisar.WriteLine(TitleBox.Text.Replace("\n", "{}"));
                        pisar.WriteLine(AuthorBox.Text);
                        pisar.WriteLine(cvetik.R);
                        pisar.WriteLine(cvetik.G);
                        pisar.WriteLine(cvetik.B);
                        pisar.WriteLine(cvetTxt.R);
                        pisar.WriteLine(cvetTxt.G);
                        pisar.WriteLine(cvetTxt.B);
                        foreach (var el in tab)
                            pisar.WriteLine(el.text + "{}" + el.FontSizeAdd + "{}" + el.cor.X + "{}" + el.cor.Y + "{}" + el.alignusha +"{}"+ (int)el.sizeTxt.Width + "{}" + (int)el.sizeTxt.Height);
                    }
                    plik.Close();
                }
            }
        }

        private void OpenFileItem_Click(object sender, EventArgs e)
        {
            Stream plik;
            OpenFileDialog dlg4 = new OpenFileDialog();
            dlg4.Filter = "txt files (*.txt)|*.txt";
            if (dlg4.ShowDialog() == DialogResult.OK)
            {
                if ((plik = dlg4.OpenFile()) != null)
                {
                    using (StreamReader chtec = new StreamReader(plik, System.Text.Encoding.Default))
                    {
                        shirina = int.Parse(chtec.ReadLine());
                        wysota = int.Parse(chtec.ReadLine());
                        SpShir = int.Parse(chtec.ReadLine());
                        TitleBox.Text = chtec.ReadLine().Replace("{}", "\n");
                        AuthorBox.Text = chtec.ReadLine();

                        cvetik = Color.FromArgb(int.Parse(chtec.ReadLine()), int.Parse(chtec.ReadLine()), int.Parse(chtec.ReadLine()));
                        cvetTxt = Color.FromArgb(int.Parse(chtec.ReadLine()), int.Parse(chtec.ReadLine()), int.Parse(chtec.ReadLine()));
                        string chl;
                        tab = new List<stroka>();
                        while ((chl = chtec.ReadLine()) != null)
                        {
                            string[] mnogochlen = chl.Split("{}");
                            stroka strochka = new stroka();
                            strochka.text = mnogochlen[0];
                            strochka.FontSizeAdd = int.Parse(mnogochlen[1]);
                            strochka.cor.X = int.Parse(mnogochlen[2]);
                            strochka.cor.Y = int.Parse(mnogochlen[3]);
                            strochka.alignusha = int.Parse(mnogochlen[4]);
                            strochka.sizeTxt.Width = int.Parse(mnogochlen[5]);
                            strochka.sizeTxt.Height = int.Parse(mnogochlen[6]);
                            tab.Add(strochka);

                        }

                    }
                        plik.Close();
                }
            }
            pictureBox1.Invalidate();
            
        }
    }
}
