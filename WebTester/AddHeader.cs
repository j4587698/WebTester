using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WebTester.Entity;

namespace WebTester
{
    public partial class AddHeader : Form
    {

        private readonly List<HeaderEntity> _headerList;
        private readonly BindingSource headerSource = new BindingSource();

        public AddHeader(List<HeaderEntity> headerList)
        {
            _headerList = headerList;
            InitializeComponent();
            gvHeaders.DataSource = headerSource;
            headerSource.DataSource = _headerList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbKey.Text.IsNullOrEmpty() || txtValue.Text.IsNullOrEmpty())
            {
                MessageBox.Show(@"键或值为空！");
                return;
            }

            var header = _headerList.FirstOrDefault(x => x.Key == cbKey.Text);
            if (header == null)
            {
                _headerList.Add(new HeaderEntity(){Key = cbKey.Text, Value = txtValue.Text});
            }
            else
            {
                header.Key = cbKey.Text;
                header.Value = txtValue.Text;
            }
            headerSource.ResetBindings(false);

        }
    }
}
