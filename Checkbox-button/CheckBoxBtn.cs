using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp2
{
    public class CheckBoxBtn : Button
    {
        private bool isChecked = false;

        [DefaultValue(false)]
        [Category("Darstellung")]
        public bool Checked { 
            get {
                return isChecked;
            }
            set {
                isChecked = value;
                Invalidate();
            }
        }

        [Category("Darstellung")]
        [DefaultValue(0xE005)]
        public int SymbolChecked { get; set; } = 0xE005;

        [Category("Darstellung")]
        [DefaultValue(0xE002)]
        public int SymbolUnchecked { get; set; } = 0xE002;

        [ReadOnly(true)]
        public override string Text { get => base.Text; set => base.Text = value; }

        [DefaultValue(ContentAlignment.MiddleCenter)]
        public override ContentAlignment TextAlign { get => base.TextAlign; set => base.TextAlign = value; }

        public event EventHandler CheckedChanged;

        public CheckBoxBtn() : base()
        {

        }

        protected override Size DefaultSize => new Size(30, 30);

        protected override void InitLayout()
        {
            base.InitLayout();
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Font = new Font("Segoe UI Symbol", 12);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            isChecked = !isChecked;

            OnCheckedChanged(e);
            Invalidate();
        }

        protected virtual void OnCheckedChanged(EventArgs e)
        {
            CheckedChanged?.Invoke(this, e);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            UpdateBtnText();
            base.OnPaint(pevent);
        }

        protected void UpdateBtnText()
        {
            Text = char.ConvertFromUtf32(Checked ? SymbolChecked : SymbolUnchecked);
        }
    }
}
