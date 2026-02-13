using System.Drawing;
using System.Windows.Forms;

namespace Library_Management_System
{
    public static class FormTheme
    {
        private static readonly Color BgPrimary = Color.FromArgb(13, 13, 13);
        private static readonly Color BgSecondary = Color.FromArgb(22, 22, 22);
        private static readonly Color BorderColor = Color.FromArgb(184, 134, 11);
        private static readonly Color AccentGold = Color.FromArgb(212, 175, 55);
        private static readonly Color TextPrimary = Color.FromArgb(245, 245, 245);

        public static void Apply(Form form)
        {
            form.BackColor = BgPrimary;
            form.ForeColor = TextPrimary;
            form.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StyleControls(form.Controls);
        }

        private static void StyleControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                StyleControl(control);

                if (control.HasChildren)
                {
                    StyleControls(control.Controls);
                }
            }
        }

        private static void StyleControl(Control control)
        {
            if (control is Label)
            {
                control.ForeColor = TextPrimary;
                control.BackColor = Color.Transparent;
                return;
            }

            if (control is Button button)
            {
                button.BackColor = AccentGold;
                button.ForeColor = Color.Black;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderColor = BorderColor;
                button.FlatAppearance.BorderSize = 1;
                button.Cursor = Cursors.Hand;
                return;
            }

            if (control is TextBox textBox)
            {
                textBox.BackColor = BgSecondary;
                textBox.ForeColor = TextPrimary;
                textBox.BorderStyle = BorderStyle.FixedSingle;
                return;
            }

            if (control is RichTextBox richTextBox)
            {
                richTextBox.BackColor = BgSecondary;
                richTextBox.ForeColor = TextPrimary;
                richTextBox.BorderStyle = BorderStyle.FixedSingle;
                return;
            }

            if (control is ComboBox comboBox)
            {
                comboBox.BackColor = BgSecondary;
                comboBox.ForeColor = TextPrimary;
                comboBox.FlatStyle = FlatStyle.Flat;
                return;
            }

            if (control is NumericUpDown numeric)
            {
                numeric.BackColor = BgSecondary;
                numeric.ForeColor = TextPrimary;
                return;
            }

            if (control is DateTimePicker date)
            {
                date.CalendarMonthBackground = BgSecondary;
                date.CalendarForeColor = TextPrimary;
                date.CalendarTitleBackColor = AccentGold;
                date.CalendarTitleForeColor = Color.Black;
                return;
            }

            if (control is CheckBox checkBox)
            {
                checkBox.ForeColor = TextPrimary;
                checkBox.BackColor = Color.Transparent;
                return;
            }

            if (control is TabControl tabControl)
            {
                tabControl.BackColor = BgPrimary;
                tabControl.ForeColor = TextPrimary;
                return;
            }

            if (control is TabPage tabPage)
            {
                tabPage.BackColor = BgPrimary;
                tabPage.ForeColor = TextPrimary;
                return;
            }

            if (control is GroupBox groupBox)
            {
                groupBox.ForeColor = AccentGold;
                groupBox.BackColor = BgPrimary;
                return;
            }

            if (control is DataGridView grid)
            {
                grid.BackgroundColor = BgSecondary;
                grid.BorderStyle = BorderStyle.None;
                grid.EnableHeadersVisualStyles = false;
                grid.ColumnHeadersDefaultCellStyle.BackColor = AccentGold;
                grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                grid.DefaultCellStyle.BackColor = BgSecondary;
                grid.DefaultCellStyle.ForeColor = TextPrimary;
                grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(64, 64, 64);
                grid.DefaultCellStyle.SelectionForeColor = TextPrimary;
                grid.RowHeadersDefaultCellStyle.BackColor = BgSecondary;
                grid.RowHeadersDefaultCellStyle.ForeColor = TextPrimary;
                grid.GridColor = BorderColor;
                return;
            }

            if (control is Panel || control is FlowLayoutPanel || control is TableLayoutPanel)
            {
                control.BackColor = BgPrimary;
                return;
            }

            control.BackColor = BgPrimary;
            control.ForeColor = TextPrimary;
        }
    }
}
