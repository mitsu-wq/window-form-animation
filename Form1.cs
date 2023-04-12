namespace lab_11;

public partial class Form1 : Form
{
    int ticks = 0; 
    System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
    public Form1()
    {
        InitializeComponent();

        this.Paint += this.Form1_Paint;
        timer1.Tick += this.timer1_Tick;
        timer1.Interval = 800;
        timer1.Start();
    }

    private void Form1_Paint(object sender, PaintEventArgs e){
        Graphics g = e.Graphics;
        Pen pen = new Pen(Brushes.Red, 5);

        if (ticks % 2 == 0){
            g.DrawArc(pen, 100, 100, 50, 50, 135, 180);
            g.DrawArc(pen, 135, 100, 50, 50, 225, 180);
            g.DrawLine(pen, 107, 142, 144, 179);
            g.DrawLine(pen, 178, 142, 141, 179);
        } else {
            g.DrawArc(pen, 95, 95, 60, 60, 135, 170);
            g.DrawArc(pen, 130, 95, 60, 60, 230, 180);
            g.DrawLine(pen, 100, 142, 144, 179);
            g.DrawLine(pen, 185, 142, 141, 179);
        }
    }

    private void timer1_Tick(object sender, EventArgs e){
        ticks++;
        Invalidate();   
    }
}
